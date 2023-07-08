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
    public partial class MIDForm : Form
    {
        public MIDForm()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void thôngTinChủNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChuNha frm = new FormChuNha();
            frm.Show();
        }

        private void thôngTinPhòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyPhongTro frm = new FormQuanLyPhongTro();
            frm.Show();
        }

        private void tìnhTrạngPhòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTinhTrangPhongTro frm = new FormTinhTrangPhongTro();
            frm.Show();
        }

        private void thôngTinKháchThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhachThue frm = new FormKhachThue();
            frm.Show();
        }

        private void lậpHợpĐồngThuêNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLapHopDong frm = new FormLapHopDong();
            frm.Show();
        }

        private void lậpHóaĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLapHoaDon frm = new FormLapHoaDon();
            frm.Show();
        }

        private void dịchVụChoThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDichVu frm = new FormDichVu();
            frm.Show();
        }

        private void tìnhTrạngThanhToánHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTinhTrangPhongTro frm = new FormTinhTrangPhongTro();
            frm.Show();
        }
    }
}
