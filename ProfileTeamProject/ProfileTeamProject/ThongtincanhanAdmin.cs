using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfileTeamProject.ModelData;

namespace ProfileTeamProject
{
    public partial class ThongtincanhanAdmin : Form
    {
        Model1 contextdb = new Model1();
        public ThongtincanhanAdmin()
        {
            InitializeComponent();
        }

        public void settextbox(bool a)
        {
            txtName.Enabled = a;
            txtemail.Enabled = a;
            txtsdt.Enabled = a;
        }

        public string layinfoadmin;

        private void ThongtincanhanAdmin_Load(object sender, EventArgs e)
        {
           
            txtUsername.Enabled = false;
            txtUsername.Text = layinfoadmin;
            Employee ac = contextdb.Employees.SingleOrDefault(n => n.Username == txtUsername.Text);
            if (ac != null)
            {
                txtName.Text = ac.FullName;
                txtemail.Text = ac.Email;
                txtsdt.Text = ac.Phone;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            settextbox(true);
        }

        private bool kiemtra()
        {
            if(txtName.Text == "" || txtemail.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cần thay đổi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtsdt.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Employee employe = contextdb.Employees.SingleOrDefault(p => p.Username == txtUsername.Text);
            if (kiemtra())
            {
                if(employe != null)
                {
                    employe.FullName = txtName.Text;
                    employe.Email = txtemail.Text;
                    employe.Phone = txtsdt.Text;

                    contextdb.Employees.AddOrUpdate(employe);
                    contextdb.SaveChanges();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK);
                    settextbox(false);
                }
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhập sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.Handled = true;
        }
    }
}
