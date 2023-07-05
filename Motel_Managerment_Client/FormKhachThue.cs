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
    public partial class FormKhachThue : Form
    {
        public FormKhachThue()
        {
            InitializeComponent();
        }

        bool ktThem;
        string CCCDcu;
        DataGridViewCellMouseEventArgs vt;
        KhachThueManagerment thueManagerment = new KhachThueManagerment();
        List<Khachthue> khachthues = new List<Khachthue>();
        private void FormKhachThue_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {
            dataGridViewKhachThue.DataSource = await thueManagerment.GetAllKhachThue();
        }

        private async void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTimKiem.Text))
            {
                dataGridViewKhachThue.DataSource  = await thueManagerment.GetAllKhachThue();
            }
            else
            {
                    dataGridViewKhachThue.DataSource  = await thueManagerment.GetAllKhachThueByInfor(textBoxTimKiem.Text);
            }
        }

        public void XoaTrang()
        {
            textBoxCCCD.Text = "";
            textBoxHoTen.Text = "";
            textBoxSoDT.Text = "";
            textBoxQueQuan.Text = "";
            textBoxDiaChi.Text = "";
            textBoxThongTinKhac.Text = "";
            textBoxGhiChu.Text = "";

        }
        public void KeyOpen(bool open)
        {
            dataGridViewKhachThue.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;

            textBoxTimKiem.ReadOnly = !open;
            textBoxCCCD.ReadOnly = open;
            textBoxHoTen.ReadOnly = open;
            textBoxSoDT.ReadOnly = open;
            textBoxQueQuan.ReadOnly = open;
            textBoxDiaChi.ReadOnly = open;
            textBoxThongTinKhac.ReadOnly = open;
            textBoxGhiChu.ReadOnly = open;

        }

        private void dataGridViewKhachThue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewKhachThue.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewKhachThue.Rows[e.RowIndex];
                textBoxCCCD.Text = row.Cells[0].Value.ToString();
                textBoxHoTen.Text = row.Cells[1].Value.ToString();
                textBoxSoDT.Text = row.Cells[2].Value.ToString();
                textBoxDiaChi.Text = row.Cells[4].Value.ToString();
                textBoxGhiChu.Text = row.Cells[6].Value.ToString();
                textBoxQueQuan.Text = row.Cells[3].Value.ToString();
                textBoxThongTinKhac.Text = row.Cells[5].Value.ToString();
            }
        }



        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textBoxHoTen.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxCCCD.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            CCCDcu = textBoxCCCD.Text;
            textBoxHoTen.Focus();
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            CCCDcu = textBoxCCCD.Text;

            using (var context = new DBNhaTroContext())
            {
                if (textBoxCCCD.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textBoxHoTen.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await thueManagerment.DeleteKhachThueById(long.Parse(CCCDcu));
                    MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    KeyOpen(true);
                }
            }
            loadData();
        }

        private async void buttonGhi_Click(object sender, EventArgs e)
        {
            if (textBoxCCCD.Text == "")
            {
                MessageBox.Show("CCCD trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCCCD.Focus();
                return;
            }
            else if (textBoxHoTen.Text == "")
            {
                MessageBox.Show("Họ tên trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHoTen.Focus();
                return;
            }
            else if (textBoxSoDT.Text == "")
            {
                MessageBox.Show("Số điện thoại trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSoDT.Focus();
                return;
            }
            else if (duplicateCCCD() == true)
            {
                MessageBox.Show("Trùng CCCD !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCCCD.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String cccd = textBoxCCCD.Text;
                    String hoten = textBoxHoTen.Text;
                    String sdt = textBoxSoDT.Text;
                    String quequan = textBoxQueQuan.Text;
                    String diachi = textBoxDiaChi.Text;
                    String thongtinkhac = textBoxThongTinKhac.Text;
                    String ghichu = textBoxGhiChu.Text;

                    Khachthue kt = new Khachthue() { Cccd = cccd, HoTen = hoten, Sdt = sdt, QueQuan = quequan, DiaChi = diachi, GhiChu = ghichu, ThongTinKhac = thongtinkhac };
                    await thueManagerment.AddKhachThue(kt);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Khachthue kt = context.Khachthues.Where(x => x.Cccd.Equals(CCCDcu)).SingleOrDefault();
                    kt.Cccd = textBoxCCCD.Text;
                    kt.HoTen = textBoxHoTen.Text;
                    kt.Sdt = textBoxSoDT.Text;
                    kt.QueQuan = textBoxQueQuan.Text;
                    kt.DiaChi = textBoxDiaChi.Text;
                    kt.GhiChu = textBoxGhiChu.Text;
                    kt.ThongTinKhac = textBoxThongTinKhac.Text;
                    await thueManagerment.UpdateKhachThue(kt);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                context.SaveChanges();
                KeyOpen(true);
            }
            loadData();
        }

        public bool duplicateCCCD()
        {
            using (var context = new DBNhaTroContext())
            {
                var check = context.Khachthues.Where(x => x.Cccd.Equals(textBoxCCCD.Text)).ToList();
                if (check.Count > 0)
                {
                    if (ktThem == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (check[0].Cccd.Equals(CCCDcu) == false)
                            return true;
                    }
                }
                return false;
            }
        }
        private void buttonKhongGhi_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KeyOpen(true);
                dataGridViewKhachThue_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSoDT_KeyPress(object sender, KeyPressEventArgs e)
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
