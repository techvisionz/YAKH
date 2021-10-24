using Confluent.Kafka;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAKH.classes;

namespace YAKH
{
    public partial class MainForm : Form
    {
        KafkaManager _kafkaManager = null;
        KafkaServer _kafkaServer;
        MainForm me;
        string _selectedTopic = "";
        bool isListening = false;
        bool loggingEnabled = false;
        public MainForm()
        {
            InitializeComponent();
        }

        #region UI Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            uiLogging.SelectedIndex = 0;
            uiStoreOffset.SelectedIndex = 0;
            me = this;

            loadServers();
            initChart();
        }

        private void uiClear_Click(object sender, EventArgs e)
        {
            Utilities.Clear(ref me);
        }

        private void uiAddServer_Click(object sender, EventArgs e)
        {
            ServerInfo serverInfo = new ServerInfo();
            serverInfo.onDBUpdated += serverInfo_dbUpdated;
            serverInfo.ShowDialog(this);
        }

        private void uiEditServer_Click(object sender, EventArgs e)
        {
            ServerInfo serverInfo = new ServerInfo();
            serverInfo.isEdit = true;
            serverInfo.onDBUpdated += serverInfo_dbUpdated;
            serverInfo.ServerHost = uiServers.SelectedNode.Text;
            serverInfo.ShowDialog(this);
        }

        private void uiConnect_Click(object sender, EventArgs e)
        {

            if (this.isListening)
            {
                MessageBox.Show("Please stop the listener");
                return;
            }

            bool useFilter = string.IsNullOrEmpty(uiFilter.Text);
            bool storeOffset = uiStoreOffset.SelectedIndex == 0 ? false : true;
            this.isListening = true;
            timer1.Interval = int.Parse(uiInterval.Text);
            this.loggingEnabled = uiLogging.SelectedIndex == 0 ? false : true;

            if (uiServers.SelectedNode == null)
            {
                MessageBox.Show("Please select the server");
                return;
            }

            this._selectedTopic = uiServers.SelectedNode.Text;

            this._kafkaServer = DBManager.findServer(uiServers.SelectedNode.Parent.Text);

            if (this._kafkaServer == null)
            {
                MessageBox.Show("Kafka server not found");
                return;
            }

            this._kafkaManager = new KafkaManager(this._kafkaServer.Host, this._kafkaServer.Port, AutoOffsetReset.Earliest, storeOffset);
            this._kafkaManager.onMessageReceived += kafkaManager_messageReceived;

            if (!this._kafkaManager.topicExists(this._selectedTopic))
            {
                Utilities.UpdateLogViewer(ref me, DateTime.Now.ToString() + " : Make sure server is up and Topic [" + uiServers.SelectedNode.Text + "] exists");
                stopListening();
                this.isListening = true;
                return;
            }

            Task.Factory.StartNew(() => startReadingAsync());
            uiStop.Enabled = true;

            timer1.Start();
        }

        private void uiStop_Click(object sender, EventArgs e)
        {
            this.isListening = false;
            stopListening();
        }

        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Utilities.UpdateLogViewer(ref me, "Messages found: [" + this._kafkaManager.DataStream().total() + "]");

            uiChart.Invoke((MethodInvoker)delegate
            {
                DateTime date = DateTime.Now;
                int endPos = this._kafkaManager.DataStream().ChartThreshold;
                int curPos = this._kafkaManager.DataStream().ChartCounter;

                for (int i = 0; i < endPos; i++)
                {
                    uiChartContent.Series[0].Values[i] = uiChartContent.Series[0].Values[i + 1];
                    uiChartContent.AxisX[0].Labels[i] = uiChartContent.AxisX[0].Labels[i + 1];
                }

                uiChartContent.Series[0].Values[endPos] = this._kafkaManager.DataStream().addChartData(date);
                uiChartContent.AxisX[0].Labels[endPos] = date.ToString("T");
            });
        }

        private void uiServers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            uiServers.SelectedNode = e.Node;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isListening)
            {
                e.Cancel = true;
                MessageBox.Show("Please stop the listener");
            }
        }

        #endregion

        #region UI Logic
        private void kafkaManager_messageReceived(ConsumeResult<Ignore, string> consumeResult)
        {
            if (this.loggingEnabled)
            {
                Utilities.UpdateLogViewer(ref me, consumeResult.Message.Timestamp.UtcDateTime.ToString() + " : " + consumeResult.Message.Value);
            }
        }

        private void startReadingAsync()
        {
            if (this._kafkaManager != null)
            {
                Utilities.UpdateLogViewer(ref me, DateTime.Now.ToString() + " : Kafka client is listening on [" + this._kafkaServer.Host + ":" + this._kafkaServer.Port + "] for topic [" + this._selectedTopic + "] with group id [" + this._kafkaServer.GroupId + "]");
                this._kafkaManager.startListening(this._selectedTopic, this._kafkaServer.GroupId, uiFilter.Text, int.Parse(uiInterval.Text));
            }

        }
        private void serverInfo_dbUpdated()
        {
            loadServers();
        }
        private void initChart()
        {
            uiChartContent.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Message Count",
                    Values =  new ChartValues<int> {0,0, 0, 0, 0, 0, 0, 0, 0, 0,0 }
                }
            };

            uiChartContent.AxisX.Add(new Axis
            {
                Title = "Time",
                Labels = new[] { DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T"), DateTime.Now.ToString("T") }
            });

            uiChartContent.LegendLocation = LegendLocation.Right;

            uiChartContent.DataClick += CartesianChart1OnDataClick;
        }

        private void loadServers()
        {
            uiServers.Invoke((MethodInvoker)delegate {
                uiServers.Nodes.Clear();

                var servers = DBManager.getServers();

                if (servers != null)
                {
                    foreach (var server in servers)
                    {
                        TreeNode serverNode = new TreeNode(server.Host);
                        serverNode.ContextMenuStrip = uiTreeItemContext;
                        foreach (var topic in server.Topics)
                        {
                            TreeNode topicNode = new TreeNode(topic);
                            topicNode.ContextMenuStrip = uiTreeItemTopicContext;
                            serverNode.Nodes.Add(topicNode);
                        }
                        uiServers.Nodes.Add(serverNode);
                    }
                }
            });
        }

        private void stopListening()
        {
            timer1.Stop();

            if (this._kafkaManager != null)
            {
                this._kafkaManager.stopListening();
                this._kafkaManager = null;
            }

            uiStop.Enabled = false;
        }


        #endregion
    }
}
