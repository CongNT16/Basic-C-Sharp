using System;
using System.Collections;

namespace Exercise2_Bai_Tap_Phan_Dieu_Kien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------- Ex-4 ---------------------------");
            Console.Write("Nhap tuoi: "); 
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 0 && age <= 2)
            {
                Console.WriteLine("Tre so sinh");
            } else if (age > 2 && age <= 10)
            {
                Console.WriteLine("Nhi dong");
            }
            else if (age > 10 && age <= 17)
            {
                Console.WriteLine("Vi thanh nien");
            }
            else if (age > 17 && age <= 39)
            {
                Console.WriteLine("Thanh nien");
            }
            else if (age > 39 && age <= 50)
            {
                Console.WriteLine("Trung nien");
            }
            else
            {
                Console.WriteLine("Cao nien");
            }


            Console.WriteLine("--------------------------- Ex-3 ---------------------------");
            Console.Write("Nhap nam san xuat: ");
            int namSanXuat = Convert.ToInt32(Console.ReadLine());
            if (namSanXuat >= 15)
            {
                Console.WriteLine("Thay the");
            } else if (namSanXuat >= 10 && namSanXuat < 15)
            {
                Console.WriteLine("Bao tri");
            }
            else
            {
                Console.WriteLine("Khong co de xuat");
            }

            Console.WriteLine("--------------------------- Ex-2 ---------------------------");
            Console.Write("Nhap diem trung binh: ");
            double diemTB = Convert.ToSingle(Console.ReadLine());
            if (diemTB >= 9 )
            {
                Console.WriteLine("Hoc bong la 5000000");
            } else if (diemTB>=8 && diemTB<9)
            {
                Console.WriteLine("Hoc bong la 3000000");
            }
            else if (diemTB >= 7 && diemTB < 8)
            {
                Console.WriteLine("Hoc bong la 1000000");
            }
            else
            {
                Console.WriteLine("Khong co hoc bong");
            }


            Console.WriteLine("--------------------------- Ex-1 ---------------------------");
            Console.Write("Nhap luong: ");
            double luong = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap gio lam viec: ");
            double gioLamViec = Convert.ToSingle(Console.ReadLine());
            if (gioLamViec >= 200)
            {
                Console.WriteLine("Thuong la {0} dong",0.2*luong);
            }
            else if (gioLamViec >= 100 && gioLamViec < 200)
            {
                Console.WriteLine("Thuong la {0} dong", 0.1 * luong);
            }
            else
            {
                Console.WriteLine("Thuong = 0 dong");
            }

            Console.WriteLine("--------------------------- Ex0 ---------------------------");
            Console.Write("Nhap diem trung binh: ");
            double diemTrungBinh = Convert.ToSingle(Console.ReadLine());
            if (diemTrungBinh >= 9)
            {
                Console.WriteLine("Hoc luc xuat sac");
            }
            else if (diemTrungBinh >= 8 && diemTrungBinh < 9)
            {
                Console.WriteLine("Hoc luc Gioi");
            }
            else if (diemTrungBinh >= 7 && diemTrungBinh < 8)
            {
                Console.WriteLine("Hoc luc kha");
            }
            else
            {
                Console.WriteLine("Hoc luc kem");
            }

            


            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7(3,4,5);







        }
        public static void Ex1()
        {
            Console.WriteLine("--------------------------- Ex1 ---------------------------");
            Console.Write("Nhap N bat ky: ");
            string N = Console.ReadLine();
            if (N.GetType() == typeof(int))
            {
                Console.WriteLine("N is integer");
            }

            //if (N%2 > 0)
            //{
            //    Console.WriteLine("N is integer");
            //}

            //if (N is int)
            //{
            //    Console.WriteLine("N is integer");
            //}

            //if (N is int)
            //{
            //    Console.WriteLine("N is integer");
            //}
        }
        public static void Ex2()
        {
            Console.WriteLine("--------------------------- Ex2 ---------------------------");
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0} , b = {1}", a, b);
            int trungGian = a;
            a = b;
            b = trungGian;
            Console.WriteLine("After swap: a = {0}, b={1}", a, b);

            
        }
        public static void Ex3()
        {
            Console.WriteLine("--------------------------- Ex3 ---------------------------");
            int[] array = new int[4] { 3, 5, 2, 4 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Min = {0} , Max = {1}", min, max);
            Console.Write("ASC order");
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nDESC order");
            // Sort Array in DESC order
            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        public static void Ex4()
        {
            Console.WriteLine("--------------------------- Ex4 ---------------------------");
            Console.Write("Nhap ky tu: ");
            string kyTu = Console.ReadLine();
            if ("ueoai".Contains(kyTu))
            {
                Console.WriteLine("Ky tu la nguyen am");
            }
            else if (!"ueoai".Contains(kyTu))
            {
                Console.WriteLine("Ky tu la phu am");
            }
            else if (isNumeric(kyTu))
            {
                Console.WriteLine("Ky tu la ky tu so");
            }
            else
            {
                Console.WriteLine("Ky tu khac");
            }
        }
        public static void Ex5()
        {
            Console.WriteLine("--------------------------- Ex5 ---------------------------");
            Console.Write("Nhap thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                    break;
                case 2:
                    if (nam % 4 == 0)
                    {
                        if (nam % 100 == 0)

                        {
                            if (nam % 400 == 0)
                                Console.WriteLine("Thang {0} co 29 ngay", thang);
                            else
                                Console.WriteLine("Thang {0} co 28 ngay", thang);
                        }
                        else//chia het cho 4 nhung khong chi het 100 la nam nhuan
                            Console.WriteLine("Thang {0} co 29 ngay", thang);
                    }
                    else
                    {
                        Console.WriteLine("Thang {0} co 28 ngay", thang);
                    }
                    break;
                default:
                    Console.WriteLine("Thang {0} co 30 ngay", thang);
                    break;
            }
        }
        public static void Ex6()
        {
            Console.WriteLine("--------------------------- Ex6 ---------------------------");
            PhuongTrinhBac1();
            PhuongTrinhBac2();
        }
        
        public static bool isNumeric(String str)
        {
            try
            {
                Double.Parse(str);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

        public static void PhuongTrinhBac2()
        {
            int a, b, c;
            double x1, x2, delta;
            Console.Write(" Nhap vao so a: ");  a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao so b: ");  b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao so c: ");  c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chuong trinh ban vua nhap la {0}x^2 + {1}x + {2} = 0.", a, b, c);
            if (a == 0)
            {
               
                if (b == 0)
                {
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        Console.WriteLine(" Phuong trinh co vo so nghiem.");
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        Console.WriteLine(" Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    Console.WriteLine(" Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
            }else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine(" Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }
        }
        public static void PhuongTrinhBac1()
        {
            int a, b;
            double x;
            Console.Write("Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chuong trinh ban vua nhap la {0}x + {1} = 0.", a, b);
            
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                x = (double)-b / a;
                Console.WriteLine("Phuong trinh co nghiem x = {0}", Math.Round(x, 2));
            }

        }

        static void Ex7(int a, int b, int c)
        {
            Console.WriteLine("--------------------------- Ex7 ---------------------------");
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("\nTam giac khong hop le. Xin kiem tra lai !");
            }
            else
            {
                Console.WriteLine("\nDay la tam giac: ");
                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Deu");
                }
                else
                {
                    if (a * a + b * b == c * c || a * c + c * c == b * b || b * b + c * c == a * c)
                    {
                        Console.WriteLine("Vuong");
                    }
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Can");
                    }
                    else
                    {
                        Console.WriteLine("Thuong");
                    }
                }
            }
            
        }
    }
}