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
    public partial class FormThemKhachHang : Form
    {
        Model1 contextdb = new Model1();
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private bool kiemtra()
        {
            if(txtTenKH.Text == "" || txtDiaCHi.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhập sai định dạng số điện thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                Customer customer = new Customer();
                customer.CustomerName = txtTenKH.Text;
                customer.Adress = txtDiaCHi.Text;
                customer.Phone = txtSDT.Text;

                contextdb.Customers.Add(customer);
                contextdb.SaveChanges();
                MessageBox.Show($"Thêm khách hàng {customer.CustomerName} thành công!", "Thông Báo", MessageBoxButtons.OK);

                FormKhachHang frmkh = new FormKhachHang();
                frmkh.StartPosition = FormStartPosition.CenterScreen;
                Close();
                frmkh.ShowDialog();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
