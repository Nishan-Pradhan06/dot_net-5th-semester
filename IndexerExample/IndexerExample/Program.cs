namespace IndexerExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Phone { get; set; }
        public DateOnly Joindate { get; set; }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Phone;
                else if (index == 3)
                    return Joindate;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);
                else if (index == 1)
                    Name = Convert.ToString(value) ?? string.Empty;
                else if (index == 2)
                    Phone = Convert.ToString(value);
                else if (index == 3)
                {
                    string? sdt = Convert.ToString(value);
                    DateOnly.TryParse(sdt, out DateOnly dt);
                    Joindate = dt;
                }
            }
        }
        public object? this[string index]
        {
            get
            {
                if (index == "id")
                    return Id;
                if (index == "Name")
                    return Name;
                if (index == "Phone")
                    return Phone;
                if (index == "Joindate")
                    return Joindate;
                else
                    return null;
            }
            set
            {
                if (index == "Id")
                    Id = Convert.ToInt32(value);
                else if (index == "Name")
                    Name = Convert.ToString(value) ?? string.Empty;
                else if (index == "Phone")
                    Phone = Convert.ToString(value);
                else if (index == "Joindate")
                {
                    string? sdt = Convert.ToString(value);
                    DateOnly.TryParse(sdt, out DateOnly dt);
                    Joindate = dt;
                }
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Life without Indexer:");
            Student s = new Student();
            //s.Id = 101;
            s["Id"] = 101;
            s[1] = "Gopal Mainali";
            s[2] = "984643732";
            s[3] = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"ID: {s[0]}\nName: {s["Name"]}\nPhone: {s[2]}\nJoin Date:{s[3]}");
        }
    }
}
    