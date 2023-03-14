namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoParams();
            


        }
        public static void Mang1chieu()
        {
            int[] a = new int[5];
            float[] b; b = new float[5];
            double[] c = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Input data for c aray :");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"c[{i}] = ");
                c[i] = Convert.ToSingle(Console.ReadLine());

            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            Console.WriteLine($"Max = {c.Max()}");
            Console.WriteLine($"Min = {c.Min()}");
            Console.WriteLine($"Sum = {c.Sum()}");
            Console.WriteLine($"Average = {c.Average()}");

            Console.WriteLine("Sort");
            Array.Sort(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
            Array.Reverse(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

        }
        public static void Mang2chieu()
        {
            int[,] d = new int[2, 3];
            float[,] e; e = new float[2, 3];
            double[,] f = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Input data of array :");
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    Console.Write($"d[{i},{j}] = ");
                    d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("hien thi");
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    Console.Write($" {d[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
        public static void MangRangCua()
        {
            //jagged
            int[][] a = new int[2][];
            a[0] = new int[3] { 1, 3, 2 };
            a[1] = new int[5] { 5, 6, 7, 8, 9 };

            int rows;
            do
            {
                Console.Write("Input rows: ");
                rows = Convert.ToInt32(Console.ReadLine());
            } while (rows < 2);
            a = new int[rows][];
            int columns;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                do
                {
                    Console.WriteLine($"input columns for row {i}: ");
                    columns = Convert.ToInt32(Console.ReadLine());
                    
                } while (rows < 2);
                a[i] = new int[columns];
                Console.WriteLine($"Input data for row {i}:");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"a[{i}][{j}]= ");
                    a[i][j]= Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Show data ");
            foreach (var item in a)
            {
                foreach (var item1 in item)
                {
                    Console.Write($"{item1,5}\n");
                }
            }

        }
        public static void DemoParams()
        {
            //params dung trong tinh huong true=yen di mot list cac du lieu cung mau nhunwg khong muons khai bao nhieu tham so
            int a = 10;
            int[] b = new int[] { 1,2,3,4,5,6};
            Console.WriteLine(Sum(a, 1, 2, 3, 4, 5, 6, 7, 8));
            Console.WriteLine(Sum(a, b));


        }
        static long Sum(int a, params int[] b) => a + b.Sum();
        
        
        static void DemoFunc() => Console.WriteLine("This is the first function");
        static int DemoLambra(int a, int b) =>  a+b;
    }
}