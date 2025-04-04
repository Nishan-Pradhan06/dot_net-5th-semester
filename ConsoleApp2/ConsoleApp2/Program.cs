namespace ConsoleApp1
{
     public class Program
    {
        public static void Main(string[] args)
        {
            //WAP to input 3 numbers and disply the largest one
            Console.WriteLine("Enter first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdnumber = Convert.ToInt32(Console.ReadLine());

            if (firstnumber > secondnumber && firstnumber > thirdnumber)
            {
                Console.WriteLine(firstnumber + "is largest number.");
                Console.WriteLine($"{firstnumber} is the largest number.");
            }
            else if (secondnumber > thirdnumber)
            {
                Console.WriteLine($"{0} is the largest number", secondnumber, thirdnumber);
            }
            else
            {
                Console.WriteLine($"{thirdnumber} is the largest number");
            }
            Console.ReadKey();
        }
    }
}
