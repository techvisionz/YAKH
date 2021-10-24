
namespace YAKH
{
    partial class ServerInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiHost = new System.Windows.Forms.TextBox();
            this.uiSave = new System.Windows.Forms.Button();
            this.uiClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiGroupId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTopics = new System.Windows.Forms.ListBox();
            this.uiPort = new System.Windows.Forms.MaskedTextBox();
            this.uiAdd = new System.Windows.Forms.Button();
            this.uiDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // uiHost
            // 
            this.uiHost.Location = new System.Drawing.Point(136, 21);
            this.uiHost.Name = "uiHost";
            this.uiHost.Size = new System.Drawing.Size(316, 26);
            this.uiHost.TabIndex = 0;
            // 
            // uiSave
            // 
            this.uiSave.Location = new System.Drawing.Point(136, 319);
            this.uiSave.Name = "uiSave";
            this.uiSave.Size = new System.Drawing.Size(89, 37);
            this.uiSave.TabIndex = 7;
            this.uiSave.Text = "Save";
            this.uiSave.UseVisualStyleBackColor = true;
            this.uiSave.Click += new System.EventHandler(this.uiSave_Click);
            // 
            // uiClose
            // 
            this.uiClose.Location = new System.Drawing.Point(231, 319);
            this.uiClose.Name = "uiClose";
            this.uiClose.Size = new System.Drawing.Size(89, 37);
            this.uiClose.TabIndex = 8;
            this.uiClose.Text = "Close";
            this.uiClose.UseVisualStyleBackColor = true;
            this.uiClose.Click += new System.EventHandler(this.uiClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // uiGroupId
            // 
            this.uiGroupId.Location = new System.Drawing.Point(136, 85);
            this.uiGroupId.Name = "uiGroupId";
            this.uiGroupId.Size = new System.Drawing.Size(316, 26);
            this.uiGroupId.TabIndex = 2;
            this.uiGroupId.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group ID:";
            // 
            // uiTopic
            // 
            this.uiTopic.Location = new System.Drawing.Point(136, 117);
            this.uiTopic.Name = "uiTopic";
            this.uiTopic.Size = new System.Drawing.Size(316, 26);
            this.uiTopic.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Topic:";
            // 
            // uiTopics
            // 
            this.uiTopics.FormattingEnabled = true;
            this.uiTopics.ItemHeight = 20;
            this.uiTopics.Location = new System.Drawing.Point(136, 149);
            this.uiTopics.Name = "uiTopics";
            this.uiTopics.Size = new System.Drawing.Size(316, 164);
            this.uiTopics.TabIndex = 4;
            // 
            // uiPort
            // 
            this.uiPort.Location = new System.Drawing.Point(136, 53);
            this.uiPort.Mask = "00000";
            this.uiPort.Name = "uiPort";
            this.uiPort.Size = new System.Drawing.Size(100, 26);
            this.uiPort.TabIndex = 1;
            this.uiPort.Text = "9092";
            this.uiPort.ValidatingType = typeof(int);
            // 
            // uiAdd
            // 
            this.uiAdd.Location = new System.Drawing.Point(458, 191);
            this.uiAdd.Name = "uiAdd";
            this.uiAdd.Size = new System.Drawing.Size(89, 37);
            this.uiAdd.TabIndex = 5;
            this.uiAdd.Text = "Add";
            this.uiAdd.UseVisualStyleBackColor = true;
            this.uiAdd.Click += new System.EventHandler(this.uiAdd_Click);
            // 
            // uiDelete
            // 
            this.uiDelete.Location = new System.Drawing.Point(458, 234);
            this.uiDelete.Name = "uiDelete";
            this.uiDelete.Size = new System.Drawing.Size(89, 37);
            this.uiDelete.TabIndex = 6;
            this.uiDelete.Text = "Delete";
            this.uiDelete.UseVisualStyleBackColor = true;
            this.uiDelete.Click += new System.EventHandler(this.uiDelete_Click);
            // 
            // ServerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 380);
            this.Controls.Add(this.uiDelete);
            this.Controls.Add(this.uiAdd);
            this.Controls.Add(this.uiPort);
            this.Controls.Add(this.uiTopics);
            this.Controls.Add(this.uiTopic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiGroupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiClose);
            this.Controls.Add(this.uiSave);
            this.Controls.Add(this.uiHost);
            this.Controls.Add(this.label1);
            this.Name = "ServerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerInfo";
            this.Load += new System.EventHandler(this.ServerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiHost;
        private System.Windows.Forms.Button uiSave;
        private System.Windows.Forms.Button uiClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiGroupId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox uiTopics;
        private System.Windows.Forms.MaskedTextBox uiPort;
        private System.Windows.Forms.Button uiAdd;
        private System.Windows.Forms.Button uiDelete;
    }
}