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
    public partial class FormTinhTrangPhongTro : Form
    {
        bool ktThem;
        int IDcu;
        DataGridViewCellEventArgs vt;
        TinhTrangManagerment trangManagermen = new TinhTrangManagerment();
        public FormTinhTrangPhongTro()
        {
            InitializeComponent();
        }

        private void FormTinhTrangPhongTro_Load(object sender, EventArgs e)
        {
            KeyOpen(true);
            loadData();
        }

        public async void loadData()
        {

            List<Tinhtrang> lstTT = await trangManagermen.GetAllTinhtrang();
            dataGridViewTinhTrang.DataSource = lstTT.Select(x => new
            {
                x.MaTinhTrang,
                x.TinhTrang1
            }).ToList();


        }
        public void XoaTrang()
        {
            textBoxID.Text = "";
            textTinhTrang.Text = "";

        }
        public void KeyOpen(bool open)
        {
            dataGridViewTinhTrang.Enabled = open;
            buttonCapNhat.Enabled = open;
            buttonThem.Enabled = open;
            buttonKetThuc.Enabled = open;
            buttonXoa.Enabled = open;

            buttonGhi.Enabled = !open;
            buttonKhongGhi.Enabled = !open;


            textBoxID.ReadOnly = open;
            textTinhTrang.ReadOnly = open;


        }

        private async void dataGridViewTinhTrang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewTinhTrang.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewTinhTrang.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewTinhTrang.Rows[selectedrowindex];

                string cellvalue = Convert.ToString(selectedRow.Cells["ID"].Value);

                if (!string.IsNullOrEmpty(cellvalue))
                {
                    vt = e;
                    
                        int ttID = Convert.ToInt32(cellvalue);

                        var tt = await trangManagermen.GetTinhTrangById(ttID); ;
                        
                        // lay duy nhat 1 employee sao cho so thu tu cua dong bang so ID 

                        textBoxID.Text = tt.MaTinhTrang.ToString();
                        textTinhTrang.Text = tt.TinhTrang1.ToString();

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
                    
                    await trangManagermen.DeletePhongTroById(IDcu);
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
                    Tinhtrang tt = new Tinhtrang() { TinhTrang1 = tinhtrang };
                   await trangManagermen.AddPhongTro(tt);
                    MessageBox.Show("Đã thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (ktThem == false)
                {
                    Tinhtrang tt = context.Tinhtrangs.Where(x => x.MaTinhTrang == IDcu).SingleOrDefault();

                    tt.TinhTrang1 = textTinhTrang.Text;

                    await trangManagermen.UpdatePhongTro(tt);
                    MessageBox.Show("Đã sửa thành công ", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                dataGridViewTinhTrang_CellContentClick(sender, vt);
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
