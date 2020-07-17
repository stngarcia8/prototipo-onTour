using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoTourDetalle : Dao
    {



        private DaoTourDetalle() : base() { }


        public static DaoTourDetalle CrearDao()
        {
            return new DaoTourDetalle();
        }



        public int Limpiar(int idTour)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarTour_limpiar");
                myQuery.AgregarParametro(":pIdTour", idTour, DbType.Int32);
                return myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }


        public void AgregarDetalle(int idTour, int idActividad)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarTour_detalle");
                myQuery.AgregarParametro(":pIdTour", idTour, DbType.Int32);
                myQuery.AgregarParametro(":pIdActividad", idActividad, DbType.Int32);
                myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }


        public DataTable ObtenerListaDeActividades(int idTour)
        {
            try
            {
                string sql = "SELECT ac.id_actividad as Id, ac.nombre as Actividad FROM tour_actividad tou join actividad ac on tou.id_actividad=ac.id_actividad where tou.id_tour=:pIdTour ORDER BY tou.id_tour, tou.id_detalle_tour, tou.id_actividad ";
                var myQuery = this.DefinirObjetoConsultaSeleccion(sql);
                myQuery.AgregarParametro("IdTour", idTour, DbType.Int32);
                DataTable myDataTable = myQuery.EjecutarConsulta();
                myConnection.cerrarConeccion();
                return myDataTable;
            }
            catch
            {
                throw;
            }
        }












    }
}
