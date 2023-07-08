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
    public partial class FormLapHopDong : Form
    {
        DataGridViewCellMouseEventArgs vtHopDong, vtTimKiem;
        public FormLapHopDong()
        {
            InitializeComponent();
        }
        HopDongManagerment dongManagerment = new HopDongManagerment();

        private void FormLapHopDong_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {

            dataGridViewHopDong.DataSource = await dongManagerment.GetAllHopDongByHopDongKetThuc(checkBoxHopDongKetThuc.Checked);

        }
        public void KeyOpen(bool open)
        {
            buttonThemHopDong.Enabled = open;
            buttonKetThucHopDong.Enabled = open;
            buttonXoaHopDong.Enabled = open;
            buttonGhi.Enabled = !open;
            buttonChon.Enabled = !open;

            textBoxChuNha.Enabled = !open;
            textBoxGiaThue.Enabled = !open;
            textBoxSoHD.Enabled = !open;
            textBoxKhach.Enabled = !open;
            textBoxPhong.Enabled = !open;
            textBoxCCCD.Enabled = !open;
            textBoxIDCN.Enabled = !open;
            dateTimePickerDuKienTra.Enabled = !open;
            dateTimePickerNgayTra.Enabled = !open;
            dateTimePickerTuNgay.Enabled = !open;
        }
        public void XoaTrang()
        {
            textBoxCCCD.Text = "";
            textBoxKhach.Text = "";
            textBoxIDCN.Text = "";
            textBoxChuNha.Text = "";
            textBoxGiaThue.Text = "";
            textBoxPhong.Text = "";

        }

        private async void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            

                if (string.IsNullOrEmpty(textBoxTimKiem.Text))
                {
                    dataGridViewHopDong.DataSource = await dongManagerment.GetAllHopDongByHopDongKetThuc(checkBoxHopDongKetThuc.Checked);
                }
                else
                {

                    dataGridViewHopDong.DataSource = await dongManagerment.GetAllHopDongByInfor(checkBoxHopDongKetThuc.Checked, textBoxTimKiem.Text);
                }

        }

        private void checkBoxHopDongKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewHopDong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewHopDong.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                KeyOpen(true);
                vtHopDong = e;
                DataGridViewRow row = dataGridViewHopDong.Rows[e.RowIndex];
                textBoxSoHD.Text = row.Cells[0].Value.ToString();
                textBoxChuNha.Text = row.Cells[1].Value.ToString();
                textBoxKhach.Text = row.Cells[2].Value.ToString();
                textBoxPhong.Text = row.Cells[3].Value.ToString();
                textBoxGiaThue.Text = row.Cells[4].Value.ToString();

                if (row.Cells[5].Value != null)
                {
                    if (row.Cells[5].Value.ToString() != "")
                    {
                        dateTimePickerTuNgay.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerTuNgay.Value = DateTime.Now;
                }
                if (row.Cells[6].Value != null)
                {
                    if (row.Cells[6].Value.ToString() != "")
                    {
                        dateTimePickerDuKienTra.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerDuKienTra.Value = DateTime.Now;
                }
                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[7].Value.ToString() != "")
                    {
                        dateTimePickerNgayTra.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    }
                }
                else
                {
                    dateTimePickerNgayTra.Value = DateTime.Now;
                }

                bool ktKetThuc = (bool)row.Cells[8].Value;
                if (ktKetThuc == true)
                {
                    labelKetthuc.Text = "Đã kết thúc ";
                    labelKetthuc.Enabled = false;
                }
                else
                {
                    labelKetthuc.Text = "Chưa kết thúc ";
                    labelKetthuc.Enabled = true;
                    dateTimePickerNgayTra.Value = DateTime.Now;
                }



            }
        }

        private async void radioButtonChuNha_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxTimThongTin.Text != "")
            {
                dataGridViewTraCuu.DataSource = await dongManagerment.GetChuNhaByHoTen(textBoxTimThongTin.Text);
            }
            else
            {
                dataGridViewTraCuu.DataSource = await dongManagerment.GetChuNha();

            }
        }
        private async void radioButtonKhachThue_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxTimThongTin.Text != "")
            {

                dataGridViewTraCuu.DataSource = await dongManagerment.GetKhachThueByHoTen(textBoxTimThongTin.Text);
            }
            else
            {
                dataGridViewTraCuu.DataSource = await dongManagerment.GetKhachThue();

            }
        }
        private async void radioButtonPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxTimThongTin.Text != "")
            {
                dataGridViewTraCuu.DataSource = await dongManagerment.GetPhongTroByMaPhong(textBoxTimThongTin.Text);
            }
            else
            {
                dataGridViewTraCuu.DataSource = await dongManagerment.GetPhongTro();
            }
        }
        private async void textBoxTimThongTin_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonChuNha.Checked == true)
            {
                if (textBoxTimThongTin.Text != "")
                {
                    dataGridViewTraCuu.DataSource = await dongManagerment.GetChuNhaByHoTen(textBoxTimThongTin.Text);
                }
                else
                {
                    dataGridViewTraCuu.DataSource = await dongManagerment.GetChuNha();

                }
            }
            if (radioButtonKhachThue.Checked == true)
            {
                if (textBoxTimThongTin.Text != "")
                {

                    dataGridViewTraCuu.DataSource = await dongManagerment.GetKhachThueByHoTen(textBoxTimThongTin.Text);
                }
                else
                {
                    dataGridViewTraCuu.DataSource = await dongManagerment.GetKhachThue();

                }
            }
            if (radioButtonPhong.Checked == true)
            {
                if (textBoxTimThongTin.Text != "")
                {
                    dataGridViewTraCuu.DataSource = await dongManagerment.GetPhongTroByMaPhong(textBoxTimThongTin.Text);
                }
                else
                {
                    dataGridViewTraCuu.DataSource = await dongManagerment.GetPhongTro();
                }
            }

        }

        private void buttonThemHopDong_Click(object sender, EventArgs e)
        {
            autogenSoHopDong();
            XoaTrang();
            dateTimePickerTuNgay.Value = DateTime.Now;
            dateTimePickerDuKienTra.Value = DateTime.Today.AddYears(1);
            dateTimePickerNgayTra.Enabled = false;
            KeyOpen(false);
        }

        private async void buttonGhi_Click(object sender, EventArgs e)
        {

            if (textBoxChuNha.Text == "")
            {
                MessageBox.Show("Chủ nhà trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTimThongTin.Focus();
                radioButtonChuNha.Checked = true;
                return;
            }
            else if (textBoxKhach.Text == "")
            {
                MessageBox.Show("Khách hàng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTimThongTin.Focus();
                radioButtonKhachThue.Checked = true;
                return;
            }
            else if (textBoxPhong.Text == "")
            {
                MessageBox.Show("Phòng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTimThongTin.Focus();
                radioButtonPhong.Checked = true;
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm hợp đồng mới không?", " Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            //DateTime hentra;
            string sohd = textBoxSoHD.Text;
            int idcn = int.Parse(textBoxIDCN.Text);
            string cccd = textBoxCCCD.Text;
            string maphong = textBoxPhong.Text;
            double giathue = double.Parse(textBoxGiaThue.Text);
            DateTime tungay = DateTime.Now;
            DateTime hentra = dateTimePickerDuKienTra.Value;
            bool kt = false;
            Hopdong hd = new Hopdong() { SoHopDong = sohd, Idcn = idcn, Cccd = cccd, MaPhong = maphong, GiaThue = giathue, TuNgay = tungay, DuKienTra = hentra, DaKetThuc = kt };
            await dongManagerment.AddHopDong(hd);
            MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KeyOpen(true);

            loadData();
        }

        private async void buttonKetThucHopDong_Click(object sender, EventArgs e)
        {
            if (textBoxSoHD.Text == "") return;
            if (MessageBox.Show("Bạn có muốn kết thúc hợp đồng không?", " Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            await dongManagerment.KetThucHopDongById(textBoxSoHD.Text);
            MessageBox.Show("Đã kết thúc hợp đồng thành công ", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private async void buttonXoaHopDong_Click(object sender, EventArgs e)
        {
            if (textBoxSoHD.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa hợp đồng không?", " Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            await dongManagerment.DeleteHopDongById(textBoxSoHD.Text);
            MessageBox.Show("Đã xóa thành công ", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            XoaTrang();
            KeyOpen(true);
        }

        public void autogenSoHopDong()
        {
            long num = 1;
            using (var context = new DBNhaTroContext())
            {
                Hopdong hd = context.Hopdongs.OrderByDescending(x => x.SoHopDong).FirstOrDefault();
                if (hd != null)
                {
                    num = long.Parse(hd.SoHopDong.ToString()) + 1;
                }

                textBoxSoHD.Text = num.ToString("0000000000");//0000000000
            }
        }

        private void dataGridViewTraCuu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewTraCuu.Rows.Count <= 0) return;
            if (e.RowIndex >= 0)
            {
                KeyOpen(false);
                vtTimKiem = e;

            }
        }

        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            MIDForm mf = new MIDForm();
            mf.Show();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            if (buttonGhi.Enabled == false) return;
            try
            {
                DataGridViewRow row = dataGridViewTraCuu.Rows[vtTimKiem.RowIndex];
                if (radioButtonChuNha.Checked == true)
                {
                    textBoxChuNha.Text = row.Cells[1].Value.ToString();
                    textBoxIDCN.Text = row.Cells[0].Value.ToString();
                }
                if (radioButtonKhachThue.Checked == true)
                {
                    textBoxKhach.Text = row.Cells[1].Value.ToString();
                    textBoxCCCD.Text = row.Cells[0].Value.ToString();
                }
                if (radioButtonPhong.Checked == true)
                {
                    textBoxPhong.Text = row.Cells[0].Value.ToString();
                    textBoxGiaThue.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex) { }
        }


    }
}

