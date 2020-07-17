using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Cliente
{
    public partial class EstadoDelCursoForm : MetroForm
    {

        private DatosEstudiante misDatos;
        private int idTour;
        private int idCurso;

        public EstadoDelCursoForm()
        {
            InitializeComponent();
        }

        private void EstadoDelCursoForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosEstudiante.AbrirDatosEstudiante();
            this.MostrarDatosCurso();
            this.MostrarProducto();
            this.MostrarInfoDePago();
        }

        private void volverLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void mostrarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintDialog myPrinter = new PrintDialog();
            myPrinter.ShowDialog();
        }


        private void MostrarDatosCurso()
        {
            DataTable myTable = this.misDatos.ObtenerInformacionEstudiante(Usuario.RutEstudiante);
            if (myTable.Rows.Count.Equals(0)) return;
            DataRow myRow = myTable.Rows[0];
            this.cursoTextBox.Text = myRow["Curso"].ToString();
            this.establecimientoTextBox.Text = myRow["Establecimiento"].ToString();
            this.representanteTextBox.Text = myRow["Representante"].ToString();
            this.cargoTextBox.Text = myRow["Cargo"].ToString();
            this.idTour = int.Parse(myRow["Id_Cliente"].ToString());
            this.idCurso = int.Parse(myRow["Id_Curso"].ToString());
        }


        private void MostrarProducto()
        {
            Tour myTour = DatosTour.AbrirDatosTour().ObtenerTourCliente(this.idTour);
            if (myTour != null)
            {
                this.productoGroupBox.Text = "Producto asociado";
                this.productoTextBox.Text = myTour.Nombre;
                this.valorTextBox.Text = myTour.Valor.ToString();
            }
            else
            {
                this.productoGroupBox.Text = "No hay información de productos asociados";
                this.productoTextBox.Text = string.Empty;
                this.valorTextBox.Text = string.Empty;
            }
        }


        private void MostrarValores()
        {
            DataTable myDataTable = DatosCurso.AbrirDatosCurso().ObtenerAvancesDeCursos(this.idCurso);
            if (myDataTable.Rows.Count.Equals(0)) {
                this.totalTextBox.Text = "$0";
                this.montoCanceladoTextBox.Text = "$0";
                this.diferenciaTextBox.Text = "$0";
                return;
            }
            DataRow myRow = myDataTable.Rows[0];
            this.totalTextBox.Text = myRow["Total_a_pagar"].ToString();
            this.montoCanceladoTextBox.Text = myRow["Total_a_pagar"].ToString();
            this.diferenciaTextBox.Text = myRow["Diferencia"].ToString();
        }


        private void MostrarInfoDePago()
        {
            try
            {
                DatosPago misPagos = DatosPago.AbrirDatosPago();
                Pago myPago = misPagos.ObtenerInformacionDePagoCliente(this.idTour);
                if (myPago != null)
                {
                    this.detalleGroupBox.Text = "Detalle de pagos";
                    this.detalleDataGridView.DataSource = null;
                    this.detalleDataGridView.DataSource = misPagos.ObtenerDetalleDEPago(myPago.Id_Pago);
                }
                else
                {
                    this.detalleGroupBox.Text = "No hay detalle de pagos registrados";
                    this.detalleDataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

















    }
}
