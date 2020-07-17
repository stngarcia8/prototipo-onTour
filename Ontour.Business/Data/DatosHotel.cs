using System;
using Ontour.Domain.Clases;
using Ontour.Business.Enumerations;
using System.Data;
using OnTour.Data.Dao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontour.Business.Data
{
    public class DatosHotel
    {

        private DatosHotel() { }


        public static DatosHotel AbrirDatosHotel()
        {
            return new DatosHotel();
        }


        public int Grabar(TipoGrabacion myTipo,Hotel  myHotel)
        {
            int registrosAfectados = 0;
            var myDao = DAOHotel.CrearDao();
            if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myHotel);
            if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myHotel);
            if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myHotel);
            if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myHotel);
            return registrosAfectados;
        }


        public DataTable ObtenerListadoDeHotel()
        {
            return DAOHotel.CrearDao().ObtenerListaDeHoteles();
        }




    }
}
