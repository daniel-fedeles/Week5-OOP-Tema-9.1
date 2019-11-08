using System.Collections.Generic;
using System.Linq;
using Week5_OOP_Tema9._1_E3.Models;

namespace Week5_OOP_Tema9._1_E3
{
    class Program
    {
        static void Main(string[] args)
        {

            var student1 = new Student("Gigica", "gte", 9.9);
            var student2 = new Student("bibica", "efw", 9.9);
            var student3 = new Student("ddd", "fe", 9.9);
            var student4 = new Student("rrr", "Kent", 9.9);
            var student5 = new Student("yyy", "wefwe", 9.9);
            var student6 = new Student("erere", "ge", 9.9);
            var student7 = new Student("Gigi", "Kegtrgnt", 9.9);
            var student8 = new Student("Grerrg", "dfvf", 9.9);
            var student9 = new Student("Ggrf", "fd", 9.9);
            var student10 = new Student("Gigi", "frfr", 9.9);


            var students = new List<Student> {
                student1, student2, student3, student4,
                student5, student6, student7, student8,
                student9,  student10};

            students = students.OrderBy(x => x.Grade).ToList();

            var worker1 = new Worker("nume", "Alt", 1060, 8);
            var worker2 = new Worker("nume", "Alt", 1060, 8);
            var worker3 = new Worker("nume", "Alt", 1060, 8);
            var worker4 = new Worker("nume", "Alt", 1060, 8);
            var worker5 = new Worker("nume", "Alt", 1060, 8);
            var worker6 = new Worker("nume", "Alt", 1060, 8);
            var worker7 = new Worker("nume", "Alt", 1060, 8);
            var worker8 = new Worker("nume", "Alt", 1060, 8);
            var worker9 = new Worker("nume", "Alt", 1060, 8);
            var worker10 = new Worker("nume", "Alt", 1060, 8);

            var workers = new List<Worker> { worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10 };

            workers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            var swList = new List<Human>();
            foreach (var student in students)
            {
                swList.Add(student);
            }

            foreach (var worker in workers)
            {
                swList.Add(worker);
            }

            swList = swList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName).ToList();

            foreach (var human in swList)
            {
                human.Print();
            }
        }

    }
}
