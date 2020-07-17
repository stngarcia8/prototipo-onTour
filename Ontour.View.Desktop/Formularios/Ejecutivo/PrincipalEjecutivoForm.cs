using System.Windows.Forms;
using MetroFramework.Forms;

namespace Ontour.View.Desktop.Formularios.Ejecutivo
{
    public partial class PrincipalEjecutivoForm : MetroForm
    {
        public PrincipalEjecutivoForm()
        {
            InitializeComponent();
        }

        private void cerrarSesionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void montosAportadosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaMontosAportadosForm myForm = new ConsultaMontosAportadosForm();
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void estadoCursoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EstadoAvanceForm myForm = new EstadoAvanceForm();
            myForm.ShowDialog();
        }

        private void registroClientesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientesForm myForm = new ClientesForm();
            myForm.ShowDialog();
        }
    }
}
