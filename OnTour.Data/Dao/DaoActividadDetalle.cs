using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoActividadDetalle : Dao
    {



        private DaoActividadDetalle() : base() { }


        public static DaoActividadDetalle CrearDao()
        {
            return new DaoActividadDetalle();
        }



        public int Limpiar(int idActividad)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarActividad_limpiar");
                myQuery.AgregarParametro(":pIdActividad", idActividad, DbType.Int32);
                return myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }


        public void AgregarDetalle(int idActividad, int idDestino)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarActividad_detalle");
                myQuery.AgregarParametro(":pIdActividad", idActividad, DbType.Int32);
                myQuery.AgregarParametro(":pIdDestino", idDestino, DbType.Int32);
                myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }


        public DataTable ObtenerListaDeDestinos(int idActividad)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT de.id_destino AS ID, de.lugar AS Lugar, de.Guia AS Guia, de.Inicio AS Inicio, de.termino AS Termino, de.duracion AS Duracion, ");
                sql.Append("tr.Descripcion AS Transporte ");
                sql.Append("FROM destino_actividad da join destino de on da.id_destino=de.id_destino ");
                sql.Append(" join transporte tr on de.id_transporte = tr.id_transporte ");
                sql.Append("WHERE da.id_actividad=:IdActividad ");
                sql.Append("ORDER BY da.id_actividad, da.id_detalle_actividad, da.id_destino ");
                var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
                myQuery.AgregarParametro("IdActividad", idActividad, DbType.Int32);
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
