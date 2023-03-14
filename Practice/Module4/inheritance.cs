using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Animal2 {
        int id;
        string name, gender;
        float weigth;

        public Animal2(int id, string name, string gender, float weigth)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.weigth = weigth;
        }

        public override string? ToString()
        {
            return id + " " + name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public float Weigth { get => weigth; set => weigth = value; }

        public void InputInfor()
        {
            Console.Write("input id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("inout name: ");
            name =Console.ReadLine();
            Console.Write("input weight: ");
            weigth = Convert.ToSingle(Console.ReadLine());
            Console.Write("inout gender: ");
            gender = Console.ReadLine();
        }


    }

    class Dog : Animal2
    {
        string color;

        public Dog(string color, int id, string name, string gender, float weigth) :base( id, name, gender, weigth)
        {
            this.color = color;
        }

        public string Color { get => color; set => color = value; }

        public new void InputInfor()
        {
            base.InputInfor();
            Console.Write("input color: ");
            color = Console.ReadLine();
        }
    }

    internal class inheritance
    {
        static void Main(string[] args)
        {

        }
    }
}
