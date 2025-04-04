using System.Diagnostics.Metrics;

namespace OperatorOverLoadingTest
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            Distance d1 = new Distance(10, 23);
            Distance d2 = new Distance(5, 78);
            int x = 5;
            int y = 6;
            Distance d3 = d1 + d2;
            Console.WriteLine($"Distance is {d3.Meter} meter and {d3.Centimeter} centimeter");
            //Distance d3 = d1.Add(d2);
            Console.WriteLine($"x + y = {x + y}");  
            //Console.WriteLine(d1 + d2);

        }

        public class Distance
        {
            public int Meter { get; set; }
            public int Centimeter { get; set; }

            public Distance()
            {
                Meter = 0;
                Centimeter = 0;
            }
            public Distance(int m, int c)
            {
                Meter = m;
                Centimeter = c;
            }
            public void show() {
                Console.WriteLine($"My Distance is {Meter} meter and {Centimeter} centimeter");
            }
            public Distance Add(Distance d)
            {
                Distance d3 = new Distance(this.Meter+d.Meter+( this.Centimeter+d.Centimeter)/100,(this.Centimeter+d.Meter)%100);
                return d3;
            }
            public static Distance operator +(Distance d1, Distance d2)
            {
                Distance d3 = new Distance(d1.Meter + d2.Meter + (d1.Centimeter + d2.Centimeter) / 100, (d1.Centimeter + d2.Centimeter) % 100);
                return d3;
            }
            public static Distance operator -(Distance d)
            {
                return new Distance(-d.Meter, -d.Centimeter);
            }

        }
      
    }
}
