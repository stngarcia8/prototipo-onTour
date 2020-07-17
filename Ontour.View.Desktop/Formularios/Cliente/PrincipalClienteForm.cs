using System;
using Ontour.View.Desktop.Formularios.Cliente;
using Ontour.Business.Data;
using Ontour.Domain.Clases;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ontour.View.Desktop.Formularios.Cliente
{
    public partial class PrincipalClienteForm : MetroForm
    {
        public PrincipalClienteForm()
        {
            InitializeComponent();
        }

        private void cerrarSesionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void PrincipalClienteForm_Load(object sender, EventArgs e)
        {
            DatosEstudiante misDatos = DatosEstudiante.AbrirDatosEstudiante();
            DataTable myDataTable = misDatos.ObtenerInformacionEstudiante(Usuario.RutEstudiante);
            if (myDataTable.Rows.Count.Equals(0)) return;
            DataRow myRow = myDataTable.Rows[0];
            this.usuarioLabel.Text = myRow["Nombre_apoderado"].ToString() + "   (" + myRow["Parentezco"].ToString() + ")";
            this.estudianteLabel.Text = (Usuario.Tipo.Equals(9) ? "Apoderado" : "Representante") + " de " + myRow["Nombre_estudiante"].ToString();
            this.cursoLabel.Text = (Usuario.Tipo.Equals(9) ? "Alumno" : "Representante") + " del curso " + myRow["Curso"].ToString() + " del establecimiento " + myRow["Establecimiento"].ToString();
            this.representanteLabel.Text = "Representante del curso: " + myRow["Representante"].ToString() + "  (" + myRow["Cargo"].ToString();
        }

        private void estadoCursoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EstadoDelCursoForm myForm = new EstadoDelCursoForm();
            myForm.ShowDialog();
        }
    }
}
