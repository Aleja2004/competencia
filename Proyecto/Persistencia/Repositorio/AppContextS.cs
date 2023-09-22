using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    public class AppContextS : DbContext
    {
        //Es un objeto que le pertenece al context que me permite modelar la base de datos

        //<Persona> es el nombre de la tabla que tengo en dominio
        //Personas= es el nuevo nombre que va a tener mi tabla en la base de datos

        public DbSet<Persona> Personas {get;set;}
        public DbSet<Instructor> Instructor{get;set;}
        public DbSet<Materia> Materias{get;set;}
        public DbSet<Estudiante> Estudiantes {get;set;}
        public DbSet<Inscripcion>Inscripciones {get;set;}
        public DbSet<Curso> Cursos {get;set;}

    // el void es un metodo vacío que sirve para la conexion a la base de datos.
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=AppS");
            }

        }

    }

}