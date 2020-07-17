using System.Data;

namespace OnTour.Data.Connection
{
    public interface IConsultaAccion
    {

        void AgregarParametro(string nombreParametro, object valorParametro, DbType tipoValorParametro);

        void LimpiarParametros();

        int EjecutarConsulta();

    }
}
