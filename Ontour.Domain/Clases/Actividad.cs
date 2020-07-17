using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
    public class Actividad
    {

        public int IdActividad { get; set; }
        public string Descripcion { get; set; }
        public IList<int> IdsDestinos { get; set; }

    }
}
