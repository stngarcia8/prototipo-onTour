using System;
using System.Text;
using System.Data;
using Ontour.Domain.Clases;
using OnTour.Data.Connection;

namespace OnTour.Data.Dao
{
    public class DaoPago : Dao
    {



        private DaoPago() : base() { }


        public static DaoPago CrearDao()
        {
            return new DaoPago();
        }


        public DataTable ObtenerInformacionPagoCliente(int idCliente)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT pg.id_pago AS ID, pg.dia_vencimiento AS Dia, pg.saldo AS Saldo, pg.cuotas_pactadas AS Cuotas ");
            sql.Append("FROM cliente CL JOIN pago pg ON CL.id_cliente = pg.id_cliente ");
            sql.Append("WHERE cl.id_cliente=:pIdCliente ");
            var myQuery = this.DefinirObjetoConsultaSeleccion(sql.ToString());
            myQuery.AgregarParametro(":pIdCliente", idCliente, DbType.Int32);
            DataTable myDataTable = myQuery.EjecutarConsulta();
            myConnection.cerrarConeccion();
            return myDataTable;
        }


        public DataTable ObtenerDetalleDePagos(int idPago)
        {
            try
            {
                return DaoPagoDetalle.CrearDao().ObtenerDetallePago(idPago);
            }
            catch { throw; }
        }















    }
}
