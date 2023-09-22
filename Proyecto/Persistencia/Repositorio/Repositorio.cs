using System.Linq;//Me permite hacer consultas con una sintaxis mas sencilla 
using System.Collections.Generic;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    public class Repositorio: IRepositorio
    {
        private readonly AppContextS _appContextS;
        public Repositorio (AppContextS appContextS)
        {
            _appContextS=appContextS;
        }
        IEnumerable<Estudiante> IRepositorio.GetAllEstudiantes()
        {
            var EstudianteConsultado = _appContextS.Estudiantes;
            return EstudianteConsultado;
        }
        Estudiante IRepositorio.AddEstudiante(Estudiante estudiante)
        {
            var EstudianteCreado=_appContextS.Estudiantes.Add(estudiante);
            _appContextS.SaveChanges();
            return EstudianteCreado.Entity;
        }

        void IRepositorio.DeleteEstudiante(int EstudianteId)
        {
            var EstudianteEncontrado = _appContextS.Estudiantes.FirstOrDefault(e =>e.Id == EstudianteId);


            if(EstudianteEncontrado==null)
            return;
            _appContextS.Estudiantes.Remove(EstudianteEncontrado);
            _appContextS.SaveChanges();
            
        }
        Estudiante IRepositorio.GetEstudiante(int EstudianteId)
        {
            return _appContextS.Estudiantes.FirstOrDefault(e =>e.Id == EstudianteId);
           

        }
        Estudiante IRepositorio.UpdateEstudiante(Estudiante estudiante)
        {
            var EstudianteEncontrado = _appContextS.Estudiantes.FirstOrDefault(e =>e.Id == estudiante.Id);
            if(EstudianteEncontrado!=null)
            {
                EstudianteEncontrado.Nombre = estudiante.Nombre;
                EstudianteEncontrado.Apellido = estudiante.Apellido;
                EstudianteEncontrado.Edad = estudiante.Edad;
                EstudianteEncontrado.Correo = estudiante.Correo;
                EstudianteEncontrado.FechaNacimiento = estudiante.FechaNacimiento;
                     
                _appContextS.SaveChanges();

            }
            return EstudianteEncontrado;

        }

        // Instructor
        public IEnumerable<Instructor> GetAllInstructores()
        {
            return _appContextS.Instructor;
        }

        public Instructor AddInstructor(Instructor instructor)
        {
            var instructorCreado = _appContextS.Instructor.Add(instructor);
            _appContextS.SaveChanges();
            return instructorCreado.Entity;
        }

        public void DeleteInstructor(int instructorId)
        {
            var instructorEncontrado = _appContextS.Instructor.FirstOrDefault(i => i.Id == instructorId);

            if (instructorEncontrado == null)
                return;

            _appContextS.Instructor.Remove(instructorEncontrado);
            _appContextS.SaveChanges();
        }

        public Instructor GetInstructor(int instructorId)
        {
            return _appContextS.Instructor.FirstOrDefault(i => i.Id == instructorId);
        }

        public Instructor UpdateInstructor(Instructor instructor)
        {
            var instructorEncontrado = _appContextS.Instructor.FirstOrDefault(i => i.Id == instructor.Id);
            
            if (instructorEncontrado != null)
            {
                instructorEncontrado.Nombre = instructor.Nombre;
                instructorEncontrado.Apellido = instructor.Apellido;
                instructorEncontrado.Edad = instructor.Edad;
                instructorEncontrado.Correo = instructor.Correo;
                instructorEncontrado.Rol = instructor.Rol;
                instructorEncontrado.Codigo = instructor.Codigo;
                
                _appContextS.SaveChanges();
            }

            return instructorEncontrado;
        }

        // Materia
        public IEnumerable<Materia> GetAllMaterias()
        {
            return _appContextS.Materias;
        }

        public Materia AddMateria(Materia materia)
        {
            var materiaCreada = _appContextS.Materias.Add(materia);
            _appContextS.SaveChanges();
            return materiaCreada.Entity;
        }

        public void DeleteMateria(int materiaId)
        {
            var materiaEncontrada = _appContextS.Materias.FirstOrDefault(m => m.Id == materiaId);

            if (materiaEncontrada == null)
                return;

            _appContextS.Materias.Remove(materiaEncontrada);
            _appContextS.SaveChanges();
        }

        public Materia GetMateria(int materiaId)
        {
            return _appContextS.Materias.FirstOrDefault(m => m.Id == materiaId);
        }

        public Materia UpdateMateria(Materia materia)
        {
            var materiaEncontrada = _appContextS.Materias.FirstOrDefault(m => m.Id == materia.Id);

            if (materiaEncontrada != null)
            {
                materiaEncontrada.Nombre = materia.Nombre;
                materiaEncontrada.Estado = materia.Estado;

                _appContextS.SaveChanges();
            }

            return materiaEncontrada;
        }
         // Inscripcion
        public IEnumerable<Inscripcion> GetAllInscripciones()
        {
            return _appContextS.Inscripciones;
        }

        public Inscripcion AddInscripcion(Inscripcion inscripcion)
        {
            var inscripcionCreada = _appContextS.Inscripciones.Add(inscripcion);
            _appContextS.SaveChanges();
            return inscripcionCreada.Entity;
        }

        public void DeleteInscripcion(int inscripcionId)
        {
            var inscripcionEncontrada = _appContextS.Inscripciones.FirstOrDefault(i => i.Id == inscripcionId);

            if (inscripcionEncontrada == null)
                return;

            _appContextS.Inscripciones.Remove(inscripcionEncontrada);
            _appContextS.SaveChanges();
        }

        public Inscripcion GetInscripcion(int inscripcionId)
        {
            return _appContextS.Inscripciones.FirstOrDefault(i => i.Id == inscripcionId);
        }

        public Inscripcion UpdateInscripcion(Inscripcion inscripcion)
        {
            var inscripcionEncontrada = _appContextS.Inscripciones.FirstOrDefault(i => i.Id == inscripcion.Id);

            if (inscripcionEncontrada != null)
            {
                inscripcionEncontrada.FechaInscripcion = inscripcion.FechaInscripcion;

                _appContextS.SaveChanges();
            }

            return inscripcionEncontrada;
        }
         // Curso
        public IEnumerable<Curso> GetAllCursos()
        {
            return _appContextS.Cursos;
        }

        public Curso AddCurso(Curso curso)
        {
            var cursoCreado = _appContextS.Cursos.Add(curso);
            _appContextS.SaveChanges();
            return cursoCreado.Entity;
        }

        public void DeleteCurso(int cursoId)
        {
            var cursoEncontrado = _appContextS.Cursos.FirstOrDefault(c => c.Id == cursoId);

            if (cursoEncontrado == null)
                return;

            _appContextS.Cursos.Remove(cursoEncontrado);
            _appContextS.SaveChanges();
        }

        public Curso GetCurso(int cursoId)
        {
            return _appContextS.Cursos.FirstOrDefault(c => c.Id == cursoId);
        }

        public Curso UpdateCurso(Curso curso)
        {
            var cursoEncontrado = _appContextS.Cursos.FirstOrDefault(c => c.Id == curso.Id);

            if (cursoEncontrado != null)
            {
                cursoEncontrado.Nombre = curso.Nombre;
                cursoEncontrado.Descripcion = curso.Descripcion;

                _appContextS.SaveChanges();
            }

            return cursoEncontrado;
        }


    }

}
