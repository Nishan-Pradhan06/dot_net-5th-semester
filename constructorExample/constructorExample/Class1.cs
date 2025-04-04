using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorExample
{
    public class Student
    {
        private int roll;
        private string? name;
        private int age;

        public Student()
        {
            roll = 1;
            name = "unknown";
            age = 21;


         
        }
        public Student(int roll, string? name)
        {
            this.roll = roll;
            this.name = name;
            this.age = 0;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
}

