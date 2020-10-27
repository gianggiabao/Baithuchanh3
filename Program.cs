using System;

namespace BTH4
{
    // TH4_BÀI1
    class matran
    {
        private int m, n;
        private int[,] a;
        public void Nhap()
        {
            Console.Write("Nhap so hang:");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot:");
            n = int.Parse(Console.ReadLine());
            a = new int[m, n];
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        private void Hien()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; ++i)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public matran tong(matran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                matran t = new matran();
                t.m = this.m;
                t.n = this.n;
                t.a = new int[this.m, this.n];
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.m; ++i)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }

        class Program1
        {
            static void Main1()
            {
                Console.WriteLine("Nhap thong tin cho ma tran thu nhat");
                matran t1 = new matran();
                t1.Nhap();
                Console.WriteLine("nhap thong tin ma tran thu nhat");
                matran t2 = new matran();
                t2.Nhap();
                matran t3 = t1.tong(t2);
                if (t3 == null)
                    Console.WriteLine("Hai ma tran co kich thuoc khac nhau,ko tinh duoc tong");
                else
                {
                    Console.WriteLine("thong tin cua ma tran tong");
                    t3.Hien();
                }
                Console.ReadKey();
            }
        }

    }
}
    //TH4_BÀI2
//    class nhanvien
//    {
//        private string hoten, quequan;
//        private double hesoluong;
//        private int luongcoban;
//        public nhanvien()
//        {
//            luongcoban = 1000;
//        }
//        public static int LuongCoBan
//        {
//            get { return LuongCoBan; }
//            set
//            {
//                if (value > 1000)
//                    LuongCoBan = value;
//            }
//        }
//        public void Nhap()
//        {
//            Console.Write("Nhap ho ten:");
//            hoten = Console.ReadLine();
//            Console.Write("Nhap que quan:");
//            quequan = Console.ReadLine();
//            Console.Write("Nhap he so luong:");
//            hesoluong = double.Parse(Console.ReadLine());
//        }
//        public double tinhluong
//        {
//            get { return hesoluong * luongcoban; }
//        }
//        public void Hien()
//        {
//            Console.WriteLine("Ho va ten :" + hoten);
//            Console.WriteLine("que quan :" + quequan);
//            Console.WriteLine("He so luong :" + hesoluong);
//            Console.WriteLine("tinh luong :" + tinhluong);
//        }
//        public static double Max(double x, double y)
//        {
//            return x > y ? x : y;
//        }
//    }
//    class QLyNhanvien
//    {
//        private nhanvien[] ds;
//        private int sonv;
//        public void Hien()
//        {
//            Console.WriteLine("thong tin ve nhan vien ");
//            foreach (nhanvien x in ds)
//                x.Hien();
//        }
//        public void Nhap()
//        {
//            Console.WriteLine("Nhap so nhan vien:");
//            sonv = int.Parse(Console.ReadLine());
//            ds = new nhanvien[sonv];
//            Console.WriteLine("Nhap thong tin Nhan vien:");
//            for (int i = 0; i < ds.Length; i++)
//            {
//                ds[i] = new nhanvien();
//                ds[i].Nhap();
//            }
//        }
//        public void Hienluongmax()
//        {
//            double luongmax = ds[0].tinhluong;
//            for (int i = 0; i < ds.Length; ++i)
//                luongmax = nhanvien.Max(luongmax, ds[i].tinhluong);
//            Console.WriteLine("Luong can bo cao nhat la:" + luongmax);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            QLyNhanvien t = new QLyNhanvien();
//            t.Nhap();
//            t.Hien();
//            t.Hienluongmax();

//        }
//    }
//}

