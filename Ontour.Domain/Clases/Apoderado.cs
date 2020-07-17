using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
public    class Apoderado
    {

        public int Id_Apoderado { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public int Id_Tipo { get; set; }
        public string Tipo { get; set; }


        public Apoderado()
        {
            this.Id_Apoderado = 0;
            this.Rut = string.Empty;
            this.Nombre = string.Empty;
            this.Apellidos = string.Empty;
            this.Email = string.Empty;
            this.Id_Tipo = 0;
            this.Tipo = string.Empty;
        }

    }
}
