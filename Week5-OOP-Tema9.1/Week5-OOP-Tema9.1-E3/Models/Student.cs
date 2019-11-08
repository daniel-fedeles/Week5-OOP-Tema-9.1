using System;

namespace Week5_OOP_Tema9._1_E3.Models
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\tGrade: {this.Grade}");
        }
    }
}
