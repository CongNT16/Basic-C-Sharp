using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module4
{
    class Animal
    {
        int id;
        string name,gender;
        float weigth;

        public Animal()
        {
            this.id = 0;
            this.name = "cho";
            this.gender = "male";
            this.weigth= 12;
        }

        public override string? ToString()
        {
            return id + " " + name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public float Weigth { get => weigth; set => weigth = value; }
    }
    internal class Collectionss
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            AL.Add(1);
            AL.Add("C#");
            AL.Add(12.5f);
            AL.Insert(1, true);
            AL.Add(new Animal());
            foreach (var item in AL)
            {
                Console.WriteLine(item);
            }

            List<Animal> list= new List<Animal>(); 
            list.Add(new Animal());



        }
        
    }
}
