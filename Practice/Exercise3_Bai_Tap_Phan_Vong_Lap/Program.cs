using System.Collections;

namespace Exercise3_Bai_Tap_Phan_Vong_Lap
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7();
            Ex8();
            Ex9();
            Ex10();
            Ex11();
            Ex12();
            Ex13();
            Ex14();
            Ex15();
            Ex16();
        }
        public static void Ex1()
        {
            Console.WriteLine("------------------------- Ex1 ------------------------");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n \n");
        }
        public static void Ex2()
        {
            Console.WriteLine("------------------------- Ex2 ------------------------");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\n \n");
        }
        public static void Ex3()
        {
            Console.WriteLine("------------------------- Ex3 ------------------------");
            for (int i = 99; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\n \n");
        }
        public static void Ex4()
        {
            Console.WriteLine("------------------------- Ex4 ------------------------");
            for (int i = 99; i > 0; i--)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\n \n");
        }
        public static void Ex5()
        {
            Console.WriteLine("------------------------- Ex5 ------------------------");
            int resultB5 = 0;
            for (int i = 1; i <= 50; i++)
            {
                Console.Write(i);
                if (i < 50)
                {
                    Console.Write(" + ");
                }
                resultB5 += i;
            }
            Console.Write(" = {0}", resultB5);
            Console.WriteLine("\n \n");
        }
        public static void Ex6()
        {
            Console.WriteLine("------------------------- Ex6 ------------------------");
            int resultB6 = 0;
            for (int i = 50; i > 0; i--)
            {
                if (i > 1)
                {
                    Console.Write(" + ");
                }
                Console.Write(i);
                resultB6 += i;
            }
            Console.Write(" = {0}", resultB6);
            Console.WriteLine("\n \n");
        }
        public static void Ex7()
        {
            Console.WriteLine("------------------------- Ex7 ------------------------");
            int resultB7 = 0;
            for (int i = 50; i > 0; i--)
            {
                if (i % 2 == 0 && i.ToString().StartsWith("2"))
                {
                    Console.Write(i + " + ");
                    resultB7 += i;
                }
            }
            Console.Write(" = {0}", resultB7);
            Console.WriteLine("\n \n");
        }
        public static void Ex8()
        {
            Console.WriteLine("------------------------- Ex8 ------------------------");
            int resultB8 = 0;
            for (int i = 5; i <= 100; i += 5)
            {
                Console.Write(i + " + ");
                resultB8 += i;
            }
            Console.Write(" = {0}", resultB8);
            Console.WriteLine("\n \n");
        }
        public static void Ex9()
        {
            Console.WriteLine("------------------------- Ex9 ------------------------");
            Console.Write("Nhap n de tinh n!: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultB9 = 1;
            Console.Write("{0}! = ", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " * ");
                resultB9 *= i;
            }
            Console.Write(" = {0}", resultB9);
            Console.WriteLine("\n \n");
        }
        public static void Ex10()
        {
            Console.WriteLine("------------------------- Ex10 ------------------------");
            Console.Write("Nhap N de check so nguyen to : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int countN = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    countN++;
                }
            }
            if (countN == 2)
            {
                Console.WriteLine("{0} la so nguyen to", N);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to", N);
            }
        }
        public static void Ex11()
        {
            Console.WriteLine("------------------------- Ex11 ------------------------");
            Console.Write("Nhap N de check so hoan hao = ");
            int M = Convert.ToInt32(Console.ReadLine());
            int countM = 0;
            for (int i = 1; i < M; i++)
            {
                if (M % i == 0)
                {
                    countM+=i;
                }
            }
            Console.WriteLine(countM);
            if (countM == M)
            {
                Console.WriteLine("{0} la so hoan hao", M);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so hoan hao", M);
            }
        }
        public static void Ex12()
        {
            Console.WriteLine("------------------------- Ex12 ------------------------");
            Console.Write("First 10 Fibonaci");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine("\n13th Fibonaci = {0}", Fibonacci(13));
        }
        public static void Ex13()
        {
            Console.WriteLine("------------------------- Ex13 ------------------------");
            Console.Write("Nhap so N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            string M = N.ToString();
            Console.WriteLine("{0} co {1} chu so",N,M.Length);
            
            List<int> listt = new List<int>();
            for (int i = N;  i>0; i/=10)
            {
                listt.Add(i%10);
            }
            int tongChuSo = 0;
            int max = listt[0];
            foreach (var item in listt)
            {
                tongChuSo += item;
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine("Sum = {0} , Max = {1}", tongChuSo, max);
        }

        public static void Ex14()
        {
            Console.WriteLine("------------------------- Ex14 ------------------------");
            Console.WriteLine("Day so N 12348587356293657256454768");
            long N = 123485873562;
            Console.Write("Nhap vi tri n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chu so thu n co gia tri la: {0}", N.ToString()[n]);
        }

        static void Ex15()
        {
            Console.WriteLine("------------------------- Ex15 ------------------------");
            Console.Write("Nhap N de phan tich so nguyen to= ");
            int N = Convert.ToInt32(Console.ReadLine()); int N1 = N;
            int i = 2;
            int dem = 0;
            int[] a = new int[100];
            // phan tich
            while (N > 1)
            {
                if (N % i == 0)
                {
                    N = N / i;
                    a[dem++] = i;
                }
                else
                {
                    i++;
                }
            } 
            if (dem == 0)
            {
                a[dem++] = N;
            }
            Console.Write("{0} = ",N1);
            for (i = 0; i < dem - 1; i++)
            {
                Console.Write("{0} x ", a[i]);
            }
            Console.Write("{0}", a[dem - 1]);
            Console.WriteLine("\n \n");
        }

        public static void Ex16()
        {
            Console.WriteLine("------------------------- Ex16 ------------------------");
            int A, B;
            do
            {
                Console.Write("A = ");  A = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");  B = Convert.ToInt32(Console.ReadLine());
            } while (A>B || A<=0 || B>=100);
            Console.Write("So nguyen to tu A den B: ");
            for (int i = A; i <= B; i++)
            {
                if (CheckSoNguyenTo(i))
                {
                    Console.Write("{0} ,",i);
                }
            }
            Console.WriteLine("\nUoc so chung lon nhat cua A va B : {0}",USCLN(A,B));
        }
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }
        public static bool CheckSoNguyenTo(int N)
        {
            int countN = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    countN++;
                }
            }
            if (countN == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Fibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return (Fibonacci(num - 1) + Fibonacci(num - 2));
        }
    }
}