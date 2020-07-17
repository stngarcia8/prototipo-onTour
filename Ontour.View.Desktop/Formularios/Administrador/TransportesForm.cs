using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class TransportesForm : MetroForm
    {

        private DatosTransporte misDatos;
        private int idTransporte;
        private TipoGrabacion estadoGrabacion;

        public TransportesForm()
        {
            InitializeComponent();
        }

        private void TransportesForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosTransporte.AbrirDatosTransporte();
            this.editarLinkLabel.Enabled = false;
            this.inhabilitarLinkLabel.Enabled = false;
            this.habilitarCheckBox.Visible = false;
            this.tipoComboBox.DataSource = misDatos.ObtenerTiposDeTransporte();
            this.tipoComboBox.DisplayMember = "descripcion";
            this.tipoComboBox.ValueMember = "id_tipotransporte";
            this.tipoComboBox.SelectedIndex = 0;
            this.CargaListaEnGrillaDeDatos();
            this.estadoGrabacion = TipoGrabacion.None;
            this.ActivarListado();
        }


        private void listarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ActivarListado();
            this.CargaListaEnGrillaDeDatos();
            this.idTransporte = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }


        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nuevo transporte";
            this.ActivarDatos();
            this.nombreTextBox.Enabled = true;
            this.tipoComboBox.Enabled = true;
            this.LimpiarControles();
        }


        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando transporte";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.nombreTextBox.Enabled = true;
            this.tipoComboBox.Enabled = true;
            this.habilitarCheckBox.Visible = false;
            this.ActivarDatos();
        }


        private void inhabilitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Inhabilitar/Habilitar transporte";
            this.estadoGrabacion = (this.habilitarCheckBox.CheckState.Equals(CheckState.Checked) ? TipoGrabacion.Inhabilitar : TipoGrabacion.Habilitar);
            this.nombreTextBox.Enabled = false;
            this.tipoComboBox.Enabled = false;
            this.habilitarCheckBox.Visible = true;
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeTransporte();
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
            this.listadoDataGridView.Columns[2].Visible = false;
        }


        private void LimpiarControles()
        {
            this.nombreTextBox.Text = string.Empty;
            this.tipoComboBox.SelectedIndex = 0;
            this.habilitarCheckBox.Visible = false;
            this.idTransporte = 0;
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
            if (string.IsNullOrEmpty(this.nombreTextBox.Text))
            {
                MessageBox.Show("El nombre no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreTextBox.Focus();
                return;
            }
            Transporte myTransporte = new Transporte();
            myTransporte.Descripcion = this.nombreTextBox.Text;
            myTransporte.Id_Transporte = this.idTransporte;
            myTransporte.Id_TipoTransporte = Convert.ToInt32(this.tipoComboBox.SelectedValue.ToString());
            try
            {
                misDatos.Grabar(estadoGrabacion, myTransporte);
                MessageBox.Show("El transporte " + this.nombreTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.idTransporte = int.Parse(myRow.Cells[0].Value.ToString());
            this.nombreTextBox.Text = myRow.Cells[1].Value.ToString();
            this.tipoComboBox.Text = myRow.Cells[3].Value.ToString();
            this.habilitarCheckBox.Checked = (myRow.Cells[4].Value.ToString() == "Si" ? true : false);
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.datosLabel.Text = "Editando transporte";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.nombreTextBox.Enabled = true;
            this.tipoComboBox.Enabled = true;
            this.habilitarCheckBox.Visible = false;
            this.ActivarDatos();
        }
    }
}
