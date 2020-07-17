using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Domain.Clases
{
    public sealed class Usuario
    {

        private volatile static Usuario _Instancia;
        private static readonly object _padLock = new object();


        public static string Rut { get; set; }
        public static string Nombre { get; set; }
        public static string Email { get; set; }
        public static int Tipo { get; set; }
        public static int IdCliente { get; set; }
        public static string RutEstudiante { get; set; }


        private Usuario()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
            Email = string.Empty;
            Tipo = -1;
            IdCliente = -1;
            RutEstudiante = string.Empty;
        }


        private static void VerificarInstancia()
        {
            if (_Instancia == null)
            {
                lock (_padLock)
                {
                    if (_Instancia == null)
                    {
                        _Instancia = new Usuario();
                    }
                }
            }
        }






    }
}
