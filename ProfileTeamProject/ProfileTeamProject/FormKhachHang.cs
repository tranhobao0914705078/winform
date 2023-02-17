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
    public partial class FormKhachHang : Form
    {   
        Model1 contextdb = new Model1();
        private int column;
        public FormKhachHang()
        {
            column = 1;
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            List<Customer> customers = contextdb.Customers.ToList();
            fillcb(customers);
            filldata(customers);
            reload();
            sum();
        }

        private void fillcb(List<Customer> list)
        {
            list.Insert(0, new Customer() { Adress = "" });
            this.cbdiachi.DataSource = list;
            this.cbdiachi.DisplayMember = "Adress";
            this.cbdiachi.ValueMember = "CustomerID";
        }

        private void filldata(List<Customer> customers)
        {
            dgvCustomer.Rows.Clear();
            foreach(var item in customers)
            {
                int index = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[index].Cells[0].Value = column;
                dgvCustomer.Rows[index].Cells[1].Value = item.CustomerName;
                dgvCustomer.Rows[index].Cells[2].Value = item.Adress;
                dgvCustomer.Rows[index].Cells[3].Value = item.Phone;
                column++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemKhachHang frmaddKH = new FormThemKhachHang();
            frmaddKH.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frmaddKH.ShowDialog();
            this.Show();
        }

        private void reload()
        {
            List<Customer> customers = contextdb.Customers.ToList();
            filldata(customers);
        }

        private void brnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void sum()
        {
            int result = 0;
            for(int i = 0; i <  dgvCustomer.Rows.Count; i++)
            {
                if(dgvCustomer.Rows[i].Cells[0].Value != null)
                {
                    result++;
                }
            }
            txtSum.Text = result.ToString();
        }

        private void btnFix_Click(object sender, EventArgs e)
        { 
    
                List<Customer> khoa = (from m in contextdb.Customers.ToList()
                                       where string.Format(m.Adress).Contains(cbdiachi.Text) && string.Format(m.CustomerName).Contains(txtHoTen.Text)
                                       select m).ToList();
                filldata(khoa);
                sum();
        }
    }
}
