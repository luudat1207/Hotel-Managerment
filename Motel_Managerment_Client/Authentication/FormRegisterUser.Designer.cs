namespace Motel_Managerment_Client.Authentication
{
    partial class FormRegisterUser
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
            this.textBoxEmailRG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "New User";
            // 
            // textBoxEmailRG
            // 
            this.textBoxEmailRG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailRG.Location = new System.Drawing.Point(86, 151);
            this.textBoxEmailRG.Name = "textBoxEmailRG";
            this.textBoxEmailRG.Size = new System.Drawing.Size(378, 38);
            this.textBoxEmailRG.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(86, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email (*)";
            // 
            // textBoxPasswordRG
            // 
            this.textBoxPasswordRG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPasswordRG.Location = new System.Drawing.Point(93, 265);
            this.textBoxPasswordRG.Name = "textBoxPasswordRG";
            this.textBoxPasswordRG.Size = new System.Drawing.Size(378, 38);
            this.textBoxPasswordRG.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(93, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password (*)";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Purple;
            this.buttonCreateAccount.Location = new System.Drawing.Point(178, 351);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(163, 47);
            this.buttonCreateAccount.TabIndex = 11;
            this.buttonCreateAccount.Text = "CreateAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // FormRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 523);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.textBoxPasswordRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmailRG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxEmailRG;
        private Label label2;
        private TextBox textBoxPasswordRG;
        private Label label3;
        private Button buttonCreateAccount;
    }
}