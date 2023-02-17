using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfileTeamProject.ModelData;
using ProfileTeamProject.DataTier;
using ProfileTeamProject.libs;

namespace ProfileTeamProject.BusinessTier
{
    class TaiKhoanBT
    {
        private readonly TaiKhoanDT taikhoandt;

        public TaiKhoanBT()
        {
            taikhoandt = new TaiKhoanDT();
        }

        public Employee LayTaiKhoan(string TenDangNhap, string MatKhau)
        {
            MatKhau = Helpers.MaHoaMatKhauMD5(MatKhau);
            return taikhoandt.LayTaiKhoan(TenDangNhap, MatKhau);
        }
    }
}
