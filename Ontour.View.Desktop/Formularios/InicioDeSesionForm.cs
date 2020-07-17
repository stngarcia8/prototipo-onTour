using System;
using Ontour.Domain.Clases;
using Ontour.Business.Data;
using Ontour.View.Desktop.Formularios.Cliente;
using Ontour.View.Desktop.Formularios.Ejecutivo;
using Ontour.View.Desktop.Formularios.Administrador;
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

namespace Ontour.View.Desktop.Formularios
{
    public partial class InicioDeSesionForm : MetroForm
    {
        public InicioDeSesionForm()
        {
            InitializeComponent();
        }

        private void InicioDeSesionForm_Load(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }


        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( this.nombreUsuarioTextBox.Text))
            {
                MessageBox.Show("El campo nombre de usuario no puede quedar vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreUsuarioTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.contraseñaTextBox.Text))
            {
                MessageBox.Show("El campo contraseña no puede quedar vacía.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.contraseñaTextBox.Focus();
                return;
            }
            this.AbrirFormulario();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AbrirFormulario()
        {
            DatosInicioSesion myData = DatosInicioSesion.AbrirDatosInicioSesion();
            if (!myData.IniciarSesion(this.nombreUsuarioTextBox.Text, this.contraseñaTextBox.Text))
            {
                MessageBox.Show("Usuario no existe.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.nombreUsuarioTextBox.Focus();
                return;
            }
            if (Usuario.Tipo.Equals(3))
            {
                this.Hide();
                PrincipalAdminForm adminForm = new PrincipalAdminForm();
                adminForm.ShowDialog();
                this.Show();
                this.LimpiarControles();
                return;
            }
            if (Usuario.Tipo.Equals(9))
            {
                this.Hide();
                PrincipalClienteForm clienteForm = new PrincipalClienteForm();
                clienteForm.ShowDialog();
                this.Show();
                this.LimpiarControles();
                return;
            }
            if (Usuario.Tipo.Equals(1))
            {
                this.Hide();
                PrincipalEjecutivoForm ejecutivoForm = new PrincipalEjecutivoForm();
                ejecutivoForm.ShowDialog();
                this.Show();
                this.LimpiarControles();
                return;
            }
            this.LimpiarControles();
            this.nombreUsuarioTextBox.Focus();
        }


        private void LimpiarControles()
        {
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.contraseñaTextBox.Text = string.Empty;
        }








    }
}
