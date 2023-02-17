using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfileTeamProject.ModelData;

namespace ProfileTeamProject.DataTier
{
    class TaiKhoanDT
    {
        public Employee LayTaiKhoan(string TenDangNhap, string MatKhau)
        {
            using(var contextdb = new Model1())
            {
                return contextdb.Employees.Where(p => p.Username == TenDangNhap && p.Password == MatKhau).FirstOrDefault();
            }
        }
    }
}
