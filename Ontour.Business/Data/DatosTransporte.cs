using System.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosTransporte
    {

        private DatosTransporte() { }


        public static DatosTransporte AbrirDatosTransporte()
        {
            return new DatosTransporte();
        }


        public int Grabar(TipoGrabacion myTipo, Transporte myTransporte)
        {
            int registrosAfectados = 0;
            var myDao = DaoTransporte.CrearDao();
            if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myTransporte);
            if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myTransporte);
            if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myTransporte);
            if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myTransporte);
            return registrosAfectados;
        }


        public DataTable ObtenerTiposDeTransporte()
        {
            return DaoTransporte.CrearDao().ObtenerTiposDeTransportes();
        }


        public DataTable ObtenerListadoDeTransporte()
        {
            return DaoTransporte.CrearDao().ObtenerListaDeTransportes();
        }




    }
}
