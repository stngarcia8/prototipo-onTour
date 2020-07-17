using System.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using OnTour.Data.Dao;

namespace Ontour.Business.Data
{
    public class DatosPago
    {

        private DatosPago() { }


        public static DatosPago AbrirDatosPago()
        {
            return new DatosPago();
        }


        public Pago ObtenerInformacionDePagoCliente(int idCliente)
        {
            Pago myPago = new Pago();
            DataTable myDataTable = DaoPago.CrearDao().ObtenerInformacionPagoCliente(idCliente);
            if (myDataTable.Rows.Count.Equals(0)) return null;
            DataRow myRow = myDataTable.Rows[0];
            myPago.Id_Pago = int.Parse(myRow["ID"].ToString());
            myPago.DiaVencimiento = int.Parse(myRow["Dia"].ToString());
            myPago.Saldo = double.Parse(myRow["Saldo"].ToString());
            myPago.CuotasPactadas = int.Parse(myRow["Cuotas"].ToString());
            return myPago;
        }


        public DataTable ObtenerDetalleDEPago(int idPago)
        {
            try
            {
                return DaoPago.CrearDao().ObtenerDetalleDePagos(idPago);
            } catch
            {
                throw;
            }
        }




    }
}
