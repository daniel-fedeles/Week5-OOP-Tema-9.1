using System;

namespace Week5_OOP_Tema9._1_E3.Models
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\t WeekSalary: {this.WeekSalary}  WorkHoursPerDay: {this.WorkHoursPerDay}  S/h: {this.MoneyPerHour():0.00}");
        }
    }
}
