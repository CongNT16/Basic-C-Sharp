using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Phan_Mang_So
{
    internal class SoNguyenTo
    {
        int a;

        public SoNguyenTo()
        {
        }

        public SoNguyenTo(int x)
        {
            if (isSoNguyenTo(x)) {
                this.a = x;
            }
            else
            {
                Console.WriteLine(x+" khong phai la so nguyen to, khong luu tru");
            }
        }

        public int A {
            get => a; 
            
             set {
                if (isSoNguyenTo(value))
                {
                    Console.WriteLine("set " + value);
                    a =value;
                }
                else
                {
                    Console.WriteLine("khong set "+value);
                }
             }
            
         }

        public bool isSoNguyenTo(int x)
        {
            int count= 0;
            for (int i = 1; i <= x; i++)
            {
                if (x%i==0)
                {
                    count++;
                }
            }
            return count == 2 ? true : false;
        }

        public int timSoNguyenToTiepTheo()
        {
            int nextNum = a + 1 ;
            bool isFound = false;
            do
            {
                if (isSoNguyenTo(nextNum)==false)
                {
                    nextNum += 1;
                    
                }
                else
                {
                    isFound = true;
                }
            } while (isFound==false);
            return nextNum;
        }

        static void Main(string[] args)
        {
            SoNguyenTo snt = new SoNguyenTo(3);
            SoNguyenTo snt1 = new SoNguyenTo(4);
            snt.A = 6;
            snt1.A = 2;
            Console.WriteLine("7 la so nguyen to: "+ snt.isSoNguyenTo(7));
            Console.WriteLine($"SNT sau {snt.A}: " +snt.timSoNguyenToTiepTheo());
        }
    }
}
