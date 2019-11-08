using System;

namespace Week5_OOP_Tema9._1_E3.Models
{
    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Human: {FirstName}, {LastName}");
        }
    }
}
