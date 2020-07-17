using System.Data;
using System.Collections.Generic;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosActividad
    {

        private DatosActividad() { }


        public static DatosActividad AbrirDatosActividad()
        {
            return new DatosActividad();
        }


        public int Grabar(TipoGrabacion myTipo, Actividad myActividad, IList<int> misDestinosIds)
        {
            try
            {
                int registrosAfectados = 0;
                var myDao = DaoActividad.CrearDao();
                if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myActividad, misDestinosIds);
                if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myActividad, misDestinosIds);
                if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myActividad);
                if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myActividad);
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public DataTable ObtenerListadoDeActividades()
        {
            return DaoActividad.CrearDao().ObtenerListaDeActividades();
        }


        public DataTable ObtenerListadoDeDestinos(int idActividad)
        {
            return DaoActividad.CrearDao().ObtenerDestinosAsociados(idActividad);
        }


        public DataTable ObtenerListadoDeActividadesParaSeleccion()
        {
            return DaoActividad.CrearDao().ObtenerListaDeActividadesParaSeleccionar();
        }


    }
}
