using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class HotelesForm : MetroForm
    {

        private DatosHotel misDatos;
        private int idHotel;
        private TipoGrabacion estadoGrabacion;

        public HotelesForm()
        {
            InitializeComponent();
        }


        private void HotelesForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosHotel.AbrirDatosHotel();
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
            this.idHotel = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }


        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nuevo hotel";
            this.ActivarDatos();
            this.HabilitarControles(true);
            this.LimpiarControles();
        }


        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando hotel";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.ActivarDatos();
            this.HabilitarControles(true);
        }


        private void inhabilitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Inhabilitar/Habilitar hotel";
            this.estadoGrabacion = (this.habilitarCheckBox.CheckState.Equals(CheckState.Checked) ? TipoGrabacion.Inhabilitar : TipoGrabacion.Habilitar);
            this.ActivarDatos();
            this.HabilitarControles(false);
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeHotel();
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


        private void HabilitarControles(bool estado)
        {
            this.nombreTextBox.Enabled = estado;
            this.direccionTextBox.Enabled = estado;
            this.webTextBox.Enabled = estado;
            this.telefonoTextBox.Enabled = estado;
            this.habilitarCheckBox.Visible = !estado;
        }



        private void LimpiarControles()
        {
            this.nombreTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.webTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.habilitarCheckBox.Visible = false;
            this.idHotel = 0;
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
            Hotel myHotel = new Hotel();
            myHotel.IdHotel = this.idHotel;
            myHotel.Nombre = this.nombreTextBox.Text;
            myHotel.Direccion = this.direccionTextBox.Text;
            myHotel.Web = this.webTextBox.Text;
            myHotel.Telefono = this.telefonoTextBox.Text;
            try
            {
                misDatos.Grabar(estadoGrabacion, myHotel);
                MessageBox.Show("El hotel " + this.nombreTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.idHotel = int.Parse(myRow.Cells[0].Value.ToString());
            this.nombreTextBox.Text = myRow.Cells[1].Value.ToString();
            this.direccionTextBox.Text = myRow.Cells[2].Value.ToString();
            this.webTextBox.Text = myRow.Cells[3].Value.ToString();
            this.telefonoTextBox.Text = myRow.Cells[4].Value.ToString();
            this.habilitarCheckBox.Checked = (myRow.Cells[5].Value.ToString() == "Si" ? true : false);
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.listadoDataGridView.Rows.Count.Equals(0)) return;
            this.datosLabel.Text = "Editando hotel";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.ActivarDatos();
            this.HabilitarControles(true);
        }
    }
}
