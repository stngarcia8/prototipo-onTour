using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using Ontour.Business.Data;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using Ontour.View.Desktop.Formularios.UtilForms;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class ActividadesForm : MetroForm
    {

        private DatosActividad misDatos;
        private int idActividad;
        private IList<int> myIdList;
        private TipoGrabacion estadoGrabacion;

        public ActividadesForm()
        {
            InitializeComponent();
        }


        private void ActividadesForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosActividad.AbrirDatosActividad();
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
            this.idActividad = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }


        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nueva actividad";
            this.ActivarDatos();
            this.nombreTextBox.Enabled = true;
            this.LimpiarControles();
        }


        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando actividad";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.nombreTextBox.Enabled = true;
            this.habilitarCheckBox.Visible = false;
            this.ActivarDatos();
        }


        private void inhabilitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Inhabilitar/Habilitar actividad";
            this.estadoGrabacion = (this.habilitarCheckBox.CheckState.Equals(CheckState.Checked) ? TipoGrabacion.Inhabilitar : TipoGrabacion.Habilitar);
            this.nombreTextBox.Enabled = false;
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeActividades();
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


        private void LimpiarControles()
        {
            this.nombreTextBox.Text = string.Empty;
            this.destinosDataGridView.DataSource = null;
            this.habilitarCheckBox.Visible = false;
            this.idActividad = 0;
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
            Actividad myActividad = new Actividad();
            myActividad.Descripcion = this.nombreTextBox.Text;
            myActividad.IdActividad = this.idActividad;
            this.GenerarListaDeIds();
            try
            {
                misDatos.Grabar(estadoGrabacion, myActividad, this.myIdList);
                MessageBox.Show("La actividad " + this.nombreTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.idActividad = int.Parse(myRow.Cells[0].Value.ToString());
            this.nombreTextBox.Text = myRow.Cells[1].Value.ToString();
            this.destinosDataGridView.DataSource = null;
            this.destinosDataGridView.DataSource = misDatos.ObtenerListadoDeDestinos(this.idActividad);
            this.GenerarListaDeIds();
            this.habilitarCheckBox.Checked = (myRow.Cells[2].Value.ToString() == "Si" ? true : false);
        }


        private void GenerarListaDeIds()
        {
            this.myIdList = new List<int>();
            foreach(DataGridViewRow myRow in this.destinosDataGridView.Rows)
            {
                this.myIdList.Add(int.Parse(myRow.Cells[0].Value.ToString()));
            }
        }


        private void agregarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SeleccionDeDestinosForm myForm = new SeleccionDeDestinosForm();
            myForm.IdList = this.myIdList;
            myForm.ShowDialog();
            if(myForm.DialogResult.Equals(DialogResult.OK))
            {
                this.destinosDataGridView.DataSource = null;
                this.destinosDataGridView.DataSource = myForm.Resultados;
                this.GenerarListaDeIds();
                if (this.destinosDataGridView.Rows.Count>0)
                {
                    this.destinosDataGridView.Rows[0].Selected = true;
                    this.destinosDataGridView.CurrentCell = this.destinosDataGridView.Rows[0].Cells[0];
                    this.destinosDataGridView.Focus();
                }
            }
        }

        private void quitarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.destinosDataGridView.Rows.Count.Equals(0)) return;
            DataGridViewRow myRow = this.destinosDataGridView.CurrentRow;
            if (myRow == null) return;
            this.destinosDataGridView.Rows.Remove(myRow);
        }

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.datosLabel.Text = "Editando actividad";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.nombreTextBox.Enabled = true;
            this.habilitarCheckBox.Visible = false;
            this.ActivarDatos();
        }
    }
}
