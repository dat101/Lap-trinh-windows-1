using System;
using System.Collections.Generic;
using System.Text;

namespace Quan_li_nhan_su
{
    class NhanVCC
    {
        protected string maso;
        protected string hoten;
        protected string phai;
        protected string ngaysinh;

    }
    class Nhanvien : NhanVCC
    {
        private string bangcap;
        public string Maso { get => maso; set => maso = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Bangcap { get => bangcap; set => bangcap = value; }
        public Nhanvien(string MS, string HT, string PP, string NS, string BC)
        {
            Maso = MS;
            Hoten = HT;
            Phai = PP;
            Ngaysinh = NS;
            Bangcap = BC;
        }
        public void infor()
        {
            Console.WriteLine(" Ma nhan vien: {0}", Maso);
            Console.WriteLine(" Ho ten: {0}", Hoten);
            Console.WriteLine(" Gioi tinh: {0}", Phai);
            Console.WriteLine(" Ngay sinh: {0}", Ngaysinh);
            Console.WriteLine(" Bang cap: {0}", Bangcap);

        }

    }
    class Khachhang : NhanVCC
    {
        private string loaiKH;
        public string Maso { get => maso; set => maso = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public Khachhang(string MS, string HT, string PP, string NS, string KH)

        {
            Maso = MS;
            Hoten = HT;
            Phai = PP;
            Ngaysinh = NS;
            LoaiKH = KH;
        }
        public void infor()
        {
            Console.WriteLine(" Ma Khach Hang: {0}", Maso);
            Console.WriteLine(" Ho ten: {0}", Hoten);
            Console.WriteLine(" Gioi tinh: {0}", Phai);
            Console.WriteLine(" Ngay sinh: {0}", Ngaysinh);
            Console.WriteLine(" Loai Khach Hang: {0}", LoaiKH);

        }
    }
}
    
