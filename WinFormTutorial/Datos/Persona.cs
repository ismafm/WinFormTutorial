using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormTutorial.Modelo;

namespace WinFormTutorial.Datos
{
    internal class Persona
    {
        public List<PersonaModel> PersonaModel {  get; set; } = new List<PersonaModel>();

        public void AddPersona(string name, int age)
        {
            var persona = new PersonaModel(name, age);
            this.PersonaModel.Add(persona);
        }
        public string[] GetPersonaList()
        {
            return this.PersonaModel.Select(pm => $"{pm.Name}, {pm.Age}").ToArray();
        }
    }
}
