using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
    public class Destino
    {

        public int IdDestino { get; set; }
        public string Lugar { get; set; }
        public string Guia { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public double Duración { get; set; }
        public int IdTransporte { get; set; }

    }
}
