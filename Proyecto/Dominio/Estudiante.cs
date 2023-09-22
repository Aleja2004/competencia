using System;

namespace Proyecto.Dominio
{
    public class Estudiante:Persona
    {
        public List<Materia> Materia {get;set;}
        public Inscripcion Inscripcion {get;set;}
        public Curso Curso {get;set;}
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}