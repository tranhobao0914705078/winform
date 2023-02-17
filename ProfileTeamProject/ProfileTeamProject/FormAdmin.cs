using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileTeamProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public string laydulieu;
        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = laydulieu;
        }

        private void menuQLCN_Click(object sender, EventArgs e)
        {
            ThongtincanhanAdmin frmad = new ThongtincanhanAdmin();
            frmad.layinfoadmin = laydulieu;
            frmad.ShowDialog();
        }

        private void menuQLNV_Click(object sender, EventArgs e)
        {
            FormQLNV frmqlnv = new FormQLNV();
            this.Hide();
            frmqlnv.StartPosition = FormStartPosition.CenterScreen;
            frmqlnv.ShowDialog();
            this.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frm1.ShowDialog();
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frm1.ShowDialog();
        }

        private void menuQLKH_Click(object sender, EventArgs e)
        {
            FormKhachHang frmkh = new FormKhachHang();
            frmkh.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmkh.ShowDialog();
            this.Show();
        }
    }
}
