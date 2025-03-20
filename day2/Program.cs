namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
           string myStr = Convert.ToString(Console.ReadLine())??string.Empty;
            Console.WriteLine("Reversed String is: " + ReverseString(myStr));

        }

        public static string ReverseString( String str)
        {
            string rev = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];

            }
            return rev;
        }
    }
}
