
namespace TcpSocket
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.emri1 = new System.Windows.Forms.TextBox();
            this.mbiemri1 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.tregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(121, 54);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(164, 26);
            this.id1.TabIndex = 4;
            // 
            // emri1
            // 
            this.emri1.Location = new System.Drawing.Point(121, 90);
            this.emri1.Name = "emri1";
            this.emri1.Size = new System.Drawing.Size(164, 26);
            this.emri1.TabIndex = 5;
            // 
            // mbiemri1
            // 
            this.mbiemri1.Location = new System.Drawing.Point(121, 128);
            this.mbiemri1.Name = "mbiemri1";
            this.mbiemri1.Size = new System.Drawing.Size(164, 26);
            this.mbiemri1.TabIndex = 6;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(121, 169);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(164, 26);
            this.pass1.TabIndex = 7;
            // 
            // tregister
            // 
            this.tregister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tregister.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tregister.Location = new System.Drawing.Point(79, 225);
            this.tregister.Name = "tregister";
            this.tregister.Size = new System.Drawing.Size(147, 45);
            this.tregister.TabIndex = 8;
            this.tregister.Text = "Register";
            this.tregister.UseVisualStyleBackColor = false;
            this.tregister.Click += new System.EventHandler(this.tregister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(303, 282);
            this.Controls.Add(this.tregister);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.mbiemri1);
            this.Controls.Add(this.emri1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.TextBox emri1;
        private System.Windows.Forms.TextBox mbiemri1;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Button tregister;
    }
}