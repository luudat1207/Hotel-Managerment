namespace Motel_Managerment_Client
{
    partial class FormResetPassword
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
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.buttonChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Motel_Managerment_Client.Properties.Resources.resetpassword;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(158, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reset Password";
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass1.ForeColor = System.Drawing.Color.Purple;
            this.textBoxPass1.Location = new System.Drawing.Point(101, 310);
            this.textBoxPass1.Multiline = true;
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(374, 43);
            this.textBoxPass1.TabIndex = 21;
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass2.ForeColor = System.Drawing.Color.Purple;
            this.textBoxPass2.Location = new System.Drawing.Point(101, 370);
            this.textBoxPass2.Multiline = true;
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(374, 42);
            this.textBoxPass2.TabIndex = 22;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.Color.Purple;
            this.buttonChangePass.FlatAppearance.BorderSize = 0;
            this.buttonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePass.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChangePass.ForeColor = System.Drawing.Color.White;
            this.buttonChangePass.Location = new System.Drawing.Point(158, 445);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(294, 61);
            this.buttonChangePass.TabIndex = 23;
            this.buttonChangePass.Text = "Ok";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(601, 674);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxPass1;
        private TextBox textBoxPass2;
        private Button buttonChangePass;
    }
}