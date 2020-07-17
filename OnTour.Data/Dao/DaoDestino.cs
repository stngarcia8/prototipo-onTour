using System.Data;
using System.Text;
using Ontour.Domain.Clases;

namespace OnTour.Data.Dao
{
    public class DAODestino : Dao
    {


        private DAODestino() : base() { }


        public static DAODestino CrearDao()
        {
            return new DAODestino();
        }


        public int Agregar(Destino myDestino)
        {
            return EjecutarProcedimientoAlmacenado(myDestino, 0);
        }


        public int Editar(Destino myDestino)
        {
            return EjecutarProcedimientoAlmacenado(myDestino, 1);
        }


        public int Inhabilitar(Destino myDestino)
        {
            return EjecutarProcedimientoAlmacenado(myDestino, 2);
        }


        public int Habilitar(Destino myDestino)
        {
            return EjecutarProcedimientoAlmacenado(myDestino, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Destino myDestino, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarDestino");
            myQuery.AgregarParametro(":pIdDestino", myDestino.IdDestino, DbType.Int32);
            myQuery.AgregarParametro(":pLugar", myDestino.Lugar, DbType.String);
            myQuery.AgregarParametro(":pGuia", myDestino.Guia, DbType.String);
            myQuery.AgregarParametro(":pInicio", myDestino.Inicio, DbType.Date);
            myQuery.AgregarParametro(":pTermino", myDestino.Termino, DbType.Date);
            myQuery.AgregarParametro(":pDuracion", myDestino.Duración, DbType.Double);
            myQuery.AgregarParametro(":pIdTransporte", myDestino.IdTransporte, DbType.Int32);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerListaDeDestinos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT de.id_destino AS ID, de.lugar AS Lugar, de.Guia AS Guia, de.Inicio AS Inicio, de.termino AS Termino, de.duracion AS Duracion, de.id_transporte AS IdTransporte, ");
            sql.Append("tr.Descripcion AS Transporte, case when de.habilitado=1 then 'Si' else 'No' end as Habilitado ");
            sql.Append("FROM destino de join transporte tr on de.id_transporte = tr.id_transporte ");
            sql.Append("WHERE id_destino> 0 ");
            sql.Append("ORDER BY id_destino");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }



        public DataTable ObtenerListaDeDestinosParaSeleccionar()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT de.id_destino AS ID, de.lugar AS Lugar, de.Guia AS Guia, de.Inicio AS Inicio, de.termino AS Termino, de.duracion AS Duracion, ");
            sql.Append("tr.Descripcion AS Transporte ");
            sql.Append("FROM destino de join transporte tr on de.id_transporte = tr.id_transporte ");
            sql.Append("WHERE id_destino> 0 ");
            sql.Append("ORDER BY id_destino");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }











    }
}
