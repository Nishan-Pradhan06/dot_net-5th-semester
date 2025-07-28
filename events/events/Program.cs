namespace events
{
    public class Person
    {
        private string name = null;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {
            Name = "Unknown";
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Nishan Pradhan";
            Console.WriteLine("Name:" + person.Name);
        }
    }
}
