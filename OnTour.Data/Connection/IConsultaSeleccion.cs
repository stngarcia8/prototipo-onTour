using System.Data;

namespace OnTour.Data.Connection
{
    public interface IConsultaSeleccion
    {

        void AgregarParametro(string nombreParametro, object valorParametro, DbType tipoValorParametro);

        void LimpiarParametros();

        DataTable EjecutarConsulta();
    }
}
