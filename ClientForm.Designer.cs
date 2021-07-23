namespace TcpSocket
{
    partial class ClientForm
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.LabelHostName = new System.Windows.Forms.Label();
            this.TextBoxHostName = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ListBoxClientInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(18, 143);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(60, 20);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Location = new System.Drawing.Point(22, 168);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(512, 26);
            this.TextBoxName.TabIndex = 1;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(18, 203);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(86, 20);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "Message:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Enabled = false;
            this.TextBoxMessage.Location = new System.Drawing.Point(22, 228);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(512, 98);
            this.TextBoxMessage.TabIndex = 3;
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnSendMessage.Enabled = false;
            this.BtnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendMessage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSendMessage.Location = new System.Drawing.Point(22, 333);
            this.BtnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(514, 39);
            this.BtnSendMessage.TabIndex = 4;
            this.BtnSendMessage.Text = "Send Message";
            this.BtnSendMessage.UseVisualStyleBackColor = false;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // LabelHostName
            // 
            this.LabelHostName.AutoSize = true;
            this.LabelHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHostName.Location = new System.Drawing.Point(18, 22);
            this.LabelHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHostName.Name = "LabelHostName";
            this.LabelHostName.Size = new System.Drawing.Size(103, 20);
            this.LabelHostName.TabIndex = 5;
            this.LabelHostName.Text = "Host Name:";
            // 
            // TextBoxHostName
            // 
            this.TextBoxHostName.Location = new System.Drawing.Point(22, 46);
            this.TextBoxHostName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHostName.Name = "TextBoxHostName";
            this.TextBoxHostName.Size = new System.Drawing.Size(248, 26);
            this.TextBoxHostName.TabIndex = 6;
            this.TextBoxHostName.Text = "127.0.0.1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnConnect.Location = new System.Drawing.Point(22, 86);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(250, 52);
            this.BtnConnect.TabIndex = 7;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ListBoxClientInformations
            // 
            this.ListBoxClientInformations.FormattingEnabled = true;
            this.ListBoxClientInformations.ItemHeight = 20;
            this.ListBoxClientInformations.Location = new System.Drawing.Point(22, 382);
            this.ListBoxClientInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxClientInformations.Name = "ListBoxClientInformations";
            this.ListBoxClientInformations.Size = new System.Drawing.Size(512, 124);
            this.ListBoxClientInformations.TabIndex = 8;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPort.Location = new System.Drawing.Point(278, 22);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(47, 20);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "Port:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(282, 46);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(253, 26);
            this.TextBoxPort.TabIndex = 10;
            this.TextBoxPort.Text = "3000";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisconnect.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnDisconnect.Location = new System.Drawing.Point(282, 86);
            this.BtnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(255, 52);
            this.BtnDisconnect.TabIndex = 11;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(23, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(280, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(559, 579);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.ListBoxClientInformations);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TextBoxHostName);
            this.Controls.Add(this.LabelHostName);
            this.Controls.Add(this.BtnSendMessage);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Button BtnSendMessage;
        private System.Windows.Forms.Label LabelHostName;
        private System.Windows.Forms.TextBox TextBoxHostName;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox ListBoxClientInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}