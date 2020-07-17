using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Ejecutivo
{

    public partial class ConsultaMontosAportadosForm : MetroForm
    {


        private DatosCurso misDatos;
        private int idCliente;


        public ConsultaMontosAportadosForm()
        {
            InitializeComponent();
        }


        private void ConsultaMontosAportados_Load(object sender, EventArgs e)
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
            this.idCliente = 0;
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeCursos();
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
            this.listadoDataGridView.Columns[5].Visible = false;
            this.listadoDataGridView.Columns[7].Visible = false;
            this.listadoDataGridView.Columns[8].Visible = false;
            this.listadoDataGridView.Columns[9].Visible = false;
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
            this.idCliente = int.Parse(myRow.Cells[7].Value.ToString());
            this.cursoTextBox.Text = myRow.Cells[1].Value.ToString();
            this.establecimientoTextBox.Text = myRow.Cells[2].Value.ToString();
            this.representanteTextBox.Text = myRow.Cells[4].Value.ToString();
            this.cargoTextBox.Text = myRow.Cells[6].Value.ToString();
            this.MostrarProducto();
            this.MostrarInfoDePago();
        }


        private void MostrarProducto()
        {
            Tour myTour = DatosTour.AbrirDatosTour().ObtenerTourCliente(this.idCliente);
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
                Pago myPago = misPagos.ObtenerInformacionDePagoCliente(this.idCliente);
                if (myPago != null)
                {
                    this.pagoGroupBox.Text = "Información de pago";
                    this.detalleGroupBox.Text = "Detalle de pagos";
                    this.diaVencimientoTextBox.Text = myPago.DiaVencimiento.ToString();
                    this.saldoTextBox.Text = myPago.Saldo.ToString();
                    this.cuotasPactadasTextBox.Text = myPago.CuotasPactadas.ToString();
                    this.detalleDataGridView.DataSource = null;
                    this.detalleDataGridView.DataSource = misPagos.ObtenerDetalleDEPago(myPago.Id_Pago);
                }
                else
                {
                    this.pagoGroupBox.Text = "No hay registrada información de pago";
                    this.detalleGroupBox.Text = "No hay detalle de pagos registrados";
                    this.diaVencimientoTextBox.Text = string.Empty;
                    this.saldoTextBox.Text = string.Empty;
                    this.cuotasPactadasTextBox.Text = string.Empty;
                    this.detalleDataGridView.DataSource = null;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }
}
