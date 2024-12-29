﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTutorial.Modelo
{
    internal class PersonaModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonaModel(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
