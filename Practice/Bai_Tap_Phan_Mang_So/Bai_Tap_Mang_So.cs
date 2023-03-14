namespace Bai_Tap_Phan_Mang_So
{
    internal class Bai_Tap_Mang_So
    {
        static int N;
        static int[] array;
        static double average;
        static void Main(string[] args)
        {
            Console.WriteLine("1.Nhap N\n2.Nhap mang N phan tu\n3.Tim max\n4.Tim Min\n5.Tim so duong chan lon nhat\n6.Tim so am le nho nhat");
            Console.WriteLine("7.Tim so chinh phuong\n8.Tinh tong mang\n9.Tinh trung binh cong\n10.Tim so lon hon TB cong");
            Console.WriteLine("11.Sap xep tang\n12.Sap xep giam\n13.Tim TB cong phan tu khong am");
            int selection;
            do
            {
                Console.Write("\nChon menu: ");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:  Ex1(); break;
                    case 2: Ex2(); break;
                    case 3: Ex3(); break;
                    case 4: Ex4(); break;
                    case 5: Ex5(); break;
                    case 6: Ex6(); break;
                    case 7: Ex7(); break;
                    case 8: Ex8(); break;
                    case 9: Ex9(); break;
                    case 10: Ex10(); break;
                    case 11: Ex11(); break;
                    case 12: Ex12(); break;
                    case 13: Ex13(); break;

                    default:
                        break;
                }
            } while (selection!=0);
            

            
            
        }
        public static void Ex1()
        {
            do
            {
                Console.Write("Nhap so nguyen N: "); 
                N = Convert.ToInt32(Console.ReadLine());
            } while (0>N || N>50);
            Console.WriteLine("N = {0}",N);
              

        }
        public static void Ex2()
        {
            array = new int[N];
            Console.WriteLine("Nhap mang {0} phan tu:",N);
            for (int i = 0; i < N; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static void Ex3()
        {
            Console.WriteLine($"Max = {array.Max()}");
        }
        public static void Ex4()
        {
            Console.WriteLine($"Min = {array.Min()}");
        }
        public static void Ex5()
        {
            int posEvenMax;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i]%2==0)
                {
                    posEvenMax = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 0 && array[j] > posEvenMax && array[j] > 0)
                        {
                            posEvenMax = array[j];
                        }
                    }
                    Console.WriteLine($"So duong chan lon nhat: {posEvenMax}");
                    break;
                }
                else if (array[i] < 0 && i == N - 1)
                {
                    Console.WriteLine("There are no Pos Even number");
                }
            }
        }
        public static void Ex6()
        {
            int negOddMin ;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0 && array[i] %2 !=0)
                {
                    negOddMin = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] % 2 != 0 && array[j] < negOddMin && array[j] < 0)
                        {
                            negOddMin = array[j];
                        }
                    }
                    Console.WriteLine($"So am le nho nhat: {negOddMin}");
                    break;
                }else if (array[i] > 0 && i==N-1)
                {
                    Console.WriteLine("There are no Neg Odd number");
                }
            }
            
        }
        public static void Ex7()
        {
            Console.Write("So chinh phuong trong mang: ");
            for (int i = 0; i < array.Length; i++)
            {
                int n =(int)Math.Sqrt(array[i]);
                if (Math.Pow(n, 2) == array[i])
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine();
            
        }
        public static void Ex8()
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
            }
            Console.WriteLine($"Sum: {Sum}");
        }
        public static void Ex9()
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
            }average = (double)Sum / N;
            Console.WriteLine($"average: {average}");
        }
        public static void Ex10()
        {
            Console.Write("So lon hon average: ");
            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] > average)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine();
        }
        public static void Ex11()
        {
            Array.Sort(array);
            Console.Write("Mang tang dan: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void Ex12()
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.Write("Mang giam dan: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void Ex13()
        {
            int Sum = 0; int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0)
                {
                    count++;
                    Sum += array[i];
                }
            }
            average = (double)Sum / count;
            Console.WriteLine($"nonNegAverage: {average}");
        }


    }
}