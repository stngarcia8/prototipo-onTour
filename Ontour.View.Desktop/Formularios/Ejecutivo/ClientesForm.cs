using System;
using Ontour.View.Desktop.Formularios.UtilForms;
using Ontour.Business.Enumerations;
using Ontour.Domain.Clases;
using Ontour.Business.Data;
using MetroFramework;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontour.View.Desktop.Formularios.Ejecutivo
{
    public partial class ClientesForm : MetroForm
    {

        private DatosCurso misDatos;
        private int idCliente;
        private TipoGrabacion estadoGrabacion;
        private DataTable alumnosDataTable;

        public ClientesForm()
        {
            InitializeComponent();
        }


        private void ClientesForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosCurso.AbrirDatosCurso();
            this.tipoRepresentanteComboBox.BeginUpdate();
            this.tipoRepresentanteComboBox.DataSource = misDatos.ObtenerTiposDeRepresentantes();
            this.tipoRepresentanteComboBox.DisplayMember = "descripcion";
            this.tipoRepresentanteComboBox.ValueMember = "id_tiporepresentante";
            this.tipoRepresentanteComboBox.EndUpdate();
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
            this.idCliente = 0;
            this.estadoGrabacion = TipoGrabacion.None;
        }


        private void nuevoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Nuevo cliente";
            this.ActivarDatos();
            this.HabilitarControles(true);
            this.LimpiarControles();
            this.nombreCursoTextBox.Focus();
        }


        private void editarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.datosLabel.Text = "Editando cliente";
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
                this.listadoDataGridView.DataSource = misDatos.ObtenerListadoDeCursos();
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
            this.listadoDataGridView.Columns[3].Visible = false;
            this.listadoDataGridView.Columns[5].Visible = false;
            this.listadoDataGridView.Columns[7].Visible = false;
            this.listadoDataGridView.Columns[9].Visible = false;
        }


        private void HabilitarControles(bool estado)
        {
            this.nombreCursoTextBox.Enabled = estado;
            this.establecimientoTextBox.Enabled = estado;
            this.representanteTextBox.Enabled = estado;
            this.tipoRepresentanteComboBox.Enabled = estado;
            this.habilitarCheckBox.Visible = !estado;
        }


        private void LimpiarControles()
        {
            this.nombreCursoTextBox.Text = string.Empty;
            this.establecimientoTextBox.Text = string.Empty;
            this.representanteTextBox.Text = string.Empty;
            this.representanteTextBox.Tag = "0";
            this.tipoRepresentanteComboBox.SelectedIndex = 0;
            this.emailTextBox.Text = string.Empty;
            this.habilitarCheckBox.Visible = false;
            this.idCliente = 0;
            this.CrearDataTable();
            this.alumnosDataGridView.DataSource = this.alumnosDataTable;
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
            if (!this.ValidarControles()) return;
            Curso myCurso = new Curso();
            myCurso.Id_Curso = this.idCliente;
            myCurso.Nombre_Curso = this.nombreCursoTextBox.Text;
            myCurso.Establecimiento = this.establecimientoTextBox.Text;
            myCurso.RepresentanteCurso.Id_Representante = int.Parse(this.representanteTextBox.Tag.ToString());
            myCurso.RepresentanteCurso.nombre_representante = this.representanteTextBox.Text;
            myCurso.RepresentanteCurso.Id_TipoRepresentante = int.Parse(this.tipoRepresentanteComboBox.SelectedValue.ToString());
            myCurso.RepresentanteCurso.Descripcion = this.tipoRepresentanteComboBox.Text;
            myCurso.RepresentanteCurso.Email = this.emailTextBox.Text;
            if (this.alumnosDataGridView.Rows.Count > 0)
            {
                foreach(DataGridViewRow myRow in this.alumnosDataGridView.Rows)
                {
                    myCurso.AgregarEstudiante(this.DataTableToEstudiante(myRow));
                }
            }
            try
            {
                misDatos.Grabar(estadoGrabacion, myCurso);
                MessageBox.Show("El curso  " + this.nombreCursoTextBox.Text + " ha sido almacenado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.listadoDataGridView.Rows.Count.Equals(0)) return;
            this.datosLabel.Text = "Editando cliente";
            this.estadoGrabacion = TipoGrabacion.Editar;
            this.ActivarDatos();
            this.HabilitarControles(true);
        }



        private void listadoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null) return;
            this.idCliente = int.Parse(myRow.Cells[0].Value.ToString());
            this.nombreCursoTextBox.Text = myRow.Cells[1].Value.ToString(); 
            this.establecimientoTextBox.Text = myRow.Cells[2].Value.ToString();
            this.representanteTextBox.Tag= myRow.Cells[3].Value.ToString();
            this.representanteTextBox.Text = myRow.Cells[4].Value.ToString();
            this.tipoRepresentanteComboBox.Text = myRow.Cells[6].Value.ToString();
            this.habilitarCheckBox.Checked = (myRow.Cells[8].Value.ToString() == "Si" ? true : false);
            this.emailTextBox.Text =(string.IsNullOrEmpty(myRow.Cells[9].Value.ToString())?string.Empty: myRow.Cells[9].Value.ToString());
            DatosEstudiante datosEstudiantes = DatosEstudiante.AbrirDatosEstudiante();
            this.alumnosDataTable= datosEstudiantes.ObtenerNominaDeCurso(this.idCliente);
            this.alumnosDataGridView.DataSource = null;
            this.alumnosDataGridView.DataSource = alumnosDataTable;
            this.OcultarColumnasAlumnos();
            if (this.alumnosDataGridView.Rows.Count > 0)
            {
                this.alumnosDataGridView.Rows[0].Selected = true;
                this.alumnosDataGridView.CurrentCell = this.alumnosDataGridView.Rows[0].Cells[0];
            }
        }


        private void OcultarColumnasAlumnos()
        {
            foreach(DataGridViewColumn myColumn in this.alumnosDataGridView.Columns)
            {
                if (myColumn.Index > 2) myColumn.Visible = false;
            }
        }


        private void agregarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EstudianteForm myForm = new EstudianteForm();
            myForm.Alumno = null;
            myForm.ShowDialog();
            if (myForm.DialogResult.Equals(DialogResult.OK))
            {
                this.EstudianteToDataTable(myForm.Alumno);
                this.alumnosDataGridView.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.alumnosDataGridView.Rows.Count.Equals(0)) return;
            DataGridViewRow myRow = this.alumnosDataGridView.CurrentRow;
            if (myRow == null) return;
            this.alumnosDataGridView.Rows.Remove(myRow);
        }


        private void EstudianteToDataTable(Estudiante myEstudiante)
        {
            DataRow myRow = this.alumnosDataTable.NewRow();
            myRow["Rut"] = myEstudiante.RutEstudiante;
            myRow["Nombre"] = myEstudiante.Nombre;
            myRow["Apellidos"] = myEstudiante.Apellidos;
            myRow["Rut_apoderado"] = myEstudiante.Apoderado.Rut;
            myRow["Nombre_apoderado"] = myEstudiante.Apoderado.Nombre;
            myRow["Apellidos_apoderado"] = myEstudiante.Apoderado.Apellidos;
            myRow["email"] = myEstudiante.Apoderado.Email;
            myRow["Id_tipo"] = myEstudiante.Apoderado.Id_Tipo;
            myRow["Parentezco"] = myEstudiante.Apoderado.Tipo;
            myRow["id_curso"] = this.idCliente;
            myRow["IdApoderado"] = myEstudiante.Apoderado.Id_Apoderado;
            this.alumnosDataTable.Rows.Add(myRow);
        }

        private void alumnosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.alumnosDataGridView.Rows.Count.Equals(0)) return;
            DataGridViewRow myRow = this.alumnosDataGridView.CurrentRow;
            if (myRow == null) return;
            EstudianteForm myForm = new EstudianteForm();
            myForm.Alumno = this.DataTableToEstudiante(myRow);
            myForm.ShowDialog();
        }


