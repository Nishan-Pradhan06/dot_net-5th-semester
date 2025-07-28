namespace customExceptionEg
{
    public class MyException :Exception
    {
        public MyException(string message): base(message)
        {
        }
    }

    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Rate { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal NetPrice { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //write a program to inout sales details of products.
            //The program should handle discount overflow(Discount amount Exceeds TotalPrice) as custom exception
            List<Product> list = [];
            char choice;
            do
            {
                Product p = new Product();
                Console.WriteLine("Product Name");
                p.Name = Convert.ToString(Console.ReadLine())??string.Empty;
                Console.WriteLine("Repeat next?" z);
            } while(choice == 'y'||choice == 'Y');

            Console.WriteLine("Hello, World!");
        }
    }
}
