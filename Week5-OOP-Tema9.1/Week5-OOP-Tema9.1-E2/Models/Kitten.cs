using Week5_OOP_Tema9._1_E2.Enums;

namespace Week5_OOP_Tema9._1_E2.Models
{
    class Kitten : Cat
    {
        public Kitten(int age, string name, string sex) : base(age, name, sex)
        {
            this.Sex = SexEnum.Female.ToString();
        }

        public override string Sex { get; set; }
    }
}
