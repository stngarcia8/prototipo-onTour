using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Ejecutivo
{
    public partial class EstadoAvanceForm : MetroForm
    {

        private DatosCurso misDatos;
        private int idTour;

        public EstadoAvanceForm()
        {
            InitializeComponent();
        }

        private void EstadoAvanceForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosCurso.AbrirDatosCurso();
            this.mostrarLinkLabel.Enabled = false;
            this.CargaListaEnGrillaDeDatos();
            this.ActivarListado();
        }

        private void listarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ActivarListado();
            this.CargaListaEnGrillaDeDatos();
            this.idTour = 0;
        }

        private void mostrarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ActivarDatos();
        }

        private void volverLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void CargaListaEnGrillaDeDatos()
        {
            try
            {
                this.listadoDataGridView.DataSource = misDatos.ObtenerAvancesDeCursos();
                this.OcultarColumnas();
                if (this.listadoDataGridView.Rows.Count > 0)
                {
                    this.listadoDataGridView.Rows[0].Selected = true;
                    this.listadoDataGridView.CurrentCell = this.listadoDataGridView.Rows[0].Cells[0];
                    this.listadoDataGridView.Focus();
                }
                this.mostrarLinkLabel.Enabled = (this.listadoDataGridView.Rows.Count.Equals(0) ? false : true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OcultarColumnas()
        {
            this.listadoDataGridView.Columns[3].Visible = false;
            this.listadoDataGridView.Columns[4].Visible = false;
        }


        private void ActivarDatos()
        {
            this.listadoMetroPanel.Visible = false;
            this.datosMetroPanel.Visible = true;
        }


        private void ActivarListado()
        {
            this.datosMetroPanel.Visible = false;
            this.listadoMetroPanel.Visible = true;
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.listadoDataGridView.Rows.Count.Equals(0)) return;
            this.ActivarDatos();
        }

        private void listadoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null) return;
            this.idTour = int.Parse(myRow.Cells[0].Value.ToString());
            this.cursoTextBox.Text = myRow.Cells[1].Value.ToString();
            this.establecimientoTextBox.Text = myRow.Cells[2].Value.ToString();
            this.representanteTextBox.Text = myRow.Cells[3].Value.ToString();
            this.cargoTextBox.Text = myRow.Cells[4].Value.ToString();
            this.totalTextBox.Text = myRow.Cells[5].Value.ToString();
            this.montoCanceladoTextBox.Text = myRow.Cells[6].Value.ToString();
            this.diferenciaTextBox.Text = myRow.Cells[7].Value.ToString();
            this.MostrarProducto();
            this.MostrarInfoDePago();
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
