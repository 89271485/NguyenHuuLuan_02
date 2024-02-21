using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuLuan_02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon = 0;
            do
            {
                Console.WriteLine("*****CHUONG TRINH QUAN LY NHAN VIEN***");
                Console.WriteLine("------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien.");
                Console.WriteLine("2.Xuat thong tin cac nhan vien.");
                Console.WriteLine("3.Thong ke tong tien luong phai tra cho nhan vien.");
                Console.WriteLine("4.Tinh tien luong thuc lanh trung binh cua cac nhan vien.");
                Console.WriteLine("0.Thoat chuong trinh.");

                Console.Write("Ban chon chuc nang:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.Nhap();

                        break;
                    case 2:
                        ql.Xuat();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong nhan vien {ql.Tongluong()}");
                        break;
                    case 4:
                        Console.WriteLine($"Trung binh luong nhan vien {ql.TinhtrungBinh()}");
                        break;
                    case 5:
                        Console.ReadLine();
                        break;

                }

            } while (chon != 5);
        }
    }
}
