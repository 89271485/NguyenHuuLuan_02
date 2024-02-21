using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuLuan_02
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;

        public NhanVien()
        {
        }
        public NhanVien(string maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;

        }
        public string MaSo
        {
            set { maso = value; }
            get { return maso;  }
        }
        public string HoTen
        {
            set { hoten = value; }
            get { return hoten; }
        }
        public int LuongCung
        {
            set { luongcung = value; }
            get { return luongcung; }
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            this.maso = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            this.hoten = Console.ReadLine();
            Console.Write("Luong cung cua nhan vien: ");
            this.luongcung = int.Parse(Console.ReadLine());


        }
        public virtual int TinhLuong()
        {
            return 0;
        }
    }

}
