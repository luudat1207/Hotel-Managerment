namespace Motel_Managerment_Client
{
    partial class FormDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.IDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonKhongGhi = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textGiaTien = new System.Windows.Forms.TextBox();
            this.textGhiChu = new System.Windows.Forms.TextBox();
            this.textDichVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(31, 681);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(67, 44);
            this.textBoxID.TabIndex = 50;
            this.textBoxID.Visible = false;
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.ColumnHeadersHeight = 29;
            this.dataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDV,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDichVu.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(137, 81);
            this.dataGridViewDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.RowHeadersWidth = 51;
            this.dataGridViewDichVu.RowTemplate.Height = 29;
            this.dataGridViewDichVu.Size = new System.Drawing.Size(1110, 436);
            this.dataGridViewDichVu.TabIndex = 49;
            this.dataGridViewDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDichVu_CellContentClick);
            // 
            // IDDV
            // 
            this.IDDV.DataPropertyName = "MaDV";
            this.IDDV.HeaderText = "ID";
            this.IDDV.MinimumWidth = 6;
            this.IDDV.Name = "IDDV";
            this.IDDV.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenDV";
            this.Column3.HeaderText = "Tên Dịch Vụ ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 400;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoTien";
            this.Column4.HeaderText = "Giá Tiền (VND)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GhiChu";
            this.Column5.HeaderText = "Ghi Chú ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 400;
            // 
            // buttonKetThuc
            // 
            this.buttonKetThuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKetThuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKetThuc.Location = new System.Drawing.Point(1176, 674);
            this.buttonKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKetThuc.Name = "buttonKetThuc";
            this.buttonKetThuc.Size = new System.Drawing.Size(153, 62);
            this.buttonKetThuc.TabIndex = 48;
            this.buttonKetThuc.Text = "Kết thúc";
            this.buttonKetThuc.UseVisualStyleBackColor = true;
            this.buttonKetThuc.Click += new System.EventHandler(this.buttonKetThuc_Click);
            // 
            // buttonKhongGhi
            // 
            this.buttonKhongGhi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKhongGhi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKhongGhi.Location = new System.Drawing.Point(988, 674);
            this.buttonKhongGhi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKhongGhi.Name = "buttonKhongGhi";
            this.buttonKhongGhi.Size = new System.Drawing.Size(151, 62);
            this.buttonKhongGhi.TabIndex = 47;
            this.buttonKhongGhi.Text = "Không ghi";
            this.buttonKhongGhi.UseVisualStyleBackColor = true;
            this.buttonKhongGhi.Click += new System.EventHandler(this.buttonKhongGhi_Click);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGhi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGhi.Location = new System.Drawing.Point(785, 674);
            this.buttonGhi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.Size = new System.Drawing.Size(152, 62);
            this.buttonGhi.TabIndex = 46;
            this.buttonGhi.Text = "Ghi";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonXoa.Location = new System.Drawing.Point(525, 674);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(151, 62);
            this.buttonXoa.TabIndex = 45;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCapNhat.Location = new System.Drawing.Point(308, 674);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(172, 62);
            this.buttonCapNhat.TabIndex = 44;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonThem.Location = new System.Drawing.Point(121, 674);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(146, 62);
            this.buttonThem.TabIndex = 43;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(59, 552);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "Dịch vụ :";
            // 
            // textGiaTien
            // 
            this.textGiaTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textGiaTien.Location = new System.Drawing.Point(941, 549);
            this.textGiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.textGiaTien.Name = "textGiaTien";
            this.textGiaTien.Size = new System.Drawing.Size(356, 42);
            this.textGiaTien.TabIndex = 41;
            this.textGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textGiaTien_KeyPress);
            // 
            // textGhiChu
            // 
            this.textGhiChu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textGhiChu.Location = new System.Drawing.Point(219, 613);
            this.textGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.textGhiChu.MaxLength = 999;
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(1078, 42);
            this.textGhiChu.TabIndex = 40;
            // 
            // textDichVu
            // 
            this.textDichVu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDichVu.Location = new System.Drawing.Point(219, 549);
            this.textDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.textDichVu.Name = "textDichVu";
            this.textDichVu.Size = new System.Drawing.Size(428, 42);
            this.textDichVu.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(662, 552);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 36);
            this.label4.TabIndex = 37;
            this.label4.Text = "Giá tiền (VND)  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(59, 619);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 36);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ghi chú :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(508, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 748);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridViewDichVu);
            this.Controls.Add(this.buttonKetThuc);
            this.Controls.Add(this.buttonKhongGhi);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textGiaTien);
            this.Controls.Add(this.textGhiChu);
            this.Controls.Add(this.textDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDichVu";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxID;
        private DataGridView dataGridViewDichVu;
        private DataGridViewTextBoxColumn IDDV;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button buttonKetThuc;
        private Button buttonKhongGhi;
        private Button buttonGhi;
        private Button buttonXoa;
        private Button buttonCapNhat;
        private Button buttonThem;
        private Label label2;
        private TextBox textGiaTien;
        private TextBox textGhiChu;
        private TextBox textDichVu;
        private Label label4;
        private Label label5;
        private Label label1;
    }
}