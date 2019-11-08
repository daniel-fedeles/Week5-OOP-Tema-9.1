using Week5_OOP_Tema9._1_E2.Interfaces;

namespace Week5_OOP_Tema9._1_E2.Models
{
    public abstract class Cat : Animal, ISound
    {
        public Cat(int age, string name, string sex) : base(age, name, sex)
        {

        }

        public string Sound()
        {
            return "miau";
        }


    }
}
