using Oracle.DataAccess.Client;

namespace OnTour.Data.Connection
{
    public interface IConectarOracle
    {

        OracleConnection ObtenerConeccion();

        OracleTransaction ObtenerTransaccion();

        void Commit();

        void RollBack();

        IConsultaSeleccion CrearConsultaSeleccion(string sql);

        IConsultaAccion CrearConsultaAccion(string nombreProcedimientoAlmacenado);

        void cerrarConeccion();

    }
}
