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
    public partial class FormQLNV : Form
    {
        Model1 contextdb = new Model1();
        public FormQLNV()
        {
            InitializeComponent();
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            List<Employee> list = contextdb.Employees.ToList();
            filldata(list);
            Sum();
        }

        private void filldata(List<Employee> list)
        {
            dgvEmployee.Rows.Clear();
            foreach(var item in list)
            {
                int i = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[i].Cells[0].Value = item.Username;
                dgvEmployee.Rows[i].Cells[1].Value = item.Password;
                dgvEmployee.Rows[i].Cells[2].Value = item.FullName;
                dgvEmployee.Rows[i].Cells[3].Value = item.Email;
                dgvEmployee.Rows[i].Cells[4].Value = item.Phone;
                dgvEmployee.Rows[i].Cells[5].Value = item.Type;
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtusername.Enabled = false;
                    dgvEmployee.CurrentCell.Selected = true;
                    txtusername.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtPass.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtname.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtemail.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtsdt.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã chọn sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool kiemtradulieu()
        {
            if (txtusername.Text == "" || txtPass.Text == "" || txtemail.Text == "" || txtsdt.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtsdt.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhập sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private int checkdulieu(string username)
        {
            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                if (dgvEmployee.Rows[i].Cells[0].Value != null) 
                {
                    if (dgvEmployee.Rows[i].Cells[0].Value.ToString() == username) 
                        return i;
                }
            }
            return -2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu())
            {
                if(checkdulieu(txtusername.Text) == -2)
                {
                    Employee employee = new Employee();
                    employee.Username = txtusername.Text;
                    employee.Password = txtPass.Text;
                    employee.FullName = txtname.Text;
                    employee.Email = txtemail.Text;
                    employee.Phone = txtsdt.Text;
                    if(cbloai.SelectedIndex == 0)
                    {
                        employee.Type = "Admin";
                    }
                    else
                    {
                        employee.Type = "Nhân Viên";
                    }
                    contextdb.Employees.Add(employee);
                    contextdb.SaveChanges();
                    MessageBox.Show($"Thêm Nhân Viên {employee.FullName} Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    reload();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, tên đăng nhập này đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtusername.Text = "";
            txtname.Text = "";
            txtPass.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
        }

        private void reload()
        {
            List<Employee> list = contextdb.Employees.ToList();
            filldata(list);
        }

        private void brnReload_Click(object sender, EventArgs e)
        {
            List<Employee> listac = contextdb.Employees.ToList();
            filldata(listac);
        }

        private void Sum()
        {
            int ad = 0, nv = 0;
            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                if (dgvEmployee.Rows[i].Cells[0].Value != null)
                {
                    if(dgvEmployee.Rows[i].Cells[5].Value.ToString() == "Nhân Viên")
                    {
                        nv++;
                    }
                    else
                    {
                        ad++;
                    }
                }
            }
            txtSLNV.Text = nv.ToString();
            txtSLAD.Text = ad.ToString();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu())
            {
                Employee employ = contextdb.Employees.FirstOrDefault(p => p.Username == txtusername.Text);
                if(employ != null)
                {
                    employ.FullName = txtname.Text;
                    employ.Password = txtPass.Text;
                    employ.Email = txtemail.Text;
                    employ.Phone = txtsdt.Text;

                    if(cbloai.SelectedIndex == 0)
                    {
                        employ.Type = "Admin";
                    }
                    else
                    {
                        employ.Type = "NhanVien";
                    }
                    contextdb.Employees.AddOrUpdate(employ);
                    contextdb.SaveChanges();
                    MessageBox.Show($"Cập nhật nhân viên {employ.FullName} thành công!", "Thông Báo", MessageBoxButtons.OK);
                    reload();
                }
                else
                {
                    MessageBox.Show($"Cập nhật nhân viên {employ.FullName} thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employee = contextdb.Employees.FirstOrDefault(p => p.Username == txtusername.Text);
            if(employee != null)
            {
                if(MessageBox.Show($"Xác nhận xóa nhân viên {employee.FullName}?","Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contextdb.Employees.Remove(employee);
                    contextdb.SaveChanges();
                    reload();
                    Sum();
                    MessageBox.Show($"Xóa nhân viên {employee.FullName} thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Xóa nhân viên {employee.FullName} thất bại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            List<Employee> listemploy = (from m in contextdb.Employees.ToList()
                                         where string.Format(m.FullName).Contains(txtTimkiem.Text)
                                         select m).ToList();
            filldata(listemploy);
            Sum();
        }
    }
}
