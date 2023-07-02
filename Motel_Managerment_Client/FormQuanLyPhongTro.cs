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
    public partial class FormQuanLyPhongTro : Form
    {
        public FormQuanLyPhongTro()
        {
            InitializeComponent();
        }
        PhongTroManagerment phongTroManagerment = new PhongTroManagerment();
        TinhTrangManagerment tinhTrangManagerment = new TinhTrangManagerment();

        bool ktThem;
        string MaPhongcu;
        DataGridViewCellMouseEventArgs vt;

        List<Phongtro> phongtros = new List<Phongtro>();
        private void FormQuanLyPhongTro_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {
            dataGridViewPhongTro.DataSource = await phongTroManagerment.GetAllPhongTro();

            comboBoxTinhTrang.ValueMember = "MaTinhTrang";
            comboBoxTinhTrang.DisplayMember = "TinhTrang1";
            comboBoxTinhTrang.DataSource = await tinhTrangManagerment.GetAllTinhtrang();

        }
        private async void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTimKiem.Text))
            {
                dataGridViewPhongTro.DataSource = await phongTroManagerment.GetAllPhongTro();
            }
            else
            {

                dataGridViewPhongTro.DataSource = await phongTroManagerment.GetAllPhongTroByInfor(textBoxTimKiem.Text);
            }
        }

        public void XoaTrang()
        {
            textBoxMaPhong.Text = "";
            textBoxGiaPhong.Text = "";
            textBoxGhiChu.Text = "";
            textBoxThongTin.Text = "";


        }
        public void KeyOpen(bool open)
        {
            dataGridViewPhongTro.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;

            textBoxTimKiem.ReadOnly = !open;
            textBoxMaPhong.ReadOnly = open;
            textBoxGiaPhong.ReadOnly = open;
            textBoxGhiChu.ReadOnly = open;
            textBoxThongTin.ReadOnly = open;
            comboBoxTinhTrang.Enabled = !open;

        }

        private void dataGridViewPhongTro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewPhongTro.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dataGridViewPhongTro.Rows[e.RowIndex];
                textBoxMaPhong.Text = row.Cells[0].Value.ToString();
                textBoxGiaPhong.Text = row.Cells[1].Value.ToString();
                textBoxThongTin.Text = row.Cells[2].Value.ToString();
                comboBoxTinhTrang.SelectedValue = Int32.Parse(row.Cells[4].Value.ToString());
                textBoxGhiChu.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textBoxMaPhong.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxMaPhong.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            MaPhongcu = textBoxMaPhong.Text;
            textBoxMaPhong.Focus();
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            MaPhongcu = textBoxMaPhong.Text;
            
                if (textBoxMaPhong.Text == "") return;
                if (MessageBox.Show("Bạn có muốn xóa [" + textBoxMaPhong.Text + "] không ?", "Thông báo ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await phongTroManagerment.DeletePhongTroById(int.Parse(MaPhongcu));
                    MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    KeyOpen(true);
                }
           
            loadData();
        }

        private async void buttonGhi_Click(object sender, EventArgs e)
        {
            if (textBoxMaPhong.Text == "")
            {
                MessageBox.Show("Mã Phòng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaPhong.Focus();
                return;
            }
            else if (textBoxGiaPhong.Text == "")
            {
                MessageBox.Show("Giá phòng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxGiaPhong.Focus();
                return;
            }

            else if (duplicateMaPhong() == true)
            {
                MessageBox.Show("Trùng Mã Phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaPhong.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {


                if (ktThem == true)
                {
                    String maphong = textBoxMaPhong.Text;
                    double giaphong = double.Parse(textBoxGiaPhong.Text);
                    int tinhtrang = int.Parse(comboBoxTinhTrang.SelectedValue.ToString());
                    String thongtin = textBoxThongTin.Text;
                    String ghichu = textBoxGhiChu.Text;


                    Phongtro pt = new Phongtro() { MaPhong = maphong, GiaPhong = giaphong, MaTinhTrang = tinhtrang, ThongTin = thongtin, GhiChu = ghichu };
                    await phongTroManagerment.AddPhongTro(pt);

                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Phongtro pt = context.Phongtros.Where(x => x.MaPhong.Equals(MaPhongcu)).SingleOrDefault();
                    pt.MaPhong = textBoxMaPhong.Text;
                    pt.GiaPhong = double.Parse(textBoxGiaPhong.Text);
                    pt.MaTinhTrang = int.Parse(comboBoxTinhTrang.SelectedValue.ToString());
                    pt.ThongTin = textBoxThongTin.Text;
                    pt.GhiChu = textBoxGhiChu.Text;
                    await phongTroManagerment.UpdatePhongTro(pt);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                KeyOpen(true);
            }
            loadData();
        }
        public bool duplicateMaPhong()
        {
            using (var context = new DBNhaTroContext())
            {
                var check = context.Phongtros.Where(x => x.MaPhong.Equals(textBoxMaPhong.Text)).ToList();

                if (check.Count > 0)
                {
                    if (ktThem == true)
                    {
                        return true;
                    }
                    else
                    {
                        if (check[0].MaPhong.Equals(MaPhongcu) == false)
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
                dataGridViewPhongTro_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            MIDForm mf = new MIDForm();
            mf.Show();

        }

        private void textBoxGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
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
