using System;
using System.Windows.Forms;
using YAKH.classes;

namespace YAKH
{
    public partial class ServerInfo : Form
    {
        public delegate void DBUpdated();
        public DBUpdated onDBUpdated;
        public bool isEdit { get; set; }
        public string ServerHost { get; set; }       

        KafkaServer EditServer { get; set; }

        public ServerInfo()
        {
            InitializeComponent();
        }

        private void ServerInfo_Load(object sender, EventArgs e)
        {
            if (this.isEdit)
            {
                this.EditServer = DBManager.findServer(this.ServerHost);

                if (this.EditServer == null)
                {
                    MessageBox.Show("Server not found");
                    this.Close();
                }

                uiHost.Text = this.EditServer.Host;
                uiPort.Text = this.EditServer.Port.ToString();
                uiGroupId.Text = this.EditServer.GroupId;

                foreach (var topic in this.EditServer.Topics)
                {
                    uiTopics.Items.Add(topic);
                }
            }
        }

        private void uiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uiTopic.Text) || uiTopics.Items.Contains(uiTopic.Text))
            {
                MessageBox.Show("Please provide unique topic name");
                uiTopic.Focus();
                return;
            }

            uiTopics.Items.Add(uiTopic.Text);
        }

        private void uiDelete_Click(object sender, EventArgs e)
        {
            if (uiTopics.SelectedItem != null)
            {
                uiTopics.Items.Remove(uiTopics.SelectedItem);
            }
        }

        private void createServer()
        {
            if ((string.IsNullOrEmpty(uiHost.Text) || DBManager.findServer(uiHost.Text) != null) && uiHost.Text != this.EditServer.Host)
            {
                MessageBox.Show("Please provide unique server/host/ip name");
                uiHost.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(uiPort.Text))
            {
                MessageBox.Show("Please provide port number");
                uiPort.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(uiGroupId.Text))
            {
                MessageBox.Show("Please provide group id");
                uiGroupId.Focus();
                return;
            }

            KafkaServer server = this.EditServer;

            if (this.EditServer != null)
            {
                this.EditServer.Topics.Clear();
            }

            if (!this.isEdit)
            {
                server = new KafkaServer();
            }

            server.Host = uiHost.Text;
            server.Port = int.Parse(uiPort.Text);
            server.GroupId = uiGroupId.Text;

            foreach (var topic in uiTopics.Items)
            {
                server.Topics.Add(topic.ToString());
            }

            if (!this.isEdit)
            {
                DBManager.createServer(server);

                MessageBox.Show("Server Created");
                uiHost.Text = "";
                uiPort.Text = "9092";
                uiGroupId.Text = "";
                uiTopic.Text = "";
                uiTopics.Items.Clear();
            }
            else
            {
                DBManager.updateServer(server);

                MessageBox.Show("Server updated");
                uiTopic.Text = "";
            }

            if (onDBUpdated != null)
            {
                onDBUpdated();
            }
        }

        private void uiSave_Click(object sender, EventArgs e)
        {
            createServer();
        }
    }
}
