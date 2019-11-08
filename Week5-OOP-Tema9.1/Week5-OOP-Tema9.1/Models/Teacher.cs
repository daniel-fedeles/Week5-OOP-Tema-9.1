using System.Collections.Generic;
using Week5_OOP_Tema9._1.Interfaces;

namespace Week5_OOP_Tema9._1.Models
{
    public class Teacher : BaseClass, IOptionals
    {
        public List<Discipline> Disciplineses { get; set; }
        public void FreeText()
        {
            throw new System.NotImplementedException();
        }
    }
}
