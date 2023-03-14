using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Bai_Tap_Co_Ban
{
    public class Student
    {
        public static int soThuTu=0;
        public string name, MaSSV;
        public double HS1, HS2, diemTBKT, diemThi, diemTBMH;

        
        public Student(string MaSoSV, string Name, double HeS1 , double HeS2, double DiemTBKT, double DiemThi, double DiemTBMH)
        {
            soThuTu ++;
            MaSSV = MaSoSV;
            name = Name;
            HS1 = HeS1;
            HS2 = HeS2;
            diemTBKT= DiemTBKT;
            diemThi = DiemThi;
            diemTBMH = DiemTBMH;

        }

        

    }
}
