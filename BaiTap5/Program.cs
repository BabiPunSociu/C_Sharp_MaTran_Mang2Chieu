using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaTran mtA = new MaTran();
            MaTran mtB = new MaTran();

            // nhap du lieu
            mtA.nhap("A");
            mtB.nhap("B");

            // xuât du lieu
            Console.WriteLine("Ma tran A:");
            mtA.xuat();

            Console.WriteLine("\nMa tran B:");
            mtB.xuat();

            MaTran mtTong = mtA + mtB;
            Console.WriteLine("\nMa tran A+B:");
            mtTong.xuat();

            MaTran mtHieu = mtA - mtB;
            Console.WriteLine("\nMa tran A-B:");
            mtHieu.xuat();

            // ma tran C
            MaTran mtC = new MaTran();
            mtC.nhap("C");
            MaTran mtTich = mtA * mtC;
            Console.WriteLine("\nMa tran A*B:");
            mtTich.xuat();

            MaTran mtChuyenVi = mtA.mtChuyenVi();
            Console.WriteLine("\nMa tran chuyen vi cua ma tran A:");
            mtChuyenVi.xuat();

            Console.WriteLine("\nMa tran A co phai ma tran vuong hay khong?   - " + mtA.mtVuong());
        }
    }
}