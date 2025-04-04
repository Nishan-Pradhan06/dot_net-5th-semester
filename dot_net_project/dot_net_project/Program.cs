using System;
namespace dot_net_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String? name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", How are you!!!");


            //dim age Integer
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + ", you are " + Convert.ToString(age) + " years old.");

            Console.WriteLine($"Hello {name}, you are {age} years old.");

        }
    }
}