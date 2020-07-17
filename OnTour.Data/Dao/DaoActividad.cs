using System;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoActividad : Dao
    {



        private DaoActividad() : base() { }


        public static DaoActividad CrearDao()
        {
            return new DaoActividad();
        }


        public int Agregar(Actividad myActividad, IList<int> misDestinosIds)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myActividad, 0);
                var myDaoDetalle = DaoActividadDetalle.CrearDao();
                myDaoDetalle.Limpiar(myActividad.IdActividad);
                foreach (int myIdDestino in misDestinosIds)
                {
                    myDaoDetalle.AgregarDetalle(myActividad.IdActividad, myIdDestino);
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Editar(Actividad myActividad, IList<int> misDestinosIds)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myActividad, 1);
                var myDaoDetalle = DaoActividadDetalle.CrearDao();
                myDaoDetalle.Limpiar(myActividad.IdActividad);
                foreach (int myIdDestino in misDestinosIds)
                {
                    myDaoDetalle.AgregarDetalle(myActividad.IdActividad, myIdDestino);
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Inhabilitar(Actividad myActividad)
        {
            return EjecutarProcedimientoAlmacenado(myActividad, 2);
        }


        public int Habilitar(Actividad myActividad)
        {
            return EjecutarProcedimientoAlmacenado(myActividad, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Actividad myActividad, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarActividad");
            myQuery.AgregarParametro(":pIdActividad", myActividad.IdActividad, DbType.Int32);
            myQuery.AgregarParametro(":pDescripcion", myActividad.Descripcion, DbType.String);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerListaDeActividades()
        {
            string sql = "SELECT id_actividad AS ID, nombre AS Actividad, CASE WHEN habilitado=1 THEN 'Si' ELSE 'No' END AS Habilitado FROM actividad  WHERE id_Actividad>0 ORDER BY id_actividad";
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerDestinosAsociados(int idActividad)
        {
            return DaoActividadDetalle.CrearDao().ObtenerListaDeDestinos(idActividad);
        }


        public DataTable ObtenerListaDeActividadesParaSeleccionar()
        {
            string sql = "select id_actividad as Id, nombre as Actividad from actividad order by id_actividad";
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }












    }
}
