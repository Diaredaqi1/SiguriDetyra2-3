namespace TcpSocket
{
    partial class ServerForm
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
            this.BtnStartServer = new System.Windows.Forms.Button();
            this.BtnStopServer = new System.Windows.Forms.Button();
            this.ListServerInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.LabelHost = new System.Windows.Forms.Label();
            this.TextBoxHost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStartServer
            // 
            this.BtnStartServer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartServer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnStartServer.Location = new System.Drawing.Point(20, 78);
            this.BtnStartServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStartServer.Name = "BtnStartServer";
            this.BtnStartServer.Size = new System.Drawing.Size(252, 100);
            this.BtnStartServer.TabIndex = 0;
            this.BtnStartServer.Text = "Start Server";
            this.BtnStartServer.UseVisualStyleBackColor = false;
            this.BtnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // BtnStopServer
            // 
            this.BtnStopServer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnStopServer.Enabled = false;
            this.BtnStopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStopServer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnStopServer.Location = new System.Drawing.Point(280, 78);
            this.BtnStopServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStopServer.Name = "BtnStopServer";
            this.BtnStopServer.Size = new System.Drawing.Size(256, 100);
            this.BtnStopServer.TabIndex = 1;
            this.BtnStopServer.Text = "Stop Server";
            this.BtnStopServer.UseVisualStyleBackColor = false;
            this.BtnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // ListServerInformations
            // 
            this.ListServerInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListServerInformations.FormattingEnabled = true;
            this.ListServerInformations.ItemHeight = 22;
            this.ListServerInformations.Location = new System.Drawing.Point(20, 188);
            this.ListServerInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListServerInformations.Name = "ListServerInformations";
            this.ListServerInformations.Size = new System.Drawing.Size(516, 224);
            this.ListServerInformations.TabIndex = 2;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPort.Location = new System.Drawing.Point(276, 14);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(47, 20);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(280, 38);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(254, 26);
            this.TextBoxPort.TabIndex = 6;
            this.TextBoxPort.Text = "3000";
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHost.Location = new System.Drawing.Point(15, 14);
            this.LabelHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(52, 20);
            this.LabelHost.TabIndex = 7;
            this.LabelHost.Text = "Host:";
            // 
            // TextBoxHost
            // 
            this.TextBoxHost.Location = new System.Drawing.Point(20, 38);
            this.TextBoxHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHost.Name = "TextBoxHost";
            this.TextBoxHost.Size = new System.Drawing.Size(250, 26);
            this.TextBoxHost.TabIndex = 8;
            this.TextBoxHost.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(371, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 73);
            this.button1.TabIndex = 9;
            this.button1.Text = "Certificate\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxHost);
            this.Controls.Add(this.LabelHost);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.ListServerInformations);
            this.Controls.Add(this.BtnStopServer);
            this.Controls.Add(this.BtnStartServer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartServer;
        private System.Windows.Forms.Button BtnStopServer;
        private System.Windows.Forms.ListBox ListServerInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.TextBox TextBoxHost;
        private System.Windows.Forms.Button button1;
    }
}

