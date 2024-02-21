using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuLuan_02
{
    class NhanVIenBC : NhanVien
    {
        private string mucxeploai;

        public NhanVIenBC() : base() { }

        public NhanVIenBC(string maso, string hoten, int luongcung,string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;

        }
        public string MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        } 
        public virtual void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai: ");
            mucxeploai = Console.ReadLine();


        }
        public override int TinhLuong()
        {
            int Luong;
            if (mucxeploai == "A")
                return Luong = (int)1.5 * LuongCung;
            else if (mucxeploai == "B")
                return Luong = (int)1.0 * LuongCung;
            else return Luong = (int)0.5 * LuongCung;

        }
    }
}
