using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Phan_Mang_So
{
    internal class Fraction
    {
        protected int Mau, Tu;
        public Fraction(int tu, int mau)
        {
            this.Tu = tu;
            this.Mau = mau;
        }
        public Fraction()
        {
        }
        public void NhapPhanSo()
        {
            int a = 0, b = 0;
            Console.Write("\nNhap vao phan so format a/b:  ");
            TachString(ref a, ref b);
            this.Tu = a;
            this.Mau = b;
        }

        public void TachString(ref int a, ref int b)
        {
            string so = Console.ReadLine();
            string[] splitStr = so.Split('/');
            a = int.Parse(splitStr[0]);
            b = int.Parse(splitStr[1]);
        }

        public void InPhanSo()
        {
            Console.WriteLine("Phan so la: {0}/{1}", Tu, Mau);

        }

        public override string? ToString()
        {
            return Tu + "/" + Mau;
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction fr = new Fraction();
            if (f1.Mau%f2.Mau == 0 && f1.Mau > f2.Mau)
            {
                fr.Tu = f1.Tu + f2.Tu*(f1.Mau/f2.Mau);
                fr.Mau = f1.Mau;
            }
            else if (f2.Mau%f1.Mau == 0 && f1.Mau < f2.Mau)
            {
                fr.Tu = f1.Tu*(f2.Mau/f1.Mau) + f2.Tu;
                fr.Mau = f2.Mau;
            }else if (f1.Mau == f2.Mau)
            {
                fr.Tu = f1.Tu + f2.Tu ;
                fr.Mau = f1.Mau;
            } 
            else
            {
                fr.Tu = f1.Tu * f2.Mau + f2.Tu*f1.Mau;
                fr.Mau = f1.Mau*f2.Mau;
            }
            return fr;  
            
        }
        public static Fraction Sub(Fraction f1, Fraction f2)
        {
            Fraction fr = new Fraction();
            if (f1.Mau % f2.Mau == 0 && f1.Mau > f2.Mau)
            {
                fr.Tu = f1.Tu - f2.Tu * (f1.Mau / f2.Mau);
                fr.Mau = f1.Mau;
            }
            else if (f2.Mau % f1.Mau == 0 && f1.Mau < f2.Mau)
            {
                fr.Tu = f1.Tu * (f2.Mau / f1.Mau) - f2.Tu;
                fr.Mau = f2.Mau;
            }
            else if (f1.Mau == f2.Mau)
            {
                fr.Tu = f1.Tu - f2.Tu;
                fr.Mau = f1.Mau;
            }
            else
            {
                fr.Tu = f1.Tu * f2.Mau - f2.Tu * f1.Mau;
                fr.Mau = f1.Mau * f2.Mau;
            }
            return fr;
        }

        public static Fraction Mul(Fraction f1, Fraction f2)
        {
            Fraction fr = new Fraction();   
            fr.Tu = f1.Tu * f2.Tu;
            fr.Mau = f1.Mau * f2.Mau;
            return fr;
        }
        public static Fraction Div(Fraction f1, Fraction f2)
        {
            Fraction fr = new Fraction();
            fr.Tu = f1.Tu * f2.Mau;
            fr.Mau = f1.Mau * f2.Tu;
            return fr;
        }

        private int UCLN(int a, int b)
        {

            if (a != 0)
            {
                if (a > 0)
                {
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
                else
                {
                    a = -a;
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
            }
            else return 0;

        }

        public void RutGon()
        {
            int a = UCLN(this.Tu, this.Mau);

            if (a != 0)
            {
                if (a > 0)
                {
                    this.Tu = this.Tu / a;
                    this.Mau = this.Mau / a;
                }
                else
                {
                    this.Tu = this.Tu / (-a);
                    this.Mau = this.Mau / (a);
                }
            }
            else
            {
                this.Tu = 0;
                this.Mau = 0;
            }
        }

        public void NgichDao()
        {
            int trungGian = Tu;
            Tu = Mau;
            Mau = trungGian;
        }

        static void Main(string[] args)
        {
            Fraction fr0=new Fraction(); fr0.NhapPhanSo();
            Console.WriteLine("Phan so vua nhap: "+ fr0);

            Fraction fr1 = new Fraction(1,3);
            Fraction fr2 = new Fraction(2,5);
            Fraction fr3 = Add(fr1,fr2);

            Console.WriteLine($"{fr1} + {fr2} = {fr3}");
            Console.WriteLine($"{fr1} - {fr2} = {Sub(fr1,fr2)}");
            Console.WriteLine($"{fr1} * {fr2} = {Mul(fr1,fr2)}");
            Console.WriteLine($"{fr1} : {fr2} = {Div(fr1, fr2)}");
            fr1.NgichDao();
            Console.WriteLine("Nghich dao f1: " + fr1);

            Fraction fr4 = new Fraction(21, 15);
            Console.WriteLine("fr4: " + fr4);
            fr4.RutGon();
            Console.WriteLine("rut gon f4: " + fr4);
        }
    }
}
