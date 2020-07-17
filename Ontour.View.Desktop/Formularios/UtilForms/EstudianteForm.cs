using System;
using Ontour.Domain.Clases;
using Ontour.Business.Validation;
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

namespace Ontour.View.Desktop.Formularios.UtilForms
{
    public partial class EstudianteForm : MetroForm
    {

        private DatosEstudiante misDatos;
        public Estudiante Alumno { get; set; }


        public EstudianteForm()
        {
            InitializeComponent();
        }

        private void EstudianteForm_Load(object sender, EventArgs e)
        {
            this.misDatos = DatosEstudiante.AbrirDatosEstudiante();
            this.parentezcoComboBox.BeginUpdate();
            this.parentezcoComboBox.DataSource = this.misDatos.ObtenerTiposDeApoderados();
            this.parentezcoComboBox.DisplayMember = "descripcion";
            this.parentezcoComboBox.ValueMember = "id_tipoapoderado";
            this.parentezcoComboBox.EndUpdate();
            if (this.Alumno != null)
            {
                this.rutEstudianteTextBox.Text = this.Alumno.RutEstudiante;
                this.nombreEstudianteTextBox.Text = Alumno.Nombre;
                this.apellidosEstudianteTextBox.Text = this.Alumno.Apellidos;
                this.rutApoderadoTextBox.Text = this.Alumno.Apoderado.Rut;
                this.nombreApoderadoTextBox.Text = this.Alumno.Apoderado.Nombre;
                this.apellidosApoderadoTextBox.Text = this.Alumno.Apoderado.Apellidos;
                this.emailTextBox.Text = this.Alumno.Apoderado.Email;
                this.parentezcoComboBox.Text = this.Alumno.Apoderado.Tipo;
            }
            else
            {
                this.Alumno = new Estudiante();
                this.rutEstudianteTextBox.Text = string.Empty;
                this.nombreEstudianteTextBox.Text = string.Empty;
                this.apellidosEstudianteTextBox.Text = string.Empty;
                this.rutApoderadoTextBox.Text = string.Empty;
                this.nombreApoderadoTextBox.Text = string.Empty;
                this.apellidosApoderadoTextBox.Text = string.Empty;
                this.emailTextBox.Text = string.Empty;
                this.parentezcoComboBox.SelectedIndex = 0;
            }
            this.rutEstudianteTextBox.Focus();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidarDatos()) return;
            this.Alumno.RutEstudiante = this.rutEstudianteTextBox.Text;
            this.Alumno.Nombre = this.nombreEstudianteTextBox.Text;
            this.Alumno.Apellidos = this.apellidosEstudianteTextBox.Text;
            this.Alumno.Apoderado.Rut = this.rutApoderadoTextBox.Text;
            this.Alumno.Apoderado.Nombre = this.nombreApoderadoTextBox.Text;
            this.Alumno.Apoderado.Apellidos = this.apellidosApoderadoTextBox.Text;
            this.Alumno.Apoderado.Email = this.emailTextBox.Text;
            this.Alumno.Apoderado.Id_Tipo = int.Parse(this.parentezcoComboBox.SelectedValue.ToString());
            this.Alumno.Apoderado.Tipo = this.parentezcoComboBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private bool ValidarDatos()
        {
            RutValidator myValidador = RutValidator.CrearValidador(this.rutEstudianteTextBox.Text);
            myValidador.Validar();
            if (myValidador.ErrorValidacion)
            {
                MessageBox.Show(myValidador.MensajeError, "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.rutEstudianteTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.nombreEstudianteTextBox.Text))
            {
                MessageBox.Show("El nombre del alumno no puede quedar vacío", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreEstudianteTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.apellidosEstudianteTextBox.Text))
            {
                MessageBox.Show("Los apellidos del alumno no puede quedar vacío", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.apellidosEstudianteTextBox.Focus();
                return false;
            }
            myValidador = RutValidator.CrearValidador(this.rutApoderadoTextBox.Text);
            myValidador.Validar();
            if (myValidador.ErrorValidacion)
            {
                MessageBox.Show(myValidador.MensajeError, "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.rutApoderadoTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.nombreApoderadoTextBox.Text))
            {
                MessageBox.Show("El nombre del apoderado no puede quedar vacío", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreApoderadoTextBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.apellidosApoderadoTextBox.Text))
            {
                MessageBox.Show("Los apellidos del apoderado no puede quedar vacío", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.apellidosApoderadoTextBox.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(this.emailTextBox.Text))
            {
                EmailValidator myEmailValidador = EmailValidator.CrearValidador(this.emailTextBox.Text);
                myEmailValidador.Validar();
                if (myValidador.ErrorValidacion)
                {
                    MessageBox.Show(myValidador.MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.emailTextBox.Focus();
                    return false;
                }
            }
            return true;
        }






    }
}
