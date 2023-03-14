using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Phan_Mang_So
{
    internal class NhanVien
    {
        string name, address;
        int age, workingHour;
        double salary ;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Age { get => age; set => age = value; }
        public int WorkingHour { get => workingHour; set => workingHour = value; }
        public string Address { get => address; set => address = value; }

        public NhanVien(string name, int age, string address,  double salary,  int workingHour)
        {
            this.name = name;
            this.salary = salary;
            this.age = age;
            this.workingHour = workingHour;
            this.address = address;
        }

        public NhanVien()
        {
        }

        public void inputInfor()
        {
            Console.Write("Nhap ten: ");  string ten = Console.ReadLine();
            Console.Write("Nhap tuoi: "); int tuoi = checkInt(18,100);
            Console.Write("Nhap dia chi: "); string diaChi = Console.ReadLine();
            Console.Write("Nhap luong: "); double luong = checkDouble(0,double.MaxValue);
            Console.Write("Nhap gio lam viec: "); int gioLamViec = checkInt(0, int.MaxValue);
            this.name = ten;
            this.salary = luong;
            this.age = tuoi;
            this.workingHour = gioLamViec;
            this.address = diaChi;
        }
        
        public void printInfor()
        {
            Console.WriteLine($"name: {name}, age: {age}, address: {address}, salary: {salary}, workingHour: {WorkingHour}");
        }

        public double tinhThuong()
        {
            double thuong = 0;
            if (workingHour>=200)
            {
                thuong = salary * 0.2;
            }else if (100 <= workingHour && workingHour<200)
            {
                thuong = salary * 0.1;
            }
            
            return thuong;
        }
        int checkInt(int min, int max)
        {

            int num = 0;
            do
            {

                try
                {

                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= min && num <= max) break;
                    Console.WriteLine("Out of range, please enter in range [" + min + ";" + max + "]");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number input, please enter again!");
                }
            } while (true);
            return num;
        }
        double checkDouble(double min, double max)
        {

            double num = 0;
            do
            {
                try
                {

                    num = Convert.ToSingle(Console.ReadLine());
                    if (num >= min && num <= max) break;
                    Console.WriteLine("Out of range, please enter in range [" + min + ";" + max + "]");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number input, please enter again!");
                }
            } while (true);
            return num;
        }

        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien("vuvu", 19, "HN", 50000, 200);
            nv.printInfor();
            Console.WriteLine("Thuong nv = "+ nv.tinhThuong());

            NhanVien nv1 = new NhanVien();
            nv1.inputInfor();
            Console.WriteLine("Thuong nv1 = " + nv1.tinhThuong());
            nv1.printInfor();
        }

    }


    
}
