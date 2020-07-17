using System.Windows.Forms;
using MetroFramework.Forms;

namespace Ontour.View.Desktop.Formularios.Administrador
{
    public partial class PrincipalAdminForm : MetroForm
    {
        public PrincipalAdminForm()
        {
            InitializeComponent();
        }

        private void cerrarSesionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void registroTransportesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransportesForm myTransporteForm = new TransportesForm();
            this.Hide();
            myTransporteForm.ShowDialog();
            this.Show();
        }

        private void registroHotelesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HotelesForm myHotelForm = new HotelesForm();
            this.Hide();
            myHotelForm.ShowDialog();
            this.Show();
        }


        private void registroDestinosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DestinosForm myDestinoForm = new DestinosForm();
            this.Hide();
            myDestinoForm.ShowDialog();
            this.Show();
        }

        private void registrarActividadesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActividadesForm myActividadForm = new ActividadesForm();
            this.Hide();
            myActividadForm.ShowDialog();
            this.Show();
        }

        private void registroTourLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TourForm myTourForm = new TourForm();
            this.Hide();
            myTourForm.ShowDialog();
            this.Show();
        }
    }
}
