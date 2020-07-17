using System.Data;
using System.Collections.Generic;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosInicioSesion
    {

        private DatosInicioSesion() { }


        public static DatosInicioSesion AbrirDatosInicioSesion()
        {
            return new DatosInicioSesion();
        }



        public bool IniciarSesion(string unUsuario, string unaPwd)
        {
            DaoInicioSesion myDao = DaoInicioSesion.CrearDao();
            DataTable myDataTable = new DataTable();
            myDataTable= myDao.IniciarSesion(unUsuario, unaPwd);
            if (myDataTable.Rows.Count.Equals(0)) return false;
            DataRow myRow = myDataTable.Rows[0];
            Usuario.Rut = myRow["rrut_usuario"].ToString();
            Usuario.Nombre = myRow["nombre_usuario"].ToString();
            Usuario.Email = myRow["email_usuario"].ToString();
            Usuario.Tipo = int.Parse(myRow["tipo_usuario"].ToString());
            Usuario.IdCliente = int.Parse(myRow["id_cliente"].ToString());
            Usuario.RutEstudiante = myRow["rut_estudiante"].ToString();
            return true;
        }



    }
}
