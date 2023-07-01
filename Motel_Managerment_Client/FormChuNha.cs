using Motel_Managerment_API.DTO;
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
    public partial class FormChuNha : Form
    {
        ChuNhaManagerment chuNhaManagerment = new ChuNhaManagerment();
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        public FormChuNha()
        {
            InitializeComponent();
        }

        private void FormChuNha_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }



        public async void loadData()
        {
            var lstCN = await chuNhaManagerment.GetAllChuNha();
            dataGridViewChuNha.DataSource = lstCN;
        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textHoTen.Text = "";
            textSoDT.Text = "";
            textDiaChi.Text = "";
            textGhiChu.Text = "";
        }
        public void KeyOpen(bool open)
        {
            dataGridViewChuNha.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textHoTen.ReadOnly = open;
            textSoDT.ReadOnly = open;
            textDiaChi.ReadOnly = open;
            textGhiChu.ReadOnly = open;

        }

        private async void dataGridViewChuNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewChuNha.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewChuNha.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewChuNha.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["ID"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;

                    int cnID = Convert.ToInt32(cellvalue);

                    var cn = await chuNhaManagerment.GetChuNhaById(cnID);
                    // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                    textBoxID.Text = cn.Idcn.ToString();
                    textHoTen.Text = cn.HoTen.ToString();
                    textSoDT.Text = cn.Sdt.ToString();
                    textDiaChi.Text = cn.DiaChi.ToString();
                    textGhiChu.Text = cn.GhiChu.ToString();

                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KeyOpen(false);
            textHoTen.Focus();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") return;
            ktThem = false;
            KeyOpen(false);
            int.TryParse(textBoxID.Text, out IDcu);
            textHoTen.Focus();

        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxID.Text, out IDcu);

            if (textBoxID.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa [" + textHoTen.Text + "] không ?", "Thông báo ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 await chuNhaManagerment.DeleteChuNhaById(IDcu);
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
            if (textHoTen.Text == "")
            {
                MessageBox.Show("Họ tên trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textHoTen.Focus();
                return;
            }
            else if (textSoDT.Text == "")
            {
                MessageBox.Show("Số điện thoại trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSoDT.Focus();
                return;
            }

            using (var context = new DBNhaTroContext())
            {

                if (ktThem == true)
                {
                    String hoten = textHoTen.Text;
                    String sdt = textSoDT.Text;
                    String diachi = textDiaChi.Text;
                    String ghichu = textGhiChu.Text;
                    Chunha cn = new Chunha() { HoTen = hoten, Sdt = sdt, DiaChi = diachi, GhiChu = ghichu };
                    await chuNhaManagerment.AddChuNha(cn);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Chunha chn = context.Chunhas.Where(x => x.Idcn == IDcu).SingleOrDefault();
                    chn.HoTen = textHoTen.Text;
                    chn.Sdt = textSoDT.Text;
                    chn.DiaChi = textDiaChi.Text;
                    chn.GhiChu = textGhiChu.Text;
                    await chuNhaManagerment.AddChuNha(chn);

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
                dataGridViewChuNha_CellContentClick(sender, vt);
            }
            catch (Exception ex) {
           }
        }



        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            MIDForm mf = new MIDForm();
            mf.Show();
        }

        private void textSoDT_KeyPress(object sender, KeyPressEventArgs e)
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
