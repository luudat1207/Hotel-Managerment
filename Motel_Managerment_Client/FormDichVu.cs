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
    public partial class FormDichVu : Form
    {
        DichVuManagerment dichVuManagerment = new DichVuManagerment();
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {

            dataGridViewDichVu.DataSource = await dichVuManagerment.GetAllDichVus();
        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textDichVu.Text = "";
            textGiaTien.Text = "";
            textGhiChu.Text = "";
        }
        public void KeyOpen(bool open)
        {
            dataGridViewDichVu.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textDichVu.ReadOnly = open;
            textGiaTien.ReadOnly = open;
            textGhiChu.ReadOnly = open;
        }

        private async void dataGridViewDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewDichVu.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewDichVu.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewDichVu.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["IDDV"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    
                        int dvID = Convert.ToInt32(cellvalue);

                        var dv = await dichVuManagerment.GetDichVuById(dvID);
                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = dv.MaDv.ToString();
                        textDichVu.Text = dv.TenDv.ToString();
                        textGiaTien.Text = dv.SoTien.ToString();
                        textGhiChu.Text = dv.GhiChu.ToString();

                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textDichVu.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textDichVu.Focus();
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);
            
                if (textBoxID.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textDichVu.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await dichVuManagerment.DeleteDichVuById(IDcu);
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
            if (textDichVu.Text == "")
            {
                MessageBox.Show("Tên dịch vụ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDichVu.Focus();
                return;
            }
            else if (textGiaTien.Text == "")
            {
                MessageBox.Show("Giá tiền trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textGiaTien.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {

                if (ktThem == true)
                {
                    String tendichvu = textDichVu.Text;
                    String giatien = textGiaTien.Text;
                    String ghichu = textGhiChu.Text;

                    Dichvu dv = new Dichvu() { TenDv = tendichvu, SoTien = Convert.ToDouble(giatien), GhiChu = ghichu };
                    await dichVuManagerment.AddDichVuById(dv);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Dichvu dv = context.Dichvus.Where(x => x.MaDv == IDcu).SingleOrDefault();

                    dv.TenDv = textDichVu.Text;
                    dv.SoTien = Convert.ToDouble(textGiaTien.Text);

                    dv.GhiChu = textGhiChu.Text;

                    await dichVuManagerment.UpdateDichVuById(dv);
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
                dataGridViewDichVu_CellContentClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            MIDForm mf = new MIDForm();
            mf.Show();
        }

        private void textGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
