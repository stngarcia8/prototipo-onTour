using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
    public class Tour
    {

        public int Id_Tour { get; set; }
        public string Nombre { get; set; }
        public int Id_Hotel { get; set; }
        public int Id_Transporte { get; set; }
        public double Valor { get; set; }

    }
}
