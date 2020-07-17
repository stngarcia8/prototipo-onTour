using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoTour : Dao
    {



        private DaoTour() : base() { }


        public static DaoTour CrearDao()
        {
            return new DaoTour();
        }


        public int Agregar(Tour myTour, IList<int> misActividadesIds)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myTour, 0);
                var myDaoDetalle = DaoActividadDetalle.CrearDao();
                myDaoDetalle.Limpiar(myTour.Id_Tour);
                foreach (int myIdActividad in misActividadesIds)
                {
                    myDaoDetalle.AgregarDetalle(myTour.Id_Tour, myIdActividad);
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Editar(Tour myTour, IList<int> misActividadesIds)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myTour, 1);
                var myDaoDetalle = DaoTourDetalle.CrearDao();
                myDaoDetalle.Limpiar(myTour.Id_Tour);
                foreach (int myIdActividad in misActividadesIds)
                {
                    myDaoDetalle.AgregarDetalle(myTour.Id_Tour, myIdActividad);
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Inhabilitar(Tour myTour)
        {
            return EjecutarProcedimientoAlmacenado(myTour, 2);
        }


        public int Habilitar(Tour myTour)
        {
            return EjecutarProcedimientoAlmacenado(myTour, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Tour myTour, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarTour");
            myQuery.AgregarParametro(":pIdTour", myTour.Id_Tour, DbType.Int32);
            myQuery.AgregarParametro(":pDescripcion", myTour.Nombre, DbType.String);
            myQuery.AgregarParametro(":pIdHotel", myTour.Id_Hotel, DbType.Int32);
            myQuery.AgregarParametro(":pIdTransporte", myTour.Id_Transporte, DbType.Int32);
            myQuery.AgregarParametro(":pValorTour", myTour.Valor, DbType.Double);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerListaDeTours()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TOu.id_tour AS ID, TOu.descripcion AS Tour, tou.id_hotel AS IdHotel, HO.nombre AS Hotel, tou.id_transporte AS IdTransporte, ");
            sql.Append("tr.descripcion AS Transporte, nvl(tou.valor_tour,0) AS Valor, case when tou.habilitado=1 then 'Si' else 'No' end as Habilitado ");
            sql.Append("FROM tour TOu JOIN hotel HO ON tou.id_hotel = HO.id_hotel ");
            sql.Append("join transporte tr on tou.id_transporte = tr.id_transporte ");
            sql.Append("WHERE TOu.id_tour >0 ");
            sql.Append("order by tou.id_tour ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }



        public DataTable ObtenerActividadesAsociadas(int idTour)
        {
            return DaoTourDetalle.CrearDao().ObtenerListaDeActividades(idTour);
        }


        public DataTable ObtenerToursCliente(int idCliente)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TOu.id_tour AS ID, TOu.descripcion AS Tour, tou.id_hotel AS IdHotel, HO.nombre AS Hotel, tou.id_transporte AS IdTransporte, ");
            sql.Append("tr.descripcion AS Transporte, nvl(tou.valor_tour,0) AS Valor, case when tou.habilitado=1 then 'Si' else 'No' end as Habilitado ");
            sql.Append("FROM tour TOu JOIN hotel HO ON tou.id_hotel = HO.id_hotel ");
            sql.Append("join transporte tr on tou.id_transporte = tr.id_transporte ");
            sql.Append("join cliente cli on tou.id_tour= cli.id_tour ");
            sql.Append("WHERE cli.id_cliente=:pIdCliente ");
            sql.Append("order by tou.id_tour ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pIdCliente", idCliente, DbType.Int32);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }






    }
}
