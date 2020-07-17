using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class DestinosForm : MetroForm
    {

        private DatosDestino misDatos;
        private int idDestino;
        private TipoGrabacion estadoGrabacion;

        public DestinosForm()
        {
            InitializeComponent();
        }

        private void DestinosForm_Load(object sender, EventArgs e)
        {
            DatosTransporte datosTransporte = DatosTransporte.AbrirDatosTransporte();
            this.transporteComboBox.DataSource = datosTransporte.ObtenerListadoDeTransporte();
            this.transporteComboBox.DisplayMember = "Transporte";
            this.transporteComboBox.ValueMember = "ID";
            this.misDatos = DatosDestino.AbrirDatosDestino();
            this.editarLinkLabel.Enabled = false;
            this.inhabilitarLinkLabel.Enabled = false;
            this.habilitarCheckBox.Visible = false;
            this.CargaListaEnGrillaDeDatos();
            this.estadoGrabacion = TipoGrabacion.None;
            this.ActivarListado();
        }


        private void listarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ActivarListado();
            this.CargaListaEnGrillaDeDatos();
            this.idDestino = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }


        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nuevo destino";
            this.ActivarDatos();
            this.HabilitarControles(true);
            this.LimpiarControles();
        }


        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando destino";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.HabilitarControles(true);
            this.ActivarDatos();
        }


        private void inhabilitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Inhabilitar/Habilitar destino";
            this.estadoGrabacion = (this.habilitarCheckBox.CheckState.Equals(CheckState.Checked) ? TipoGrabacion.Inhabilitar : TipoGrabacion.Habilitar);
            this.HabilitarControles(false);
            this.ActivarDatos();
            this.habilitarCheckBox.Focus();
        }


        private void volverLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void CargaListaEnGrillaDeDatos()
        {
            try
            {
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeDestinos();
                this.OcultarColumnas();
                if (this.listadoDataGridView.Rows.Count > 0)
                {
                    this.listadoDataGridView.Rows[0].Selected = true;
                    this.listadoDataGridView.CurrentCell = this.listadoDataGridView.Rows[0].Cells[0];
                    this.listadoDataGridView.Focus();
                }
                this.editarLinkLabel.Enabled = (this.listadoDataGridView.Rows.Count.Equals(0) ? false : true);
                this.inhabilitarLinkLabel.Enabled = (this.listadoDataGridView.Rows.Count.Equals(0) ? false : true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OcultarColumnas()
        {
            this.listadoDataGridView.Columns[5].Visible = false;
            this.listadoDataGridView.Columns[6].Visible = false;
        }


        private void HabilitarControles(bool estado)
        {
            this.lugarTextBox.Enabled = estado;
            this.guiaTextBox.Enabled = estado;
            this.inicioDateTimePicker.Enabled = estado;
            this.terminoDateTimePicker.Enabled = estado;
            this.transporteComboBox.Enabled = estado;
            this.habilitarCheckBox.Visible = !estado; ;
        }


        private void LimpiarControles()
        {
            this.lugarTextBox.Text = string.Empty;
            this.guiaTextBox.Text = string.Empty;
            this.inicioDateTimePicker.Value = DateTime.Today;
            this.terminoDateTimePicker.Value = DateTime.Today;
            this.duracionTextBox.Text = "0";
            this.transporteComboBox.SelectedIndex = 0;
            this.habilitarCheckBox.Visible = false;
            this.idDestino = 0;
            this.estadoGrabacion = TipoGrabacion.Agregar;
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


        private void grabarButton_Click(object sender, EventArgs e)
        {
            if (this.estadoGrabacion.Equals(TipoGrabacion.None)) return;
            if (string.IsNullOrEmpty(this.lugarTextBox.Text))
            {
                MessageBox.Show("El lugar de destino no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.lugarTextBox.Focus();
                return;
            }
            Destino myDestino = new Destino();
            myDestino.IdDestino = this.idDestino;
            myDestino.Lugar = this.lugarTextBox.Text;
            myDestino.Guia = this.guiaTextBox.Text;
            myDestino.Inicio = this.inicioDateTimePicker.Value;
            myDestino.Termino = this.terminoDateTimePicker.Value;
            myDestino.Duración = 0; 
            myDestino.IdTransporte= int.Parse(this.transporteComboBox.SelectedValue.ToString());
            try
            {
                misDatos.Grabar(estadoGrabacion, myDestino);
                MessageBox.Show("El destino " + this.lugarTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargaListaEnGrillaDeDatos();
                    this.ActivarListado();
                    this.listadoDataGridView.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.datosMetroPanel.Visible = false;
            this.listadoMetroPanel.Visible = true;
            this.listadoDataGridView.Focus();
        }

        private void listadoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null) return;
            this.idDestino = int.Parse(myRow.Cells[0].Value.ToString());
            this.lugarTextBox.Text = myRow.Cells[1].Value.ToString();
            this.guiaTextBox.Text = myRow.Cells[2].Value.ToString();
            this.inicioDateTimePicker.Value = DateTime.Parse(myRow.Cells[3].Value.ToString());
            this.terminoDateTimePicker.Value = DateTime.Parse(myRow.Cells[4].Value.ToString());
            this.duracionTextBox.Text = myRow.Cells[5].Value.ToString();
            this.transporteComboBox.Text = myRow.Cells[7].Value.ToString();
            this.habilitarCheckBox.Checked = (myRow.Cells[8].Value.ToString() == "Si" ? true : false);
        }


        private void ObtenerDuracion()
        {
            this.duracionTextBox.Text = this.terminoDateTimePicker.Value.Subtract(this.inicioDateTimePicker.Value).ToString(); 
        }

        private void inicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ObtenerDuracion();
        }

        private void terminoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ObtenerDuracion();
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.datosLabel.Text = "Editando destino";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.HabilitarControles(true);
            this.ActivarDatos();
        }
    }
}
