using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_
{
    internal class taikhoan
    {
        internal int pin;

        public int SoThe { get; set; }
        public int PIN { get; set; }
        public string TenChuTaiKhoan { get; set; }
        public double sodu { get; set; }


        public taikhoan()
        {

        }

        public taikhoan(int soThe, int mapin, string tenChuTaiKhoan, double soDu)
        {
            SoThe = soThe;
            PIN = mapin;
            TenChuTaiKhoan = tenChuTaiKhoan;
            sodu = soDu;
        }

        public void RutTien(int soTienRut)
        {
            if (soTienRut > sodu)
            {
                Console.WriteLine("số dư không đủ.");
            }
            else
            {
                sodu -= soTienRut;
                Console.WriteLine("rút tiền thành công,số dư hiện tại : " + sodu);
            }
        }



        public void NapTien(int soTienNap)
        {
            sodu += soTienNap;
            Console.WriteLine("nạp tiền thành công,số dư hiện tại: " + sodu);
        }





        public void ChuyenTien(List<taikhoan> danhSachTaiKhoan, int soTheChuyen, double soTienChuyen)
        {
            foreach (taikhoan taiKhoan in danhSachTaiKhoan)
            {
                if (taiKhoan.SoThe == soTheChuyen)
                {
                    if (soTienChuyen > sodu)
                    {
                        Console.WriteLine("Số dư không đủ");
                    }
                    else
                    {
                        sodu -= soTienChuyen;
                        taiKhoan.sodu += soTienChuyen;
                        Console.WriteLine("chuyển tiền thành công,số dư của bạn là: " + sodu);
                    }
                    return;
                }
            }
            Console.WriteLine("số thẻ chuyển tiền không tồn tại.");
        }






    }
}

    

