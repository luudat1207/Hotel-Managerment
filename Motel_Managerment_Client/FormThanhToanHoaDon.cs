using Motel_Managerment_API.Models;
using Motel_Managerment_Client.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel_Managerment_Client
{
    public partial class FormThanhToanHoaDon : Form
    {
        ThanhToanManagerment thanhToanManagerment = new ThanhToanManagerment();
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormThanhToanHoaDon()
        {
            InitializeComponent();
        }

        private void FormThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {
            dataGridViewThanhToan.DataSource = await thanhToanManagerment.GetAllThanhToans();

        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textTinhTrang.Text = "";

        }
        public void KeyOpen(bool open)
        {
            dataGridViewThanhToan.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textTinhTrang.ReadOnly = open;


        }

        private async void dataGridViewThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewThanhToan.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewThanhToan.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewThanhToan.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["ID"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    using (var context = new DBNhaTroContext())
                    {
                        int ttID = Convert.ToInt32(cellvalue);

                        var tt = await thanhToanManagerment.GetThanhToanById(ttID);

                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = tt.Idtt.ToString();
                        textTinhTrang.Text = tt.LoaiThanhToan.ToString();

                    }
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textTinhTrang.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textTinhTrang.Focus();
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);
            
                if (textBoxID.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textTinhTrang.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await thanhToanManagerment.DeleteThanhToanById(IDcu);
                    MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    textBoxID.Text = "";
                    KeyOpen(true);

                }
           
            loadData();
        }

        private async void buttonGhi_Click(object sender, EventArgs e)
        {
            if (textTinhTrang.Text == "")
            {
                MessageBox.Show("Tình trạng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTinhTrang.Focus();
                return;
            }


            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String tinhtrang = textTinhTrang.Text;
                    Thanhtoan tt = new Thanhtoan() { LoaiThanhToan = tinhtrang };
                    await thanhToanManagerment.AddThanhToanById(tt);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Thanhtoan tt = context.Thanhtoans.Where(x => x.Idtt == IDcu).SingleOrDefault();

                    tt.LoaiThanhToan = textTinhTrang.Text;

                    await thanhToanManagerment.UpdateThanhToanById(tt);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                context.SaveChanges();
                KeyOpen(true);
            }
            loadData();
        }

        private void buttonKhongGhi_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KeyOpen(true);
                dataGridViewThanhToan_CellContentClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            MIDForm mf = new MIDForm();
            mf.Show();
        }

    }
}
