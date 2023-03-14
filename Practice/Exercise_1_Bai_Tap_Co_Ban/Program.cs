using System;
using System.Collections;
using System.Data;

namespace Exercise_1_Bai_Tap_Co_Ban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap 0");
            int value = 2021;
            Console.WriteLine("convert from 10-base into 2-base:" + Convert.ToString(value, 2));
            Console.WriteLine("convert from 10-base into 8-base:" + Convert.ToString(value, 8));
            Console.WriteLine("convert from 10-base into 16-base:" + Convert.ToString(value, 16).ToUpper());

            Console.WriteLine("\n\nBai tap 1");
            Console.WriteLine("Ngon ngu lap trinh C# - C Sharp");



            Console.WriteLine("\n\nBai tap 2");
            int n;
            n = 10;
            Console.Write(n +"+ 200 =");
            Console.Write((n + 200));




            Console.WriteLine("\n\nBai tap 3");

            Console.WriteLine("Hinh dang 1");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }



            Console.WriteLine("Hinh dang 2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j <= 5 - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }



            Console.WriteLine("Hinh dang 3");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 5 - 1 - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }




            Console.WriteLine("Hinh dang 4");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }



            Console.WriteLine("Hinh dang 5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j < 9 / 2 - i || j > 9 / 2 + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }



            Console.WriteLine("Hinh dang 6");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j >= 0 + i && j <= 9 - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }




            Console.WriteLine("Hinh dang 7");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j >= 0 + i && j <= 9 - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j < 9 / 2 - i || j > 9 / 2 + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }



            Console.WriteLine("Hinh dang 8");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i == 0 || i == 5 || j == 0 || j == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



            Console.WriteLine("\n\nBai tap 4");
            Console.Write("Nhap n de tach ky tu so: ");
            int nn;
            do
            {
                nn = Convert.ToInt32(Console.ReadLine());
            } while (0 > nn && nn < 1000);
            string result = "";
            for (int i = nn; i >= 1; i /= 10)
            {
                result = i % 10 +" " + result ;
            }
            Console.WriteLine("nn => {0}", result);



            Console.WriteLine("\n\nBai tap 5");
            Console.Write("Nhap diem lan 1: ");
            double firstScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem online: ");
            double onlScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem cuoi ky: ");
            double finalScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dierm tong ket cua ban la: {0}",0.25*firstScore + 0.25*onlScore + 0.5*finalScore);



            Console.WriteLine("\n\nBai tap 6");
            double c1, c2, canhHuyen;
            Console.Write("Nhap canh1: ");
            c1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap canh2: ");
            c2 = Convert.ToSingle(Console.ReadLine());
            canhHuyen = Math.Sqrt(c1 * c1 + c2 * c2);
            Console.WriteLine("Chu vi =" + (c1 + c2 + canhHuyen));
            Console.WriteLine("dien tich =" + (c1 * c2) / 2);


            Console.WriteLine("\n\nBai tap 7");
            double a, b, c;
            Console.Write("Nhap canh a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToSingle(Console.ReadLine());
            if (a >= b + c || b >= a + c || c >= a + b)
                Console.WriteLine("Ba canh vua nhap khong phai la canh cua tam giac");
            else
            {
                Console.WriteLine("Chu vi cua tam giac la: " + chuvi(a, b, c));
                Console.WriteLine("Dien tich cua tam giac la: " + dientich(a, b, c));
            }


            Console.WriteLine("\n\nBai tap 8");
            DataTable table = GetTable();
            Console.WriteLine("STT\t   Ma hoc sinh\t\tHo va Ten\t\tHS1\t\tHS2\t    Diem TBKT\t    Diem thi\t    DiemKTMH");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            foreach (DataRow row in table.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {
                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {
                    Console.Write (item+"\t|\t"); // In ra giá trị của ô với dòng và cột tương ứng
                }
                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------------------");
            }


        }
        public static double chuvi(double a, double b, double c)
        {
            return a + b + c;
        }
        public static double dientich(double a, double b, double c)
        {
            double p = chuvi(a, b, c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static DataTable GetTable()
        {
            IList<Student> list = new List<Student>();
            list.Add(new Student("HS001", "Nguyen Ngoc Anh", 8, 8, 8, 8, 8));
            list.Add(new Student("HS002", "Dang Ba Nam", 8, 9, 8.7, 8, 8.5));
            list.Add(new Student("HS003", "Le Duc Tu", 7, 6, 6.3, 9, 7.2));
            list.Add(new Student("HS004", "Mac van Vien", 7, 7, 7, 8, 7.3));
            list.Add(new Student("HS005", "Vu Dinh Toan", 9, 7, 8, 8, 8));
            list.Add(new Student("HS006", "Tran Ba Minh", 9, 10, 8.7, 10, 9.8));
            list.Add(new Student("HS007", "Ngo Dinh Tung", 8, 9, 8.7, 8, 8.5));
            list.Add(new Student("HS008", "Do Huu Nam", 7, 7, 7, 9, 7.7));

            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int)); 
            table.Columns.Add("MSSV", typeof(string)); 
            table.Columns.Add("Ho va Ten", typeof(string)); 
            table.Columns.Add("HS1", typeof(double));
            table.Columns.Add("HS2", typeof(double));
            table.Columns.Add("Diem TBKT", typeof(double));
            table.Columns.Add("Diem Thi", typeof(double));
            table.Columns.Add("Diem TBMH", typeof(double));
            
            int i = 1;
            foreach (var item in list)
            {
                table.Rows.Add(i, item.MaSSV, item.name, item.HS1, item.HS2,item.diemTBKT,item.diemThi,item.diemTBMH);
                i++;
            }
            return table;
        }
    }
}
    