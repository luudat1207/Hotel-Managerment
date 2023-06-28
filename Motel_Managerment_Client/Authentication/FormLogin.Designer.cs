namespace Motel_Managerment_Client
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Motel_Managerment_Client.Properties.Resources.Security;
            this.pictureBox2.Location = new System.Drawing.Point(729, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(703, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Motel_Managerment_Client.Properties.Resources.panelLogin1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Purple;
            this.textBoxUsername.Location = new System.Drawing.Point(685, 222);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(259, 35);
            this.textBoxUsername.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(670, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(649, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(649, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 1);
            this.panel3.TabIndex = 16;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Purple;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(638, 412);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(294, 61);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(808, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Clear Fields";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Motel_Managerment_Client.Properties.Resources.User;
            this.pictureBox3.Location = new System.Drawing.Point(620, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(620, 287);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkRegister.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkRegister.LinkColor = System.Drawing.Color.Purple;
            this.linkRegister.Location = new System.Drawing.Point(703, 486);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(147, 25);
            this.linkRegister.TabIndex = 24;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Resgistred Here";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(607, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "New User?";
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkForgotPassword.LinkColor = System.Drawing.Color.Purple;
            this.linkForgotPassword.Location = new System.Drawing.Point(620, 372);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(176, 28);
            this.linkForgotPassword.TabIndex = 26;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot password!";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Purple;
            this.textBoxPassword.Location = new System.Drawing.Point(685, 317);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(259, 35);
            this.textBoxPassword.TabIndex = 27;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(998, 564);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBoxUsername;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonLogin;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel linkRegister;
        private Label label3;
        private LinkLabel linkForgotPassword;
        private TextBox textBoxPassword;
    }
}