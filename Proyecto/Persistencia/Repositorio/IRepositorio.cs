using Proyecto.Dominio;
namespace Proyecto.Persistencia
{
    public interface IRepositorio
    {
        //Estudiante
        IEnumerable<Estudiante> GetAllEstudiantes(); //Me sirve luego para consultar todos los estudiantes
        Estudiante AddEstudiante(Estudiante estudiante); //Creación de estudiantes
        Estudiante UpdateEstudiante(Estudiante estudiante); //Actualizar estudiante
        void DeleteEstudiante(int estudianteId); //Eliminar estudiante
        Estudiante GetEstudiante(int estudianteId); //Consultar un estudiante

        // Instructor
        IEnumerable<Instructor> GetAllInstructores();
        Instructor AddInstructor(Instructor instructor);
        Instructor UpdateInstructor(Instructor instructor);
        void DeleteInstructor(int instructorId);
        Instructor GetInstructor(int instructorId);

        // Materia
        IEnumerable<Materia> GetAllMaterias();
        Materia AddMateria(Materia materia);
        Materia UpdateMateria(Materia materia);
        void DeleteMateria(int materiaId);
        Materia GetMateria(int materiaId);

        // Inscripcion
        IEnumerable<Inscripcion> GetAllInscripciones();
        Inscripcion AddInscripcion(Inscripcion inscripcion);
        Inscripcion UpdateInscripcion(Inscripcion inscripcion);
        void DeleteInscripcion(int inscripcionId);
        Inscripcion GetInscripcion(int inscripcionId);

        // Curso
        IEnumerable<Curso> GetAllCursos();
        Curso AddCurso(Curso curso);
        Curso UpdateCurso(Curso curso);
        void DeleteCurso(int cursoId);
        Curso GetCurso(int cursoId);
    }
}
