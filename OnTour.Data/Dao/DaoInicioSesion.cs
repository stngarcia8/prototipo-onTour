using System;
using System.Text;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoInicioSesion : Dao
    {


        private DaoInicioSesion() : base() { }


        public static DaoInicioSesion CrearDao()
        {
            return new DaoInicioSesion();
        }


        public DataTable IniciarSesion(string usr, string pwd)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ontour.usuarios where rrut_usuario=:pRutUsuario and pwd_usuario=:pPwdUsuario ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pRutUsuario", usr, DbType.String);
            myQuery.AgregarParametro(":pPwdUsuario", pwd, DbType.String);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }















    }
}
