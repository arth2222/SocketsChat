namespace WindowsFormsChatClient
{
    partial class Form1
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonSendToServer = new System.Windows.Forms.Button();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.textBoxChatWindow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConnectIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(78, 7);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(78, 33);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // buttonSendToServer
            // 
            this.buttonSendToServer.Location = new System.Drawing.Point(15, 304);
            this.buttonSendToServer.Name = "buttonSendToServer";
            this.buttonSendToServer.Size = new System.Drawing.Size(163, 23);
            this.buttonSendToServer.TabIndex = 4;
            this.buttonSendToServer.Text = "SendToServer";
            this.buttonSendToServer.UseVisualStyleBackColor = true;
            this.buttonSendToServer.Click += new System.EventHandler(this.buttonSendToServer_Click);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(15, 278);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(163, 20);
            this.textBoxMsg.TabIndex = 5;
            // 
            // textBoxChatWindow
            // 
            this.textBoxChatWindow.Location = new System.Drawing.Point(15, 161);
            this.textBoxChatWindow.Multiline = true;
            this.textBoxChatWindow.Name = "textBoxChatWindow";
            this.textBoxChatWindow.Size = new System.Drawing.Size(163, 111);
            this.textBoxChatWindow.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Connect IP";
            // 
            // textBoxConnectIP
            // 
            this.textBoxConnectIP.Location = new System.Drawing.Point(78, 59);
            this.textBoxConnectIP.Name = "textBoxConnectIP";
            this.textBoxConnectIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnectIP.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(15, 96);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(162, 23);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxConnectIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChatWindow);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.buttonSendToServer);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonSendToServer;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.TextBox textBoxChatWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConnectIP;
        private System.Windows.Forms.Button buttonConnect;
    }
}

