namespace DelegetTest
{
    public delegate void MyDelegate(int x, int y);//step-1:Define delegate
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = 20, second = 30;
            Calculation c = new Calculation();//calling non static number: obj.MemberName
            /*c.Add(first, second);
            Calculation.Sub(first, second);//calling static number: ClassName.MemberName
            Calculation.Mul(first, second);*/
            MyDelegate del = new MyDelegate(c.Add);
            del += c.Sub;
            del += c.Mul;
            del(first, second);//Step 3 call methods using delegate object

            Console.WriteLine("Call Again!");

            del -= c.Sub;
            del.Invoke(first, second);

        }
    }
    public class Calculation
    {
        public void Add(int x, int y)

        {
            Console.WriteLine($"Sum of{x} and {y} is{x + y}.");
        }
        public void Sub(int x, int y)

        {
            Console.WriteLine($"Sub of{x} and {y} is{x - y}.");
        }
        public void Mul(int x, int y)

        {
            Console.WriteLine($"Mul of{x} and {y} is{x * y}.");
        }

    }
}
