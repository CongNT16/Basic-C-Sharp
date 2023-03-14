namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.ID = 1;
            Console.WriteLine("ID: {0}",cat.ID);
        }
    }

    internal class Animal 
    {
        //attribute / field
        int id; string name;
        float weight;
        string gender;

        public Animal()
        {
            id = 123;
            name = "Test";
            gender= "B";
            weight = 65f;

        }
        public Animal(int id , string name , float weight , string gender)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.gender = gender;

        }

        public Animal(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        //properties
        public int ID { get { return id; } set => id = value;  }
        

        void move()
        {
            Console.WriteLine("run");
        }
        void speak()
        {
            Console.WriteLine("roar");
        }

    }

}