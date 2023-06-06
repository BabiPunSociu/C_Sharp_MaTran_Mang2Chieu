using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    internal class MaTran
    {
        private int m, n;   //  m:hang  n:cot
        private double[,] a;

        public MaTran() { }

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.a = new double[m, n];
        }

        public void nhap(string message)
        {
            try
            {
                do
                {
                    Console.WriteLine("Nhap du lieu ma tran" + message);
                    Console.Write("Nhap so hang (m>0): m = ");
                    m = int.Parse(Console.ReadLine());
                } while (m <= 0);
                do
                {
                    Console.Write("\nNhap so cot (n>0): n = ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0);


                a = new double[m, n];

                Console.WriteLine("Nhap ma tran:");
                for (int i = 0; i < m; i++)
                {
                    string str = Console.ReadLine().Trim();
                    string[] strSub = str.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = double.Parse(strSub[j]);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void xuat()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j].ToString().PadLeft(6));
                }
                Console.WriteLine();
            }
        }


        public static MaTran operator +(MaTran A, MaTran B)
        {
            if (A.m == B.m && A.n == B.n)
            {
                MaTran C = new MaTran(A.m, A.n);
                for (int i = 0; i < A.m; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        C.a[i, j] = A.a[i, j] + B.a[i, j];
                    }
                }
                return C;
            }
            else
            {
                throw new Exception("Sai kich thuoc ma tran.Khong tinh tong duoc.");
            }
        }

        public static MaTran operator -(MaTran A, MaTran B)
        {
            if (A.m == B.m && A.n == B.n)
            {
                MaTran C = new MaTran(A.m, A.n);
                for (int i = 0; i < A.m; i++)
                {
                    for (int j = 0; j < A.n; j++)
                    {
                        C.a[i, j] = A.a[i, j] - B.a[i, j];
                    }
                }
                return C;
            }
            else
            {
                throw new Exception("Sai kich thuoc ma tran.Khong tinh hieu duoc.");
            }
        }


        public static MaTran operator*(MaTran A, MaTran B)
        {
            if(A.n == B.m)
            {
                MaTran C = new MaTran(A.m,B.n);

                for(int i = 0; i < C.m; i++)
                {
                    for(int j=0;j<C.n; j++)
                    {
                        C.a[i, j] = 0;
                        for(int k = 0; k < A.n; k++)
                        {
                            C.a[i,j] += A.a[i,k] * B.a[k,j];
                        }    
                    }    
                }
                return C;
            }else
            {
                throw new Exception("Sai kich thuoc ma tran. Khong tinh tich duoc.");
            }
        }

        public MaTran mtChuyenVi()
        {
            MaTran AT = new MaTran(n,m);
            for(int i=0;i<AT.m;i++)
            {
                for(int j=0;j<AT.n;j++)
                {
                    AT.a[i,j] = a[j,i];
                }    
            }    
            return AT;
        }

        public bool mtVuong()
        {
            return (m==n?true:false);
        }
    }
}
