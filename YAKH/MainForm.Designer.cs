
namespace YAKH
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiToolStrip = new System.Windows.Forms.ToolStrip();
            this.uiStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.uiFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.uiInterval = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.uiLogging = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.uiStoreOffset = new System.Windows.Forms.ToolStripComboBox();
            this.uiLog = new System.Windows.Forms.TextBox();
            this.uiCtxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.uiServers = new System.Windows.Forms.TreeView();
            this.uiTreeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiAddServer = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTreeItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiEditServer = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTreeItemTopicContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.uiChart = new System.Windows.Forms.Integration.ElementHost();
            this.uiChartContent = new LiveCharts.Wpf.CartesianChart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiToolStrip.SuspendLayout();
            this.uiCtxMenuStrip.SuspendLayout();
            this.uiTreeContext.SuspendLayout();
            this.uiTreeItemContext.SuspendLayout();
            this.uiTreeItemTopicContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiToolStrip
            // 
            this.uiToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiStop,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.uiFilter,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.uiInterval,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.uiLogging,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.uiStoreOffset});
            this.uiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uiToolStrip.Name = "uiToolStrip";
            this.uiToolStrip.Size = new System.Drawing.Size(1216, 34);
            this.uiToolStrip.TabIndex = 1;
            this.uiToolStrip.Text = "toolStrip1";
            // 
            // uiStop
            // 
            this.uiStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uiStop.Image = ((System.Drawing.Image)(resources.GetObject("uiStop.Image")));
            this.uiStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiStop.Name = "uiStop";
            this.uiStop.Size = new System.Drawing.Size(53, 29);
            this.uiStop.Text = "Stop";
            this.uiStop.Click += new System.EventHandler(this.uiStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 29);
            this.toolStripLabel1.Text = "Filter:";
            // 
            // uiFilter
            // 
            this.uiFilter.Name = "uiFilter";
            this.uiFilter.Size = new System.Drawing.Size(200, 34);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 29);
            this.toolStripLabel2.Text = "Interval";
            // 
            // uiInterval
            // 
            this.uiInterval.Name = "uiInterval";
            this.uiInterval.Size = new System.Drawing.Size(100, 34);
            this.uiInterval.Text = "5000";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(82, 29);
            this.toolStripLabel3.Text = "Logging:";
            // 
            // uiLogging
            // 
            this.uiLogging.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.uiLogging.Name = "uiLogging";
            this.uiLogging.Size = new System.Drawing.Size(121, 34);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(111, 29);
            this.toolStripLabel4.Text = "Store Offset:";
            // 
            // uiStoreOffset
            // 
            this.uiStoreOffset.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.uiStoreOffset.Name = "uiStoreOffset";
            this.uiStoreOffset.Size = new System.Drawing.Size(121, 34);
            // 
            // uiLog
            // 
            this.uiLog.ContextMenuStrip = this.uiCtxMenuStrip;
            this.uiLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiLog.Location = new System.Drawing.Point(0, 243);
            this.uiLog.Multiline = true;
            this.uiLog.Name = "uiLog";
            this.uiLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiLog.Size = new System.Drawing.Size(1216, 292);
            this.uiLog.TabIndex = 2;
            // 
            // uiCtxMenuStrip
            // 
            this.uiCtxMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiCtxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiClear});
            this.uiCtxMenuStrip.Name = "uiCtxMenuStrip";
            this.uiCtxMenuStrip.Size = new System.Drawing.Size(124, 36);
            // 
            // uiClear
            // 
            this.uiClear.Name = "uiClear";
            this.uiClear.Size = new System.Drawing.Size(123, 32);
            this.uiClear.Text = "Clear";
            this.uiClear.Click += new System.EventHandler(this.uiClear_Click);
            // 
            // uiServers
            // 
            this.uiServers.ContextMenuStrip = this.uiTreeContext;
            this.uiServers.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiServers.Location = new System.Drawing.Point(0, 34);
            this.uiServers.Name = "uiServers";
            this.uiServers.Size = new System.Drawing.Size(209, 209);
            this.uiServers.TabIndex = 3;
            this.uiServers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.uiServers_NodeMouseClick);
            // 
            // uiTreeContext
            // 
            this.uiTreeContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiTreeContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiAddServer});
            this.uiTreeContext.Name = "uiTreeContext";
            this.uiTreeContext.Size = new System.Drawing.Size(173, 36);
            // 
            // uiAddServer
            // 
            this.uiAddServer.Name = "uiAddServer";
            this.uiAddServer.Size = new System.Drawing.Size(172, 32);
            this.uiAddServer.Text = "Add Server";
            this.uiAddServer.Click += new System.EventHandler(this.uiAddServer_Click);
            // 
            // uiTreeItemContext
            // 
            this.uiTreeItemContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiTreeItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiEditServer});
            this.uiTreeItemContext.Name = "uiTreeItemContext";
            this.uiTreeItemContext.Size = new System.Drawing.Size(169, 36);
            // 
            // uiEditServer
            // 
            this.uiEditServer.Name = "uiEditServer";
            this.uiEditServer.Size = new System.Drawing.Size(168, 32);
            this.uiEditServer.Text = "Edit Server";
            this.uiEditServer.Click += new System.EventHandler(this.uiEditServer_Click);
            // 
            // uiTreeItemTopicContext
            // 
            this.uiTreeItemTopicContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiTreeItemTopicContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiConnect});
            this.uiTreeItemTopicContext.Name = "uiTreeItemTopicContext";
            this.uiTreeItemTopicContext.Size = new System.Drawing.Size(150, 36);
            // 
            // uiConnect
            // 
            this.uiConnect.Name = "uiConnect";
            this.uiConnect.Size = new System.Drawing.Size(149, 32);
            this.uiConnect.Text = "Connect";
            this.uiConnect.Click += new System.EventHandler(this.uiConnect_Click);
            // 
            // uiChart
            // 
            this.uiChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiChart.Location = new System.Drawing.Point(209, 34);
            this.uiChart.Name = "uiChart";
            this.uiChart.Size = new System.Drawing.Size(1007, 209);
            this.uiChart.TabIndex = 4;
            this.uiChart.Text = "elementHost1";
            this.uiChart.Child = this.uiChartContent;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 535);
            this.Controls.Add(this.uiChart);
            this.Controls.Add(this.uiServers);
            this.Controls.Add(this.uiLog);
            this.Controls.Add(this.uiToolStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiToolStrip.ResumeLayout(false);
            this.uiToolStrip.PerformLayout();
            this.uiCtxMenuStrip.ResumeLayout(false);
            this.uiTreeContext.ResumeLayout(false);
            this.uiTreeItemContext.ResumeLayout(false);
            this.uiTreeItemTopicContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip uiToolStrip;
        private System.Windows.Forms.TreeView uiServers;
        private System.Windows.Forms.ContextMenuStrip uiCtxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uiClear;
        private System.Windows.Forms.ContextMenuStrip uiTreeContext;
        private System.Windows.Forms.ToolStripMenuItem uiAddServer;
        private System.Windows.Forms.ContextMenuStrip uiTreeItemContext;
        private System.Windows.Forms.ToolStripMenuItem uiEditServer;
        private System.Windows.Forms.ContextMenuStrip uiTreeItemTopicContext;
        private System.Windows.Forms.ToolStripMenuItem uiConnect;
        private System.Windows.Forms.Integration.ElementHost uiChart;
        private LiveCharts.Wpf.CartesianChart uiChartContent;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox uiLog;
        private System.Windows.Forms.ToolStripButton uiStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox uiFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox uiInterval;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox uiLogging;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox uiStoreOffset;
    }
}

