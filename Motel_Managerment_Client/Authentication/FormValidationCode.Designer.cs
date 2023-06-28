namespace Motel_Managerment_Client
{
    partial class FormValidationCode
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textcodEmailFG = new System.Windows.Forms.TextBox();
            this.buttonGuiCode = new System.Windows.Forms.Button();
            this.buttonXacThuc = new System.Windows.Forms.Button();
            this.textBoxOptCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(49, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Forgot Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Motel_Managerment_Client.Properties.Resources.Security;
            this.pictureBox2.Location = new System.Drawing.Point(148, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(23, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email (*)";
            // 
            // textcodEmailFG
            // 
            this.textcodEmailFG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcodEmailFG.Location = new System.Drawing.Point(23, 239);
            this.textcodEmailFG.Name = "textcodEmailFG";
            this.textcodEmailFG.Size = new System.Drawing.Size(378, 38);
            this.textcodEmailFG.TabIndex = 6;
            // 
            // buttonGuiCode
            // 
            this.buttonGuiCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGuiCode.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuiCode.ForeColor = System.Drawing.Color.Purple;
            this.buttonGuiCode.Location = new System.Drawing.Point(120, 295);
            this.buttonGuiCode.Name = "buttonGuiCode";
            this.buttonGuiCode.Size = new System.Drawing.Size(145, 43);
            this.buttonGuiCode.TabIndex = 7;
            this.buttonGuiCode.Text = "Send code";
            this.buttonGuiCode.UseVisualStyleBackColor = false;
            this.buttonGuiCode.Click += new System.EventHandler(this.buttonGuiCode_Click);
            // 
            // buttonXacThuc
            // 
            this.buttonXacThuc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonXacThuc.Font = new System.Drawing.Font("Sitka Banner Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonXacThuc.ForeColor = System.Drawing.Color.Purple;
            this.buttonXacThuc.Location = new System.Drawing.Point(106, 479);
            this.buttonXacThuc.Name = "buttonXacThuc";
            this.buttonXacThuc.Size = new System.Drawing.Size(190, 45);
            this.buttonXacThuc.TabIndex = 10;
            this.buttonXacThuc.Text = "Verify code";
            this.buttonXacThuc.UseVisualStyleBackColor = false;
            this.buttonXacThuc.Click += new System.EventHandler(this.buttonXacThuc_Click);
            // 
            // textBoxOptCode
            // 
            this.textBoxOptCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOptCode.Location = new System.Drawing.Point(106, 423);
            this.textBoxOptCode.Name = "textBoxOptCode";
            this.textBoxOptCode.Size = new System.Drawing.Size(190, 38);
            this.textBoxOptCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(23, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "OPT Code";
            // 
            // FormValidationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(453, 577);
            this.Controls.Add(this.buttonXacThuc);
            this.Controls.Add(this.textBoxOptCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGuiCode);
            this.Controls.Add(this.textcodEmailFG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormValidationCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormValidationCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textcodEmailFG;
        private Button buttonGuiCode;
        private Button buttonXacThuc;
        private TextBox textBoxOptCode;
        private Label label3;
    }
}