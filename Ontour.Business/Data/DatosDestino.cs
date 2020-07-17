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
    public class DatosDestino
    {

        private DatosDestino() { }


        public static DatosDestino AbrirDatosDestino()
        {
            return new DatosDestino();
        }


        public int Grabar(TipoGrabacion myTipo, Destino myDestino)
        {
            int registrosAfectados = 0;
            var myDao = DAODestino.CrearDao();
            if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myDestino);
            if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myDestino);
            if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myDestino);
            if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myDestino);
            return registrosAfectados;
        }


        public DataTable ObtenerListadoDeDestinos()
        {
            return DAODestino.CrearDao().ObtenerListaDeDestinos();
        }


        public DataTable ObtenerListadoDeDestinosParaSeleccion()
        {
            return DAODestino.CrearDao().ObtenerListaDeDestinosParaSeleccionar();
        }



    }
}
