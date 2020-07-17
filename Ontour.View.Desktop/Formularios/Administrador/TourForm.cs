using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using Ontour.View.Desktop.Formularios.UtilForms;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class TourForm : MetroForm
    {

        private DatosTour misDatos;
        private int idTour;
        private IList<int> myIdList;
        private TipoGrabacion estadoGrabacion;

        public TourForm()
        {
            InitializeComponent();
        }

        private void TourForm_Load(object sender, EventArgs e)
        {
            DatosHotel misDatosHotel = DatosHotel.AbrirDatosHotel();
            this.hotelComboBox.DataSource = misDatosHotel.ObtenerListadoDeHotel();
            this.hotelComboBox.DisplayMember = "Nombre";
            this.hotelComboBox.ValueMember = "Id";
            DatosTransporte datosTransporte = DatosTransporte.AbrirDatosTransporte();
            this.transporteComboBox.DataSource = datosTransporte.ObtenerListadoDeTransporte();
            this.transporteComboBox.DisplayMember = "Transporte";
            this.transporteComboBox.ValueMember = "ID";
            this.misDatos = DatosTour.AbrirDatosTour();
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
            this.idTour = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }

        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nuevo tour";
            this.ActivarDatos();
            this.HabilitarControles(true);
            this.LimpiarControles();
        }

        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando tour";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.HabilitarControles(true);
            this.ActivarDatos();
        }

        private void inhabilitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Inhabilitar/Habilitar actividad";
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeTours();
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
            this.listadoDataGridView.Columns[4].Visible = false;
        }


        private void LimpiarControles()
        {
            this.nombreTextBox.Text = string.Empty;
            this.hotelComboBox.SelectedIndex = 0;
            this.actividadesDataGridView.DataSource = null;
            this.transporteComboBox.SelectedIndex = 0;
            this.valorTextBox.Text = string.Empty;
            this.habilitarCheckBox.Visible = false;
            this.idTour = 0;
            this.estadoGrabacion = TipoGrabacion.Agregar;
        }


        private void HabilitarControles(bool estado)
        {
            this.nombreTextBox.Enabled = estado;
            this.hotelComboBox.Enabled = estado;
            this.actividadesDataGridView.Enabled = estado;
            this.transporteComboBox.Enabled = estado;
            this.habilitarCheckBox.Visible = !estado;
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
            if(string.IsNullOrEmpty(this.valorTextBox.Text))
            {
                MessageBox.Show("El valor del tour no puede quedar vacío.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.valorTextBox.Focus();
                return;
            }
            Tour myTour = new Tour();
            myTour.Nombre= this.nombreTextBox.Text;
            myTour.Id_Tour= this.idTour;
            myTour.Id_Hotel = int.Parse(this.hotelComboBox.SelectedValue.ToString() );
            myTour.Id_Transporte = int.Parse(this.transporteComboBox.SelectedValue.ToString());
            myTour.Valor = double.Parse(this.valorTextBox.Text);
            this.GenerarListaDeIds();
            try
            {
                misDatos.Grabar(estadoGrabacion, myTour, this.myIdList);
                MessageBox.Show("El tour " + this.nombreTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.idTour = int.Parse(myRow.Cells[0].Value.ToString());
            this.nombreTextBox.Text = myRow.Cells[1].Value.ToString();
            this.hotelComboBox.Text= myRow.Cells[3].Value.ToString();
            this.transporteComboBox.Text= myRow.Cells[5].Value.ToString();
            this.actividadesDataGridView.DataSource = null;
            this.actividadesDataGridView.DataSource = misDatos.ObtenerListadoDeActividades(this.idTour);
            this.GenerarListaDeIds();
            this.valorTextBox.Text = myRow.Cells[6].Value.ToString();
            this.habilitarCheckBox.Checked = (myRow.Cells[7].Value.ToString() == "Si" ? true : false);
        }


        private void GenerarListaDeIds()
        {
            this.myIdList = new List<int>();
            foreach (DataGridViewRow myRow in this.actividadesDataGridView.Rows)
            {
                this.myIdList.Add(int.Parse(myRow.Cells[0].Value.ToString()));
            }
        }

        private void agregarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SeleccionDeActividadesForm myForm = new SeleccionDeActividadesForm();
            myForm.IdList = this.myIdList;
            myForm.ShowDialog();
            if (myForm.DialogResult.Equals(DialogResult.OK))
            {
                this.actividadesDataGridView.DataSource = null;
                this.actividadesDataGridView.DataSource = myForm.Resultados;
                this.GenerarListaDeIds();
                if (this.actividadesDataGridView.Rows.Count > 0)
                {
                    this.actividadesDataGridView.Rows[0].Selected = true;
                    this.actividadesDataGridView.CurrentCell = this.actividadesDataGridView.Rows[0].Cells[0];
                    this.actividadesDataGridView.Focus();
                }
            }
        }

        private void quitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.actividadesDataGridView.Rows.Count.Equals(0)) return;
            DataGridViewRow myRow = this.actividadesDataGridView.CurrentRow;
            if (myRow == null) return;
            this.actividadesDataGridView.Rows.Remove(myRow);
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.datosLabel.Text = "Editando tour";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.HabilitarControles(true);
            this.ActivarDatos();
        }

        private void valorTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double valor = double.Parse(this.valorTextBox.Text);
                if(valor<0)
                {
                    MessageBox.Show("El valor del tour debe ser mayor o igual a cero.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                } else
                {
                    e.Cancel = false;
                }
            }
            catch
            {
                MessageBox.Show("El valor del tour solo acepta números.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }
    }
}
