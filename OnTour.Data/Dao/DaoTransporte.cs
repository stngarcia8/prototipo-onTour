using System;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoTransporte : Dao
    {



        private DaoTransporte() : base() { }


        public static DaoTransporte CrearDao()
        {
            return new DaoTransporte();
        }


        public int Agregar(Transporte myTransporte)
        {
            return EjecutarProcedimientoAlmacenado(myTransporte, 0);
        }


        public int Editar(Transporte myTransporte)
        {
            return EjecutarProcedimientoAlmacenado(myTransporte, 1);
        }


        public int Inhabilitar(Transporte myTransporte)
        {
            return EjecutarProcedimientoAlmacenado(myTransporte, 2);
        }


        public int Habilitar(Transporte myTransporte)
        {
            return EjecutarProcedimientoAlmacenado(myTransporte, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Transporte myTransporte, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarTransporte");
            myQuery.AgregarParametro(":pIdTransporte", myTransporte.Id_Transporte, DbType.Int32);
            myQuery.AgregarParametro(":pDescripcion", myTransporte.Descripcion, DbType.String);
            myQuery.AgregarParametro(":pIdTipoTransporte", myTransporte.Id_TipoTransporte, DbType.Int32);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerTiposDeTransportes()
        {
            var myQuery = this.DefinirObjetoConsultaSeleccion("SELECT id_tipotransporte, descripcion FROM tipo_transporte ORDER BY id_tipotransporte");
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerListaDeTransportes()
        {
            string sql = "SELECT tr.id_transporte AS ID, tr.descripcion AS Transporte, tt.id_tipotransporte AS Id_Tipo, tt.descripcion AS Tipo, CASE WHEN tr.habilitado=1 THEN 'Si' ELSE 'No' END AS Habilitado FROM transporte tr JOIN tipo_transporte tt ON tr.id_tipotransporte = tt.id_tipotransporte WHERE tr.habilitado>0 ORDER BY tr.id_transporte";
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }












    }
}
