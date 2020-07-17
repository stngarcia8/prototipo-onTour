using System;
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

namespace Ontour.View.Desktop.Formularios.UtilForms
{
    public partial class SeleccionDeActividadesForm : MetroForm
    {

        public IList<int> IdList { get; set; }
        public DataTable Resultados { get; set; }

        public SeleccionDeActividadesForm()
        {
            InitializeComponent();
        }

        private void SeleccionDeActividadesForm_Load(object sender, EventArgs e)
        {
            this.CargarLista();
            this.listadoListView.Focus();
            SendKeys.Send("^{+}");
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            this.TraspasarToDataTable();
            this.DialogResult = this.aceptarButton.DialogResult;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = this.cancelarButton.DialogResult;
        }


        private void CargarLista()
        {
            DatosActividad mysDatosActividad = DatosActividad.AbrirDatosActividad();
            DataTable myDataTable = mysDatosActividad.ObtenerListadoDeActividadesParaSeleccion();
            this.listadoListView.Items.Clear();
            if (myDataTable.Rows.Count.Equals(0)) return;
            myDataTable.Columns.Cast<DataColumn>().ToList().ForEach(column => this.listadoListView.Columns.Add(column.Caption));
            myDataTable.AsEnumerable().ToList().ForEach(row =>
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row[0]));
                item.Checked = (this.IdList.Contains(int.Parse(row[0].ToString())) ? true : false);
                row.ItemArray.ToList().Skip(1).ToList().ForEach(value =>
                item.SubItems.Add(Convert.ToString(value)));
                listadoListView.Items.Add(item);
            });
            if (this.listadoListView.Items.Count > 0)
            {
                this.listadoListView.Items[0].Selected = true;
            }
        }


        private void TraspasarToDataTable()
        {
            this.Resultados = new DataTable();
            var columns = this.listadoListView.Columns.Count;
            foreach (ColumnHeader column in this.listadoListView.Columns)
                this.Resultados.Columns.Add(column.Text);
            foreach (ListViewItem item in this.listadoListView.Items)
            {
                if (item.Checked)
                {
                    var cells = new object[columns];
                    for (var i = 0; i < columns; i++)
                        cells[i] = item.SubItems[i].Text;
                    this.Resultados.Rows.Add(cells);
                }
            }
        }


    }
}
