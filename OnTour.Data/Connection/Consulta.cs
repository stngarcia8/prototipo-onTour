using System;
using System.Data;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Data.Connection
{
    public abstract class Consulta
    {

        protected OracleCommand comando;




        protected Consulta(OracleCommand comando)
        {
            this.comando = comando;
        }


        public virtual void AgregarParametro(string nombreParametro, object valorParametro, DbType tipoValorParametro)
        {
            OracleParameter parametro = new OracleParameter();
            parametro.ParameterName = nombreParametro;
            parametro.Value = valorParametro;
            parametro.DbType = tipoValorParametro;
            this.comando.Parameters.Add(parametro);
        }


        protected void ClearParameters()
        {
            this.comando.Parameters.Clear();
        }








    }
}
