using System;
using System.Text;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoCurso : Dao
    {



        private DaoCurso() : base() { }


        public static DaoCurso CrearDao()
        {
            return new DaoCurso();
        }

        public int Agregar(Curso myCurso)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myCurso, 0);
                if (myCurso.NominaEstudiantes.Count > 0)
                {
                    var myDao = DaoEstudiante.CrearDao();
                    foreach (Estudiante myEstudiante in myCurso.NominaEstudiantes)
                    {
                        myDao.AgregarEstudiante(myCurso.Id_Curso, myEstudiante);
                    }
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Editar(Curso myCurso)
        {
            try
            {
                int registrosAfectados = 0;
                registrosAfectados = EjecutarProcedimientoAlmacenado(myCurso, 1);
                DaoCursoDetalle myDaoDetalle = DaoCursoDetalle.CrearDao();
                myDaoDetalle.Limpiar(myCurso.Id_Curso);
                if (myCurso.NominaEstudiantes.Count > 0)
                {
                    var myDao = DaoEstudiante.CrearDao();
                    foreach (Estudiante myEstudiante in myCurso.NominaEstudiantes)
                    {
                        myDao.AgregarEstudiante(myCurso.Id_Curso, myEstudiante);
                    }
                }
                return registrosAfectados;
            }
            catch
            {
                throw;
            }
        }


        public int Inhabilitar(Curso myCurso)
        {
            return EjecutarProcedimientoAlmacenado(myCurso, 2);
        }


        public int Habilitar(Curso myCurso)
        {
            return EjecutarProcedimientoAlmacenado(myCurso, 3);
        }


        private int EjecutarProcedimientoAlmacenado(Curso myCurso, int tipoGrabacion)
        {
            var myQuery = this.DefinirObjetoConsultaAccion("spProcesarCurso");
            myQuery.AgregarParametro(":pIdCurso", myCurso.Id_Curso, DbType.Int32);
            myQuery.AgregarParametro(":pNombreCurso", myCurso.Nombre_Curso, DbType.String);
            myQuery.AgregarParametro(":pEstablecimiento", myCurso.Establecimiento, DbType.String);
            myQuery.AgregarParametro(":pIdRepresentante", myCurso.RepresentanteCurso.Id_Representante, DbType.Int32);
            myQuery.AgregarParametro(":pRepresentante", myCurso.RepresentanteCurso.nombre_representante, DbType.String);
            myQuery.AgregarParametro(":pEmail", myCurso.RepresentanteCurso.Email, DbType.String);
            myQuery.AgregarParametro(":pIdTipoRepresentante", myCurso.RepresentanteCurso.Id_TipoRepresentante, DbType.Int32);
            myQuery.AgregarParametro(":pTipoAccion", tipoGrabacion, DbType.Int32);
            return myQuery.EjecutarConsulta();
        }


        public DataTable ObtenerListaDeCursos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT cur.id_curso AS Id, cur.nombre_curso AS Curso, cur.establecimiento_curso AS Establecimiento, ");
            sql.Append("cur.id_representante, rep.nombre_representante AS Representante, rep.id_tiporepresentante, trep.descripcion AS Cargo, cli.id_cliente,  ");
            sql.Append("CASE WHEN cur.habilitado=1 THEN 'Si' ELSE 'No' END AS Habilitado, rep.email ");
            sql.Append("FROM curso cur JOIN representante REP ON cur.id_representante = REP.id_representante ");
            sql.Append("join tiporep trep on rep.id_tiporepresentante = trep.id_tiporepresentante ");
            sql.Append("join cliente cli on cur.id_curso=cli.id_curso ");
            sql.Append("WHERE cur.id_curso > 0 ");
            sql.Append("order by cur.id_curso ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerTiposDeRepresentante()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from tiporep order by id_tiporepresentante ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerAvancesDeCursos()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT  cli.id_cliente AS Id, ");
            sql.Append("cur.nombre_curso AS Curso, ");
            sql.Append("cur.establecimiento_curso AS Establecimiento, ");
            sql.Append("REP.nombre_representante AS Representante, ");
            sql.Append("tpr.descripcion AS Cargo,  ");
            sql.Append("to_char(pag.saldo, 'L999G999G999') AS Total_a_pagar, ");
            sql.Append("to_char(x.Cancelado, 'L999G999G999') AS Cancelado, ");
            sql.Append("to_char((pag.saldo-x.Cancelado), 'L999G999G999') AS Diferencia, ");
            sql.Append("round((pag.saldo/x.Cancelado)*100)||'%' AS Porcentaje_avance ");
            sql.Append("FROM cliente cli JOIN pago pag ON cli.id_cliente=pag.id_cliente ");
            sql.Append("JOIN curso cur ON cli.id_curso=cur.id_curso ");
            sql.Append("JOIN representante REP ON REP.id_representante=cur.id_representante  ");
            sql.Append("join tiporep tpr on tpr.id_tiporepresentante=rep.id_tiporepresentante  ");
            sql.Append("JOIN   ");
            sql.Append("(SELECT id_pago, SUM(monto_pago) AS Cancelado ");
            sql.Append("FROM detalle_pago  ");
            sql.Append("GROUP BY id_pago  ");
            sql.Append(") x  ON pag.id_pago=x.id_pago ");
            sql.Append("order by cli.id_cliente ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerAvancesDeCursos(int idCliente)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT  cli.id_cliente AS Id, ");
            sql.Append("cur.nombre_curso AS Curso, ");
            sql.Append("cur.establecimiento_curso AS Establecimiento, ");
            sql.Append("REP.nombre_representante AS Representante, ");
            sql.Append("tpr.descripcion AS Cargo,  ");
            sql.Append("to_char(pag.saldo, 'L999G999G999') AS Total_a_pagar, ");
            sql.Append("to_char(x.Cancelado, 'L999G999G999') AS Cancelado, ");
            sql.Append("to_char((pag.saldo-x.Cancelado), 'L999G999G999') AS Diferencia, ");
            sql.Append("round((pag.saldo/x.Cancelado)*100)||'%' AS Porcentaje_avance ");
            sql.Append("FROM cliente cli JOIN pago pag ON cli.id_cliente=pag.id_cliente ");
            sql.Append("JOIN curso cur ON cli.id_curso=cur.id_curso ");
            sql.Append("JOIN representante REP ON REP.id_representante=cur.id_representante  ");
            sql.Append("join tiporep tpr on tpr.id_tiporepresentante=rep.id_tiporepresentante  ");
            sql.Append("JOIN   ");
            sql.Append("(SELECT id_pago, SUM(monto_pago) AS Cancelado ");
            sql.Append("FROM detalle_pago  ");
            sql.Append("GROUP BY id_pago  ");
            sql.Append(") x  ON pag.id_pago=x.id_pago ");
            sql.Append("WHERE cli.id_cliente=:pIdCliente ");
            sql.Append("order by cli.id_cliente ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pIdCliente", idCliente, DbType.Int32);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }















    }
}
