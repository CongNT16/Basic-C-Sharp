using System;
using System.Collections.Generic;
using System.Text;

namespace Module1
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int a = 100;
            float b = 1234.567F;
            Console.WriteLine($"a = {a:D10} b = {b:F2}  b = {b:0.00}  b = {b:0,0.00} b = {b,-10:0,0.00}");

            //Pép toán số học
            // Phép toán so sánh
            //Phép toán logic
            //Phép toán logic nhị phân : & | ^ ~
            //~A = -(A+1)
            int A = -10;
            Console.WriteLine(~A);
            float diem = 7.9f;
            if (diem >= 9 && diem <= 10)
            {
                Console.WriteLine("Xuat Sac");
            }
            else if (diem >= 8f && diem < 9f)
            {
                Console.WriteLine("Gioi");
            }
            else if (diem >= 5 && diem < 6.5f)
            {
                Console.WriteLine("Kha");
            }
            else if (diem >= 0 && diem < 5)
            {
                Console.WriteLine("Retake");
            }
            else
            {
                Console.WriteLine();
            }

            int month = 10;
            switch (month)
            {
                case 1: case 2: case 3: Console.WriteLine("Quarter 1"); break;
                case 4: case 5: case 6: Console.WriteLine("Quarter 2"); break;
                case 7: case 8: case 9: Console.WriteLine("Quarter 3"); break;
                case 10: case 11: case 12: Console.WriteLine("Quarter 4"); break;
                default:
                    Console.WriteLine("Wrong month");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }Console.WriteLine(Environment.NewLine);

            int count = 1;
            while (count <= 10)
            {
                Console.Write(count++ + " ");
            }Console.WriteLine(Environment.NewLine);

            do
            {
                Console.Write(--count + " ");
            } while (count >= 1);
        }
    }
}
