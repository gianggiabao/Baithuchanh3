using System;

namespace BTH4
{
    //TH4_BÀI2

    class nhanvien
    {
        private string hoten, quequan;
        private double hesoluong;
        private int luongcoban;
        public nhanvien()
        {
            luongcoban = 1000;
        }
        public static int LuongCoBan
        {
            get { return LuongCoBan; }
            set
            {
                if (value > 1000)
                    LuongCoBan = value;
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten:");
            hoten = Console.ReadLine();
            Console.Write("Nhap que quan:");
            quequan = Console.ReadLine();
            Console.Write("Nhap he so luong:");
            hesoluong = double.Parse(Console.ReadLine());
        }
        public double tinhluong
        {
            get { return hesoluong * luongcoban; }
        }
        public void Hien()
        {
            Console.WriteLine("Ho va ten :" + hoten);
            Console.WriteLine("que quan :" + quequan);
            Console.WriteLine("He so luong :" + hesoluong);
            Console.WriteLine("tinh luong :" + tinhluong);
        }
        public static double Max(double x, double y)
        {
            return x > y ? x : y;
        }
    }
    class QLyNhanvien
    {
        private nhanvien[] ds;
        private int sonv;
        public void Hien()
        {
            Console.WriteLine("thong tin ve nhan vien ");
            foreach (nhanvien x in ds)
                x.Hien();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so nhan vien:");
            sonv = int.Parse(Console.ReadLine());
            ds = new nhanvien[sonv];
            Console.WriteLine("Nhap thong tin Nhan vien:");
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i] = new nhanvien();
                ds[i].Nhap();
            }
        }
        public void Hienluongmax()
        {
            double luongmax = ds[0].tinhluong;
            for (int i = 0; i < ds.Length; ++i)
                luongmax = nhanvien.Max(luongmax, ds[i].tinhluong);
            Console.WriteLine("Luong can bo cao nhat la:" + luongmax);
        }
    }
    class Program
    {
        static void Main()
        {
            QLyNhanvien t = new QLyNhanvien();
            t.Nhap();
            t.Hien();
            t.Hienluongmax();

        }
    }
}
