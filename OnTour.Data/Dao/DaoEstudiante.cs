using System;
using System.Text;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoEstudiante : Dao
    {



        private DaoEstudiante() : base() { }


        public static DaoEstudiante CrearDao()
        {
            return new DaoEstudiante();
        }


        public void AgregarEstudiante(int idCurso, Estudiante myEstudiante)
        {
            try
            {
                var myQuery = this.DefinirObjetoConsultaAccion("spProcesarEstudiante");
                myQuery.AgregarParametro(":pIdCurso", idCurso, DbType.Int32);
                myQuery.AgregarParametro(":pRutEstudiante", myEstudiante.RutEstudiante, DbType.String);
                myQuery.AgregarParametro(":pNombreEstudiante", myEstudiante.Nombre, DbType.String);
                myQuery.AgregarParametro(":pApellidoEstudiante", myEstudiante.Apellidos, DbType.String);
                myQuery.AgregarParametro(":pIdApoderado", myEstudiante.Apoderado.Id_Apoderado, DbType.Int32);
                myQuery.AgregarParametro(":pRutApoderado", myEstudiante.Apoderado.Rut, DbType.String);
                myQuery.AgregarParametro(":pNombreApoderado", myEstudiante.Apoderado.Nombre, DbType.String);
                myQuery.AgregarParametro(":pApellidoApoderado", myEstudiante.Apoderado.Apellidos, DbType.String);
                myQuery.AgregarParametro(":pEmailApoderado", myEstudiante.Apoderado.Email, DbType.String);
                myQuery.AgregarParametro(":pIdTipoApoderado", myEstudiante.Apoderado.Id_Tipo, DbType.Int32);
                myQuery.EjecutarConsulta();
            }
            catch
            {
                throw;
            }
        }


                public DataTable ObtenerNominaDeEstudiantes(int idCurso)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ");
            sql.Append("est.rut_estudiante AS Rut, ");
            sql.Append("est.nombre_estudiante AS Nombre, ");
            sql.Append("est.apellidos_estudiante AS Apellidos, ");
            sql.Append("apo.rut_apoderado AS Rut_apoderado, ");
            sql.Append("apo.nombre_apoderado AS Nombre_apoderado, ");
            sql.Append("apo.apellidos_apoderado AS Apellidos_apoderado, ");
            sql.Append("apo.email AS email, ");
            sql.Append("apo.id_tipoapoderado AS Id_tipo, ");
            sql.Append("tpa.descripcion AS Parentezco, ");
            sql.Append("dtc.id_curso as id_curso, ");
            sql.Append("apo.id_apoderado AS IdApoderado ");
            sql.Append("FROM estudiante est JOIN apoderado apo ON est.id_apoderado=apo.id_apoderado ");
            sql.Append("JOIN tipo_apoderado tpa ON apo.id_tipoapoderado=tpa.id_tipoapoderado ");
            sql.Append("JOIN detallecurso dtc ON est.rut_estudiante=dtc.rut_estudiante  ");
            sql.Append("where dtc.id_curso=:pIdCurso  ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pIdCurso", idCurso, DbType.Int32);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerTiposDeApoderados()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id_tipoapoderado, descripcion FROM tipo_apoderado ORDER BY id_tipoapoderado ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerInformacionEstudiante(string rutEstudiante)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT  ");
            sql.Append("est.rut_estudiante AS Rut_estudiante,  ");
            sql.Append("InitCap(est.nombre_estudiante||' '||est.apellidos_estudiante) AS Nombre_estudiante,  ");
            sql.Append("apo.rut_apoderado AS Rut_apoderado,  ");
            sql.Append("initCap(apo.nombre_apoderado||' '||apo.apellidos_apoderado) AS Nombre_apoderado,  ");
            sql.Append("tpa.descripcion AS Parentezco,  ");
            sql.Append("cur.id_curso AS Id_Curso,  ");
            sql.Append("cur.nombre_curso AS Curso,  ");
            sql.Append("cur.establecimiento_curso AS Establecimiento,  ");
            sql.Append("REP.nombre_representante AS Representante,  ");
            sql.Append("tpr.descripcion as Cargo,  ");
            sql.Append("cli.id_cliente as Id_Cliente ");
            sql.Append("FROM estudiante est JOIN apoderado apo ON est.id_apoderado=apo.id_apoderado  ");
            sql.Append("JOIN tipo_apoderado tpa ON apo.id_tipoapoderado=tpa.id_tipoapoderado  ");
            sql.Append("JOIN detallecurso dtc ON est.rut_estudiante=dtc.rut_estudiante  ");
            sql.Append("JOIN curso cur ON dtc.id_curso=cur.id_curso  ");
            sql.Append("JOIN representante REP ON cur.id_representante=REP.id_representante  ");
            sql.Append("join tiporep tpr on rep.id_tiporepresentante=tpr.id_tiporepresentante  ");
            sql.Append("join cliente cli on cur.id_curso=cli.id_curso  ");
            sql.Append("WHERE est.rut_estudiante=:pRutEstudiante ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pRutEstudiante", rutEstudiante, DbType.String);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }



    }
}
