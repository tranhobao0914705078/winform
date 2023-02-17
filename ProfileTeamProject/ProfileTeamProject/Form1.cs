using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfileTeamProject.ModelData;
using ProfileTeamProject.DataTier;
using ProfileTeamProject.BusinessTier;
using ProfileTeamProject.libs;

namespace ProfileTeamProject
{
    public delegate void DangNhapThanhCong();
    public partial class Form1 : Form
    {
        public event DangNhapThanhCong DangNhapThanhCong;
        private TaiKhoanBT taiKhoanBT;

        Model1 contextDB = new Model1();
        public Form1()
        {
            InitializeComponent();
            taiKhoanBT = new TaiKhoanBT();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.CenterScreen;
        }


        private void ckHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienThi.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!!!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tendangnhap = txtTendangnhap.Text;
            string matkhau = txtMatKhau.Text;
            Employee taikhoan = taiKhoanBT.LayTaiKhoan(tendangnhap, matkhau);
            if(taikhoan != null)
            {
                if(taikhoan.Type == "Admin")
                {
                    if(MessageBox.Show("Đăng nhập thành công!!! (Quyền Admin)", "Thông Báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Form2 frm2 = new Form2();
                        frm2.StartPosition = FormStartPosition.CenterScreen;
                        this.Hide();
                        frm2.laydulieu = txtTendangnhap.Text;
                        frm2.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!!! (Quyền Nhân Viên)", "Thông Báo", MessageBoxButtons.OK);
                    //Form frm2 = new Form2();
                    //this.Hide();
                    //frm2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy frmDK = new FormDangKy();
            frmDK.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmDK.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát Chương Trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}

