using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace OnTour.Data.Connection
{
    public class ConsultaAccion : Consulta, IConsultaAccion
    {

        private ConsultaAccion(OracleCommand comando) : base(comando) { }


        public static ConsultaAccion CrearConsulta(OracleCommand comando)
        {
            return new ConsultaAccion(comando);
        }


        public override void AgregarParametro(string nombreParametro, object valorParametro, DbType tipoValorParametro)
        {
            base.AgregarParametro(nombreParametro, valorParametro, tipoValorParametro);
        }


        public int EjecutarConsulta()
        {
            int registrosAfectados = 0;
            try
            {
                registrosAfectados = this.comando.ExecuteNonQuery();
            }
            catch  
            {
                throw;
            }

            return registrosAfectados;
        }


        public void LimpiarParametros()
        {
            base.ClearParameters();
        }









    }
}
