using System;
using System.Collections.Generic;
using Week5_OOP_Tema9._1.Interfaces;

namespace Week5_OOP_Tema9._1.Models
{
    public class Classes : IOptionals
    {
        private Guid _guid;

        public Guid Guid
        {
            get => _guid;
            set => _guid = Guid.NewGuid();
        }

        public List<Teacher> Teachers { get; set; }
        public void FreeText()
        {
            throw new NotImplementedException();
        }
    }
}
