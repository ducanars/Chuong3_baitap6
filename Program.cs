using System;

namespace Chuong3_baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            DsSinhVien htttak21 = new DsSinhVien();
            htttak21.Nhap();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            htttak21.LietKe();
            Console.ReadLine();
        }
    }
}
