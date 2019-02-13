using MVC_CRUD_DiplomadoUASDCodeFirst.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Models.DAL
{
   public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudianteContext>
    {
        protected override void Seed(EstudianteContext context)
        {
            var Cursos = new List<Curso>
            {
                new Curso{CursoID=1,Descripcion="Desarrollo Web",},
                new Curso{CursoID=2,Descripcion="Sql Server",},
                new Curso{CursoID=3,Descripcion="Diñeo Web",}
            };
            Cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var Estudiantes = new List<Estudiante>
            {
                new Estudiante{Nombres="Julio Alexander",Apellidos="Peña Bustamente",Fecha_Inscripcion=DateTime.Parse("2002-02-08")},
                new Estudiante{Nombres="Dorka Sther",Apellidos="Gutierrez Apolinar",Fecha_Inscripcion=DateTime.Parse("2000-03-18")},
                new Estudiante{Nombres="Juan Diego",Apellidos="Feliz Almonte",Fecha_Inscripcion=DateTime.Parse("2000-05-06")},
                new Estudiante{Nombres="Junior",Apellidos="Ferreras",Fecha_Inscripcion=DateTime.Parse("1999-07-23")}
            };
            Estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();

            var Inscripciones = new List<Inscripcion>
            {
                new Inscripcion{EstudianteID=1,CursoID=1,Semestre=1},
                new Inscripcion{EstudianteID=2,CursoID=1,Semestre=2},
                new Inscripcion{EstudianteID=3,CursoID=2,Semestre=1},
                new Inscripcion{EstudianteID=4,CursoID=2,Semestre=1}
            };
            Inscripciones.ForEach(s => context.Inscripciones.Add(s));
            context.SaveChanges();

        }
    }
}

