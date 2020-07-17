using System.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosEstudiante
    {

        private DatosEstudiante() { }


        public static DatosEstudiante AbrirDatosEstudiante()
        {
            return new DatosEstudiante();
        }


        public DataTable ObtenerNominaDeCurso(int idCurso)
        {
            return DaoEstudiante.CrearDao().ObtenerNominaDeEstudiantes(idCurso);
        }


        public DataTable ObtenerTiposDeApoderados()
        {
            return DaoEstudiante.CrearDao().ObtenerTiposDeApoderados();
        }



        public DataTable ObtenerInformacionEstudiante(string rutEstudiante)
        {
            return DaoEstudiante.CrearDao().ObtenerInformacionEstudiante(rutEstudiante);
        }





    }
}
