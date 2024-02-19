using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;



            List<taikhoan> DanhSachTaiKhoan = new List<taikhoan>();
            { 
            new taikhoan { TenChuTaiKhoan = "david", pin = 123, SoThe = 1234, sodu = 1000 };
            new taikhoan { TenChuTaiKhoan = "kevin", pin = 234, SoThe = 2345, sodu = 2000 };
            new taikhoan { TenChuTaiKhoan = "tom", pin = 345, SoThe = 3456, sodu = 3000 };
            new taikhoan { TenChuTaiKhoan = "bruno", pin = 456, SoThe = 4567, sodu = 4000 };
            new taikhoan { TenChuTaiKhoan = "jung", pin = 567, SoThe = 5678, sodu = 5000 };
            new taikhoan { TenChuTaiKhoan = "jin", pin = 678, SoThe = 6789, sodu = 2000 };
            new taikhoan { TenChuTaiKhoan = "xun", pin = 789, SoThe = 0001, sodu = 1000 };
            new taikhoan { TenChuTaiKhoan = "vin", pin = 001, SoThe = 0002, sodu = 1000 };
            new taikhoan { TenChuTaiKhoan = "david", pin = 002, SoThe = 0003, sodu = 1000 };
            new taikhoan { TenChuTaiKhoan = "david", pin = 003, SoThe = 0004, sodu = 1000 };
}
            Console.Write("xin mời nhập vào số thẻ : ");
            int soThe = int.Parse(Console.ReadLine());
            Console.Write("xin mời nhập vào mã PIN: ");
            int maPin = int.Parse(Console.ReadLine());
            bool taiKhoanTimThay = false;
            foreach (taikhoan taiKhoan in DanhSachTaiKhoan)
            {
                if (taiKhoan.pin == maPin && taiKhoan.SoThe == soThe)
                {
                    taiKhoanTimThay = true;
                    Console.WriteLine("Xin chào " + taiKhoan.TenChuTaiKhoan );
                    int luaChon;
                    do
                    {
                        Console.WriteLine(" 1.Xem số dư");
                        Console.WriteLine(" 2.Rút tiền ");
                        Console.WriteLine(" 3.Nạp tiền");
                        Console.WriteLine(" 4.chuyển tiền tới số thẻ");
                        Console.WriteLine(" 5.gưi tiết kiệm");
                        Console.WriteLine(" 0.Thoat");                 
                        Console.Write("Nhap lua chon cua ban: ");
                        luaChon = int.Parse(Console.ReadLine());
                        switch (luaChon)
                        {
                            case 0:
                                {
                                    Console.WriteLine("goodbye");
                                }
                                break;

                            case 1:
                                {
                                    Console.WriteLine("số dư hiện tại là:" + " " + taiKhoan.sodu);
                                }
                                break;

                            case 2:
                                {
                                    Console.Write("nhập vào số tiền rút: ");
                                    int soTienRut = int.Parse(Console.ReadLine());
                                    taiKhoan.RutTien(soTienRut);
                                }
                                break;

                            case 3:
                                {
                                    Console.Write("nhập vào số tiền nạp: ");
                                    int soTienNap = int.Parse(Console.ReadLine());
                                    taiKhoan.NapTien(soTienNap);
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("nhập vào số thẻ muốn chuyền tới:");
                                    int soTheChuyen = int.Parse(Console.ReadLine());
                                    Console.Write("nhập số tiền muốn chuyển:");
                                    double soTienChuyen = double.Parse(Console.ReadLine());
                                    taiKhoan.ChuyenTien(DanhSachTaiKhoan, soTheChuyen, soTienChuyen);
                                }
                                break;
                            case 5:
                                {
                          
                                }
                                break;

                            default:
                                Console.WriteLine("lựa chọn không tồn tại. vui lòng chọn lại.\n");
                                break;
                        }
                    } while (luaChon != 0);
                }
                if (!taiKhoanTimThay)
                {
                    Console.WriteLine("số thẻ hoặc mã pin không tồn tại .");
                }

               Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}






