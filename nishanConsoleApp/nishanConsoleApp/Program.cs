using System.Runtime.CompilerServices;

namespace nishanConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculation
    {
        public static void Display(string userName, int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Hello{userName}, your sum is:{firstNumber +secondNumber}");
        }
    }
}
