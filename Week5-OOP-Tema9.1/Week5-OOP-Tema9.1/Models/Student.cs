using Week5_OOP_Tema9._1.Interfaces;

namespace Week5_OOP_Tema9._1.Models
{
    public class Student : BaseClass, IOptionals
    {
        public Classes Classes { get; set; }
        public void FreeText()
        {
            throw new System.NotImplementedException();
        }
    }
}
