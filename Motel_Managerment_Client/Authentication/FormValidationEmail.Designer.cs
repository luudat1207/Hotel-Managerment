namespace Motel_Managerment_Client.Authentication
{
    partial class FormValidationEmail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcodeMail = new System.Windows.Forms.TextBox();
            this.buttonVerifyMail = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Motel_Managerment_Client.Properties.Resources.gmail_icon;
            this.pictureBox1.Location = new System.Drawing.Point(300, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "An email has been send to you.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check the email that\'s associated with your account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(237, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "for the verification code.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(191, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Verifycation code:";
            // 
            // textcodeMail
            // 
            this.textcodeMail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcodeMail.Location = new System.Drawing.Point(191, 322);
            this.textcodeMail.Name = "textcodeMail";
            this.textcodeMail.Size = new System.Drawing.Size(378, 38);
            this.textcodeMail.TabIndex = 7;
            // 
            // buttonVerifyMail
            // 
            this.buttonVerifyMail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonVerifyMail.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerifyMail.ForeColor = System.Drawing.Color.Purple;
            this.buttonVerifyMail.Location = new System.Drawing.Point(191, 381);
            this.buttonVerifyMail.Name = "buttonVerifyMail";
            this.buttonVerifyMail.Size = new System.Drawing.Size(378, 43);
            this.buttonVerifyMail.TabIndex = 8;
            this.buttonVerifyMail.Text = "Verify";
            this.buttonVerifyMail.UseVisualStyleBackColor = false;
            this.buttonVerifyMail.Click += new System.EventHandler(this.buttonVerifyMail_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.Purple;
            this.buttonBack.Location = new System.Drawing.Point(607, 381);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(186, 43);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormValidationEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(820, 469);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonVerifyMail);
            this.Controls.Add(this.textcodeMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormValidationEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormValidationEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textcodeMail;
        private Button buttonVerifyMail;
        private Button buttonBack;
    }
}