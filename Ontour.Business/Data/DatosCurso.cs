using System.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosCurso
    {

        private DatosCurso() { }


        public static DatosCurso AbrirDatosCurso()
        {
            return new DatosCurso();
        }


        public int Grabar(TipoGrabacion myTipo, Curso myCurso)
        {
            try
            {
                int registrosAfectados = 0;
                var myDao = DaoCurso.CrearDao();
                if (myTipo.Equals(TipoGrabacion.Agregar)) registrosAfectados = myDao.Agregar(myCurso);
                if (myTipo.Equals(TipoGrabacion.Editar)) registrosAfectados = myDao.Editar(myCurso);
                if (myTipo.Equals(TipoGrabacion.Inhabilitar)) registrosAfectados = myDao.Inhabilitar(myCurso);
                if (myTipo.Equals(TipoGrabacion.Habilitar)) registrosAfectados = myDao.Habilitar(myCurso);
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public DataTable ObtenerListadoDeCursos()
        {
            return DaoCurso.CrearDao().ObtenerListaDeCursos();
        }


        public DataTable ObtenerAvancesDeCursos()
        {
            return DaoCurso.CrearDao().ObtenerAvancesDeCursos();
        }


        public DataTable ObtenerAvancesDeCursos(int idCliente)
        {
            return DaoCurso.CrearDao().ObtenerAvancesDeCursos(idCliente);
        }


        public DataTable ObtenerTiposDeRepresentantes()
        {
            return DaoCurso.CrearDao().ObtenerTiposDeRepresentante();
        }




    }
}
