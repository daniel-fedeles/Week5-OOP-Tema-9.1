using Week5_OOP_Tema9._1_E2.Interfaces;

namespace Week5_OOP_Tema9._1_E2.Models
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex) : base(age, name, sex)
        {
        }

        public override string Sex { get; set; }
        public string Sound()
        {
            return "oac";
        }
    }
}
