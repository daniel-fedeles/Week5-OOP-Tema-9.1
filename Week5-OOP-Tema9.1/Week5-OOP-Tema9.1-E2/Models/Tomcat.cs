using Week5_OOP_Tema9._1_E2.Enums;

namespace Week5_OOP_Tema9._1_E2.Models
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex) : base(age, name, sex)
        {
            this.Sex = SexEnum.Male.ToString();
        }

        public override string Sex { get; set; }
    }
}
