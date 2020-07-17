using System.Data;
using Ontour.Domain.Clases;

namespace OnTour.Data.Dao
{
    public class DAOHotel : Dao
    {



        private DAOHotel() : base() { }


        public static DAOHotel CrearDao()
        {
            return new DAOHotel();
        }


        public int Agregar(Hotel myHotel)
        {
            return EjecutarProcedimientoAlmacenado(myHotel, 0);
        }


        public int Editar(Hotel myHotel)
        {
            return EjecutarProcedimientoAlmacenado(myHotel, 1);
        }


        public int Inhabilitar(Hotel myHotel)
        {
            return EjecutarProcedimientoAlmacenado(myHotel, 2);
        }


        public int Habilitar(Hotel myHotel)
        {
            return EjecutarProcedimientoAlmacenado(myHotel, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Hotel myHotel, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarHotel");
            myQuery.AgregarParametro(":pIdHotel", myHotel.IdHotel, DbType.Int32);
            myQuery.AgregarParametro(":pNombre", myHotel.Nombre, DbType.String);
            myQuery.AgregarParametro(":pDireccion", myHotel.Direccion, DbType.String);
            myQuery.AgregarParametro(":pWeb", myHotel.Web, DbType.String);
            myQuery.AgregarParametro(":pTelefono", myHotel.Telefono, DbType.String);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerListaDeHoteles()
        {
            string sql = "SELECT id_hotel AS Id, nombre AS Nombre, direccion AS Direccion, web AS Web, telefonos AS Telefonos, CASE WHEN habilitado=1 THEN 'Si' ELSE 'No' END AS Habilitado  FROM hotel WHERE id_hotel>0 ORDER BY id_hotel";
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }












    }
}
