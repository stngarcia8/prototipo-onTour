using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
    public class Representante
    {

        public int Id_Representante { get; set; }
        public string nombre_representante { get; set; }
        public string Email { get; set; }
        public int Id_TipoRepresentante { get; set; }
        public string Descripcion { get; set; }

    }
}
