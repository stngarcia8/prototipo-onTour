using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoPagoDetalle : Dao
    {



        private DaoPagoDetalle() : base() { }


        public static DaoPagoDetalle CrearDao()
        {
            return new DaoPagoDetalle();
        }


        public DataTable ObtenerDetallePago(int idPago)
        {
            try
            {
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT es.rut_estudiante AS Rut, es.nombre_estudiante || ' ' || es.apellidos_estudiante AS Estudiante, dp.fecha_pago AS Fecha, dp.nro_cuota AS Cuota, ");
                    sql.Append("dp.monto_pago AS Monto, tp.descripcion AS Tipo_pago ");
                    sql.Append("FROM detalle_pago dp JOIN tipo_pago tp ON dp.id_tipopago = tp.id_tipopago ");
                    sql.Append("join estudiante es on dp.rut_beneficiario = es.rut_estudiante ");
                    sql.Append("WHERE dp.id_pago=:pIdPago ");
                    sql.Append("order by dp.rut_beneficiario, dp.fecha_pago ");
                    var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
                    myQuery.AgregarParametro("pIdPago", idPago, DbType.Int32);
                    DataTable myDataTable = myQuery.EjecutarConsulta();
                    myConnection.cerrarConeccion();
                    return myDataTable;
                }
                catch
                {
                    throw;
                }
            }
            catch
            {
                throw;
            }
        }












    }
}
