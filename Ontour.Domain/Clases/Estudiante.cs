using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
public    class Estudiante
    {

        public string RutEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
public Apoderado Apoderado { get; set; }


        public Estudiante()
        {
            this.RutEstudiante = string.Empty;
            this.Nombre = string.Empty;
            this.Apellidos = string.Empty;
            this.Apoderado = new Apoderado();
        }

    }
}
