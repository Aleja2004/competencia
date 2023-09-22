using System;
using System.Collections.Generic;

namespace Proyecto.Dominio
{
    public class Instructor:Persona
    {
        public List<Materia> Materia {get;set;}
        public int Id { get; set; }
        public string Rol { get; set; }
        public string Codigo { get; set; }
    }
}