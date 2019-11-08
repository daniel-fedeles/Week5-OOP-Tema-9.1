namespace Week5_OOP_Tema9._1_E2.Models
{
    public abstract class Animal
    {
        protected Animal(int age, string name, string sex)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract string Sex { get; set; }

    }
}