private Estudiante DataTableToEstudiante(DataGridViewRow myRow)
        {
            Estudiante myEstudiante = new Estudiante();
            myEstudiante.RutEstudiante = myRow.Cells["Rut"].Value.ToString();
            myEstudiante.Nombre = myRow.Cells["Nombre"].Value.ToString();
            myEstudiante.Apellidos = myRow.Cells["Apellidos"].Value.ToString();
            myEstudiante.Apoderado.Rut = myRow.Cells["Rut_apoderado"].Value.ToString();
            myEstudiante.Apoderado.Nombre = myRow.Cells["Nombre_apoderado"].Value.ToString();
            myEstudiante.Apoderado.Apellidos = myRow.Cells["Apellidos_apoderado"].Value.ToString();
            myEstudiante.Apoderado.Email = myRow.Cells["email"].Value.ToString();
            myEstudiante.Apoderado.Id_Tipo = int.Parse(myRow.Cells["Id_tipo"].Value.ToString());
            myEstudiante.Apoderado.Tipo = myRow.Cells["Parentezco"].Value.ToString();
            myEstudiante.Apoderado.Id_Apoderado = int.Parse(myRow.Cells["IdApoderado"].Value.ToString());
            return myEstudiante;
        }


        private bool ValidarControles()
        {
            if (string.IsNullOrEmpty(this.nombreCursoTextBox.Text))
            {
                MessageBox.Show("El nombre del curso no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreCursoTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.establecimientoTextBox.Text))
            {
                MessageBox.Show("El establecimiento no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.establecimientoTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.representanteTextBox.Text))
            {
                MessageBox.Show("El nombre del representante no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.representanteTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.emailTextBox.Text))
            {
                MessageBox.Show("El correo de contacto no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.emailTextBox.Focus();
                return false;
            }
            return true;
        }


        private void CrearDataTable()
        {
            this.alumnosDataTable = new DataTable();
            this.alumnosDataTable.Columns.Add("Rut");
            this.alumnosDataTable.Columns.Add("Nombre");
            this.alumnosDataTable.Columns.Add("Apellidos");
            this.alumnosDataTable.Columns.Add("Rut_apoderado");
            this.alumnosDataTable.Columns.Add("Nombre_apoderado");
            this.alumnosDataTable.Columns.Add("Apellidos_apoderado");
            this.alumnosDataTable.Columns.Add("email");
            this.alumnosDataTable.Columns.Add("Id_tipo");
            this.alumnosDataTable.Columns.Add("Parentezco");
            this.alumnosDataTable.Columns.Add("id_curso");
            this.alumnosDataTable.Columns.Add("IdApoderado");
        }


    }
}
