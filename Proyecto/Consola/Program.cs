// See https://aka.ms/new-console-template for more information
using Proyecto.Persistencia;
using Proyecto.Dominio;
namespace Proyecto.Consola{

public class Program{


private static IRepositorio _repo=new Repositorio(new AppContextS());


static void Main(string[]args)
{
    Console.WriteLine("Hello, World!");
    
    //Esto es para agregar un estudiante
    AddEstudiante();

    /*Esto es para agregar un instructor
    AddInstructor();

    // Esto es para agregar una materia
    AddMateria();

    // Esto es para agregar una inscripción
    AddInscripcion();

    // Esto es para agregar un curso
    AddCurso();*/
}


 static void AddEstudiante()
 {
    var Estudiante = new Estudiante
    {
        Nombre= "Pedro",
        Apellido="Garcia",
        Edad=25,
        Correo="pepito@gamil.com",
        FechaNacimiento=new DateTime(1993,04,15)
    };
   _repo.AddEstudiante(Estudiante);
    Console.WriteLine($"Estudiante agregado");
}
}
}