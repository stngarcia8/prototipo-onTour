using System;
using OnTour.Data.Connection;
    using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Data.Dao
{
    public abstract class Dao
    {


        protected IConectarOracle myConnection;


        protected Dao(){}


        protected IConsultaSeleccion DefinirObjetoConsultaSeleccion(string sql)
        {
            myConnection = ConectarOracle.crearConeccion();
            return myConnection.CrearConsultaSeleccion(sql);
        }


        protected IConsultaAccion DefinirObjetoConsultaAccion(string nombreProcedimientoAlmacenado)
        {
            myConnection = ConectarOracle.crearConeccion();
            return myConnection.CrearConsultaAccion(nombreProcedimientoAlmacenado);
        }

    }
}
