using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
   public class Pago
    {

        public int Id_Pago { get; set; }
        public int DiaVencimiento { get; set; }
        public bool EstaSaldado { get; set; }
        public bool EstaFiniquitado { get; set; }
        public double Saldo { get; set; }
        public int Id_Cliente { get; set; }
        public int CuotasPactadas { get; set; }


        public Pago()
        {
            this.Id_Pago = 0;
            this.DiaVencimiento = 0;
            this.EstaFiniquitado = false;
            this.EstaSaldado = false;
            this.Id_Cliente = 0;
            this.CuotasPactadas = 0;
        }

    }
}
