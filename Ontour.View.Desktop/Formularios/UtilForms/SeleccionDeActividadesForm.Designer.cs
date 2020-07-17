namespace Ontour.View.Desktop.Formularios.UtilForms
{
    partial class SeleccionDeActividadesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionDeActividadesForm));
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.listadoListView = new System.Windows.Forms.ListView();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.listadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "aceptar.png");
            this.formularioImageList.Images.SetKeyName(1, "cancelar.png");
            // 
            // listadoListView
            // 
            this.listadoListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listadoListView.CheckBoxes = true;
            this.listadoListView.FullRowSelect = true;
            this.listadoListView.GridLines = true;
            this.listadoListView.HideSelection = false;
            this.listadoListView.Location = new System.Drawing.Point(12, 53);
            this.listadoListView.MultiSelect = false;
            this.listadoListView.Name = "listadoListView";
            this.listadoListView.ShowGroups = false;
            this.listadoListView.Size = new System.Drawing.Size(575, 325);
            this.listadoListView.TabIndex = 5;
            this.listadoListView.UseCompatibleStateImageBehavior = false;
            this.listadoListView.View = System.Windows.Forms.View.Details;
            // 
            // cancelarButton
            // 
            this.cancelarButton.AutoSize = true;
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.ImageKey = "cancelar.png";
            this.cancelarButton.ImageList = this.formularioImageList;
            this.cancelarButton.Location = new System.Drawing.Point(512, 403);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(91, 30);
            this.cancelarButton.TabIndex = 7;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.AutoSize = true;
            this.aceptarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarButton.ImageKey = "aceptar.png";
            this.aceptarButton.ImageList = this.formularioImageList;
            this.aceptarButton.Location = new System.Drawing.Point(362, 403);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(85, 30);
            this.aceptarButton.TabIndex = 6;
            this.aceptarButton.Text = "&Aceptar";
            this.aceptarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // listadoLabel
            // 
            this.listadoLabel.AutoSize = true;
            this.listadoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoLabel.Location = new System.Drawing.Point(37, 28);
            this.listadoLabel.Name = "listadoLabel";
            this.listadoLabel.Size = new System.Drawing.Size(176, 19);
            this.listadoLabel.TabIndex = 4;
            this.listadoLabel.Text = "Destinos disponibles:";
            // 
            // SeleccionDeActividadesForm
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.ControlBox = false;
            this.Controls.Add(this.listadoListView);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.listadoLabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Movable = false;
            this.Name = "SeleccionDeActividadesForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Agencia de viajes On-Tour: Selección de actividades.";
            this.Load += new System.EventHandler(this.SeleccionDeActividadesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.ListView listadoListView;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label listadoLabel;
    }
}