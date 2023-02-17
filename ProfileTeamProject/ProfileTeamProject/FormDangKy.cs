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
namespace ProfileTeamProject
{
    public partial class FormDangKy : Form
    {
        Model1 contextdb = new Model1();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
            Close();
        }

        private void ckHienThiMk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienThiMk.Checked == true)
            {
                txtMK.UseSystemPasswordChar = true;
            }
            else
            {
                txtMK.UseSystemPasswordChar = false;
            }
        }

        private bool kiemtra()
        {
            if(txtTenDangNhap.Text == "" || txtMK.Text == "" || txthoten.Text == "" || txtmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại là 10 số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhập sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Employee nv = contextdb.Employees.SingleOrDefault(n => n.Username == txtTenDangNhap.Text);
            if (kiemtra())
            {
                if(nv != null)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Employee nv1 = new Employee();
                    nv1.Username = txtTenDangNhap.Text;
                    nv1.Password = txtMK.Text;
                    nv1.FullName = txthoten.Text;
                    nv1.Email = txtmail.Text;
                    nv1.Phone = txtSDT.Text;
                    if(cbLoai.SelectedIndex == 0)
                    {
                        nv1.Type = "Nhân Viên";
                    }
                    contextdb.Employees.Add(nv1);
                    contextdb.SaveChanges();
                    MessageBox.Show($"Chúc mừng {nv1.FullName} đăng ký thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                    this.Hide();
                    Form1 frm1 = new Form1();
                    frm1.ShowDialog();
                }
            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
