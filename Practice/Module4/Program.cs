namespace Module4
{
    class calculate
    {
        public long Addition(int a, int b)  => a + b;
        public long Addition(int a, int b,int c) => a + b + c;
        public double Addition(float a, float b) => a + b;

    }
    class product
    {
        int id;
        string name;
        float price;
        int[] rate;
        string[] comment;
        int[,] tag;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int[] Rate { get => rate; set => rate = value; }
        public string[] Comment { get => comment; set => comment = value; }
        public int[,] Tag { get => tag; set => tag = value; }

        public int this[int index]
        {
            get => rate[index];
            set=> rate[index] = value;
        }

        public string this[float index]
        {
            get => comment[(int)index];
            set => comment[(int)index] = value;
        }

        public int this[int i, int j]
        {
            get => tag[i,j];
            set => tag[i,j] = value;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //indexer: áp dụng cho các trường dạng mảng trong đó một đối tượng có theer truy xuất đến các trường dạng
            //mảng của đối tượng đó thông qua chính bản thân nó, sử dụng pp lập địa chỉ mục cho phép dl của trương mảng.
            //giúp cho câu lệnh ngắn gọn hơn , tốc độ truy xuất nhanh hơn
            product p = new product();
            p.Rate = new int[5];
            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;
            p[4] = 5;
            for (int i = 0; i < p.Rate.Length; i++)
            {
                Console.Write(p[i] + " ");
            }
            p.Comment = new string[3];
            p[0.0f] = "vuvu";
            p[1.0f] = "vuvuvu";
            p[2.0f] = "vuvuvuvu";
            for (float i = 0; i < p.Comment.Length; i++)
            {
                Console.Write(p[i] + " ");
            }


        }
    }
}