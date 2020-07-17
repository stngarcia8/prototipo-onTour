using System.Data;
using System.Collections.Generic;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosTour
    {

        private DatosTour() { }


        public static DatosTour AbrirDatosTour()
        {
            return new DatosTour();
        }


        public int Grabar(TipoGrabacion myTipo, Tour myTour, IList<int> misActividadesIds)
        {
            try
            {
                int registrosAfectados = 0;
                var myDao = DaoTour.CrearDao();
                if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myTour, misActividadesIds);
                if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myTour, misActividadesIds);
                if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myTour);
                if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myTour);
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public DataTable ObtenerListadoDeTours()
        {
            return DaoTour.CrearDao().ObtenerListaDeTours();
        }


        public DataTable ObtenerListadoDeActividades(int idTour)
        {
            return DaoTour.CrearDao().ObtenerActividadesAsociadas(idTour);
        }


        public Tour ObtenerTourCliente(int idCliente)
        {
            Tour myTour = new Tour();
            DataTable myDataTable = DaoTour.CrearDao().ObtenerToursCliente(idCliente);
            if (myDataTable.Rows.Count.Equals(0)) return null;
            DataRow myRow = myDataTable.Rows[0];
            myTour.Id_Tour = int.Parse(myRow["ID"].ToString());
            myTour.Nombre = myRow["Tour"].ToString();
            myTour.Valor = double.Parse(myRow["Valor"].ToString());
            return myTour;
        }



    }
}
