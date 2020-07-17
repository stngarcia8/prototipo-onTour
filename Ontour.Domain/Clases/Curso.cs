using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
public     class Curso
    {

        public int Id_Curso { get; set; }
        public string Nombre_Curso { get; set; }
        public string Establecimiento { get; set; }
        public Representante RepresentanteCurso { get; set; }
        public IList<Estudiante> NominaEstudiantes { get; set; }


        public Curso()
        {
            this.Id_Curso = 0;
            this.Nombre_Curso = string.Empty;
            this.Establecimiento = string.Empty;
            this.RepresentanteCurso = new Representante();
            this.NominaEstudiantes = new List<Estudiante>();
        }


        public void AgregarEstudiante(Estudiante myEstudiante)
        {
            this.NominaEstudiantes.Add(myEstudiante);
        }


        public void QuitarEstudiante(Estudiante myEstudiante)
        {
            this.NominaEstudiantes.Remove(myEstudiante);
        }

    }
}
