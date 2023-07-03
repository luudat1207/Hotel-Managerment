namespace Motel_Managerment_Client
{
    partial class FormTinhTrangPhongTro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonKhongGhi = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textTinhTrang = new System.Windows.Forms.TextBox();
            this.dataGridViewTinhTrang = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(33, 612);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(75, 44);
            this.textBoxID.TabIndex = 45;
            this.textBoxID.Visible = false;
            // 
            // buttonKetThuc
            // 
            this.buttonKetThuc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKetThuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKetThuc.Location = new System.Drawing.Point(1148, 644);
            this.buttonKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKetThuc.Name = "buttonKetThuc";
            this.buttonKetThuc.Size = new System.Drawing.Size(172, 59);
            this.buttonKetThuc.TabIndex = 44;
            this.buttonKetThuc.Text = "Kết thúc";
            this.buttonKetThuc.UseVisualStyleBackColor = true;
            this.buttonKetThuc.Click += new System.EventHandler(this.buttonKetThuc_Click);
            // 
            // buttonKhongGhi
            // 
            this.buttonKhongGhi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKhongGhi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonKhongGhi.Location = new System.Drawing.Point(955, 644);
            this.buttonKhongGhi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKhongGhi.Name = "buttonKhongGhi";
            this.buttonKhongGhi.Size = new System.Drawing.Size(170, 59);
            this.buttonKhongGhi.TabIndex = 43;
            this.buttonKhongGhi.Text = "Không ghi";
            this.buttonKhongGhi.UseVisualStyleBackColor = true;
            this.buttonKhongGhi.Click += new System.EventHandler(this.buttonKhongGhi_Click);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGhi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGhi.Location = new System.Drawing.Point(762, 644);
            this.buttonGhi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.Size = new System.Drawing.Size(171, 59);
            this.buttonGhi.TabIndex = 42;
            this.buttonGhi.Text = "Ghi";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonXoa.Location = new System.Drawing.Point(533, 644);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(170, 59);
            this.buttonXoa.TabIndex = 41;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCapNhat.Location = new System.Drawing.Point(317, 644);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(194, 59);
            this.buttonCapNhat.TabIndex = 40;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonThem.Location = new System.Drawing.Point(125, 644);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(164, 59);
            this.buttonThem.TabIndex = 39;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(50, 547);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tình trạng :";
            // 
            // textTinhTrang
            // 
            this.textTinhTrang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTinhTrang.Location = new System.Drawing.Point(293, 547);
            this.textTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.textTinhTrang.Name = "textTinhTrang";
            this.textTinhTrang.Size = new System.Drawing.Size(1016, 42);
            this.textTinhTrang.TabIndex = 37;
            // 
            // dataGridViewTinhTrang
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTinhTrang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTinhTrang.ColumnHeadersHeight = 29;
            this.dataGridViewTinhTrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2});
            this.dataGridViewTinhTrang.Location = new System.Drawing.Point(378, 97);
            this.dataGridViewTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTinhTrang.Name = "dataGridViewTinhTrang";
            this.dataGridViewTinhTrang.RowHeadersWidth = 51;
            this.dataGridViewTinhTrang.RowTemplate.Height = 40;
            this.dataGridViewTinhTrang.Size = new System.Drawing.Size(653, 414);
            this.dataGridViewTinhTrang.TabIndex = 36;
            this.dataGridViewTinhTrang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTinhTrang_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaTinhTrang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TinhTrang1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Tình Trạng Phòng Trọ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 550;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(362, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "QUẢN LÝ TÌNH TRẠNG PHÒNG TRỌ ";
            // 
            // FormTinhTrangPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 721);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonKetThuc);
            this.Controls.Add(this.buttonKhongGhi);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTinhTrang);
            this.Controls.Add(this.dataGridViewTinhTrang);
            this.Controls.Add(this.label1);
            this.Name = "FormTinhTrangPhongTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTinhTrangPhongTro";
            this.Load += new System.EventHandler(this.FormTinhTrangPhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhTrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxID;
        private Button buttonKetThuc;
        private Button buttonKhongGhi;
        private Button buttonGhi;
        private Button buttonXoa;
        private Button buttonCapNhat;
        private Button buttonThem;
        private Label label2;
        private TextBox textTinhTrang;
        private DataGridView dataGridViewTinhTrang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
    }
}