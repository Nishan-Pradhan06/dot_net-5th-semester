﻿namespace TestWebAppDotNet.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; }= null!;
        public DateOnly JoinDate { get; set; }
    }
}
