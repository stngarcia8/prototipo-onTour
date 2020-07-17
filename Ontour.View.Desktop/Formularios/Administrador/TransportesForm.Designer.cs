namespace Ontour.View.Desktop.Formularios.Administrador
{
    partial class TransportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formularioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.opcionesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.opcionesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.opcionesLabel = new System.Windows.Forms.Label();
            this.listarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.nuevoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.editarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.inhabilitarLinkLabel = new System.Windows.Forms.LinkLabel();
            this.volverLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pieDePaginaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.accionesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.datosMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.habilitarCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.grabarButton = new System.Windows.Forms.Button();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.datosLabel = new System.Windows.Forms.Label();
            this.listadoMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.listadoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.formularioTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.opcionesMetroPanel.SuspendLayout();
            this.opcionesTableLayoutPanel.SuspendLayout();
            this.accionesMetroPanel.SuspendLayout();
            this.datosMetroPanel.SuspendLayout();
            this.listadoMetroPanel.SuspendLayout();
            this.listadoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // formularioTableLayoutPanel
            // 
            this.formularioTableLayoutPanel.ColumnCount = 2;
            this.formularioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.formularioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.formularioTableLayoutPanel.Controls.Add(this.bannerPictureBox, 0, 0);
            this.formularioTableLayoutPanel.Controls.Add(this.opcionesMetroPanel, 0, 1);
            this.formularioTableLayoutPanel.Controls.Add(this.pieDePaginaMetroLabel, 1, 2);
            this.formularioTableLayoutPanel.Controls.Add(this.accionesMetroPanel, 1, 1);
            this.formularioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formularioTableLayoutPanel.Location = new System.Drawing.Point(23, 75);
            this.formularioTableLayoutPanel.Name = "formularioTableLayoutPanel";
            this.formularioTableLayoutPanel.RowCount = 4;
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formularioTableLayoutPanel.Size = new System.Drawing.Size(854, 435);
            this.formularioTableLayoutPanel.TabIndex = 1;
            // 
            // bannerPictureBox
            // 
            this.formularioTableLayoutPanel.SetColumnSpan(this.bannerPictureBox, 2);
            this.bannerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannerPictureBox.Image = global::Ontour.View.Desktop.Properties.Resources.onTourImage;
            this.bannerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(848, 118);
            this.bannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerPictureBox.TabIndex = 0;
            this.bannerPictureBox.TabStop = false;
            // 
            // opcionesMetroPanel
            // 
            this.opcionesMetroPanel.AutoScroll = true;
            this.opcionesMetroPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.opcionesMetroPanel.Controls.Add(this.opcionesTableLayoutPanel);
            this.opcionesMetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesMetroPanel.HorizontalScrollbar = true;
            this.opcionesMetroPanel.HorizontalScrollbarBarColor = true;
            this.opcionesMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.opcionesMetroPanel.HorizontalScrollbarSize = 10;
            this.opcionesMetroPanel.Location = new System.Drawing.Point(3, 127);
            this.opcionesMetroPanel.Name = "opcionesMetroPanel";
            this.formularioTableLayoutPanel.SetRowSpan(this.opcionesMetroPanel, 2);
            this.opcionesMetroPanel.Size = new System.Drawing.Size(164, 284);
            this.opcionesMetroPanel.Style = MetroFramework.MetroColorStyle.Black;
            this.opcionesMetroPanel.TabIndex = 1;
            this.opcionesMetroPanel.UseCustomBackColor = true;
            this.opcionesMetroPanel.UseCustomForeColor = true;
            this.opcionesMetroPanel.UseStyleColors = true;
            this.opcionesMetroPanel.VerticalScrollbar = true;
            this.opcionesMetroPanel.VerticalScrollbarBarColor = true;
            this.opcionesMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.opcionesMetroPanel.VerticalScrollbarSize = 10;
            // 
            // opcionesTableLayoutPanel
            // 
            this.opcionesTableLayoutPanel.ColumnCount = 1;
            this.opcionesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.opcionesTableLayoutPanel.Controls.Add(this.opcionesLabel, 0, 0);
            this.opcionesTableLayoutPanel.Controls.Add(this.listarLinkLabel, 0, 1);
            this.opcionesTableLayoutPanel.Controls.Add(this.nuevoLinkLabel, 0, 2);
            this.opcionesTableLayoutPanel.Controls.Add(this.editarLinkLabel, 0, 3);
            this.opcionesTableLayoutPanel.Controls.Add(this.inhabilitarLinkLabel, 0, 4);
            this.opcionesTableLayoutPanel.Controls.Add(this.volverLinkLabel, 0, 10);
            this.opcionesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.opcionesTableLayoutPanel.Name = "opcionesTableLayoutPanel";
            this.opcionesTableLayoutPanel.RowCount = 10;
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.opcionesTableLayoutPanel.Size = new System.Drawing.Size(164, 284);
            this.opcionesTableLayoutPanel.TabIndex = 2;
            // 
            // opcionesLabel
            // 
            this.opcionesLabel.AutoSize = true;
            this.opcionesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesLabel.Location = new System.Drawing.Point(3, 0);
            this.opcionesLabel.Name = "opcionesLabel";
            this.opcionesLabel.Size = new System.Drawing.Size(158, 26);
            this.opcionesLabel.TabIndex = 0;
            this.opcionesLabel.Text = "Opciones";
            this.opcionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listarLinkLabel
            // 
            this.listarLinkLabel.AutoSize = true;
            this.listarLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listarLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarLinkLabel.ImageKey = "list.png";
            this.listarLinkLabel.ImageList = this.formularioImageList;
            this.listarLinkLabel.Location = new System.Drawing.Point(3, 26);
            this.listarLinkLabel.Name = "listarLinkLabel";
            this.listarLinkLabel.Size = new System.Drawing.Size(158, 26);
            this.listarLinkLabel.TabIndex = 1;
            this.listarLinkLabel.TabStop = true;
            this.listarLinkLabel.Text = "Listado de transportes";
            this.listarLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.listarLinkLabel_LinkClicked);
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "grabar.png");
            this.formularioImageList.Images.SetKeyName(1, "cancelar.png");
            this.formularioImageList.Images.SetKeyName(2, "agregar.png");
            this.formularioImageList.Images.SetKeyName(3, "editar.png");
            this.formularioImageList.Images.SetKeyName(4, "inhabilitar.png");
            this.formularioImageList.Images.SetKeyName(5, "list.png");
            this.formularioImageList.Images.SetKeyName(6, "goPrevious.png");
            // 
            // nuevoLinkLabel
            // 
            this.nuevoLinkLabel.AutoSize = true;
            this.nuevoLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevoLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoLinkLabel.ImageKey = "agregar.png";
            this.nuevoLinkLabel.ImageList = this.formularioImageList;
            this.nuevoLinkLabel.Location = new System.Drawing.Point(3, 52);
            this.nuevoLinkLabel.Name = "nuevoLinkLabel";
            this.nuevoLinkLabel.Size = new System.Drawing.Size(158, 26);
            this.nuevoLinkLabel.TabIndex = 2;
            this.nuevoLinkLabel.TabStop = true;
            this.nuevoLinkLabel.Text = "Crear nuevo transporte";
            this.nuevoLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nuevoLinkLabel_LinkClicked);
            // 
            // editarLinkLabel
            // 
            this.editarLinkLabel.AutoSize = true;
            this.editarLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editarLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarLinkLabel.ImageKey = "editar.png";
            this.editarLinkLabel.ImageList = this.formularioImageList;
            this.editarLinkLabel.Location = new System.Drawing.Point(3, 78);
            this.editarLinkLabel.Name = "editarLinkLabel";
            this.editarLinkLabel.Size = new System.Drawing.Size(158, 26);
            this.editarLinkLabel.TabIndex = 3;
            this.editarLinkLabel.TabStop = true;
            this.editarLinkLabel.Text = "Editar transporte";
            this.editarLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editarLinkLabel_LinkClicked);
            // 
            // inhabilitarLinkLabel
            // 
            this.inhabilitarLinkLabel.AutoSize = true;
            this.inhabilitarLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inhabilitarLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhabilitarLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inhabilitarLinkLabel.ImageKey = "inhabilitar.png";
            this.inhabilitarLinkLabel.ImageList = this.formularioImageList;
            this.inhabilitarLinkLabel.Location = new System.Drawing.Point(3, 104);
            this.inhabilitarLinkLabel.Name = "inhabilitarLinkLabel";
            this.inhabilitarLinkLabel.Size = new System.Drawing.Size(158, 26);
            this.inhabilitarLinkLabel.TabIndex = 4;
            this.inhabilitarLinkLabel.TabStop = true;
            this.inhabilitarLinkLabel.Text = "Inhabilitar transporte";
            this.inhabilitarLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inhabilitarLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inhabilitarLinkLabel_LinkClicked);
            // 
            // volverLinkLabel
            // 
            this.volverLinkLabel.AutoSize = true;
            this.volverLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volverLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.volverLinkLabel.ImageKey = "goPrevious.png";
            this.volverLinkLabel.ImageList = this.formularioImageList;
            this.volverLinkLabel.Location = new System.Drawing.Point(3, 260);
            this.volverLinkLabel.Name = "volverLinkLabel";
            this.volverLinkLabel.Size = new System.Drawing.Size(158, 24);
            this.volverLinkLabel.TabIndex = 5;
            this.volverLinkLabel.TabStop = true;
            this.volverLinkLabel.Text = "Volver página anterior";
            this.volverLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.volverLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.volverLinkLabel_LinkClicked);
            // 
            // pieDePaginaMetroLabel
            // 
            this.pieDePaginaMetroLabel.AutoSize = true;
            this.pieDePaginaMetroLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pieDePaginaMetroLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieDePaginaMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pieDePaginaMetroLabel.Location = new System.Drawing.Point(173, 373);
            this.pieDePaginaMetroLabel.Name = "pieDePaginaMetroLabel";
            this.pieDePaginaMetroLabel.Size = new System.Drawing.Size(678, 41);
            this.pieDePaginaMetroLabel.TabIndex = 2;
            this.pieDePaginaMetroLabel.Text = "Agencia de viajes On-Tour, Los viajecitos 963, Santiago, correo electrónico: info" +
    "@ontour.cl,  telefonos de contacto: +562 98 76 15 75  -  +562 25 74 19 75.";
            this.pieDePaginaMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pieDePaginaMetroLabel.UseCustomBackColor = true;
            // 
            // accionesMetroPanel
            // 
            this.accionesMetroPanel.Controls.Add(this.datosMetroPanel);
            this.accionesMetroPanel.Controls.Add(this.listadoMetroPanel);
            this.accionesMetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accionesMetroPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accionesMetroPanel.HorizontalScrollbarBarColor = true;
            this.accionesMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.accionesMetroPanel.HorizontalScrollbarSize = 10;
            this.accionesMetroPanel.Location = new System.Drawing.Point(173, 127);
            this.accionesMetroPanel.Name = "accionesMetroPanel";
            this.accionesMetroPanel.Size = new System.Drawing.Size(678, 243);
            this.accionesMetroPanel.TabIndex = 3;
            this.accionesMetroPanel.VerticalScrollbarBarColor = true;
            this.accionesMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.accionesMetroPanel.VerticalScrollbarSize = 10;
            // 
            // datosMetroPanel
            // 
            this.datosMetroPanel.Controls.Add(this.habilitarCheckBox);
            this.datosMetroPanel.Controls.Add(this.cancelarButton);
            this.datosMetroPanel.Controls.Add(this.grabarButton);
            this.datosMetroPanel.Controls.Add(this.tipoComboBox);
            this.datosMetroPanel.Controls.Add(this.tipoLabel);
            this.datosMetroPanel.Controls.Add(this.nombreTextBox);
            this.datosMetroPanel.Controls.Add(this.nombreLabel);
            this.datosMetroPanel.Controls.Add(this.datosLabel);
            this.datosMetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosMetroPanel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosMetroPanel.HorizontalScrollbarBarColor = true;
            this.datosMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.datosMetroPanel.HorizontalScrollbarSize = 10;
            this.datosMetroPanel.Location = new System.Drawing.Point(0, 0);
            this.datosMetroPanel.Name = "datosMetroPanel";
            this.datosMetroPanel.Size = new System.Drawing.Size(678, 243);
            this.datosMetroPanel.TabIndex = 3;
            this.datosMetroPanel.VerticalScrollbarBarColor = true;
            this.datosMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.datosMetroPanel.VerticalScrollbarSize = 10;
            // 
            // habilitarCheckBox
            // 
            this.habilitarCheckBox.AutoSize = true;
            this.habilitarCheckBox.Location = new System.Drawing.Point(50, 175);
            this.habilitarCheckBox.Name = "habilitarCheckBox";
            this.habilitarCheckBox.Size = new System.Drawing.Size(101, 27);
            this.habilitarCheckBox.TabIndex = 7;
            this.habilitarCheckBox.Text = "Habilitado.";
            this.habilitarCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.AutoSize = true;
            this.cancelarButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.ImageKey = "cancelar.png";
            this.cancelarButton.ImageList = this.formularioImageList;
            this.cancelarButton.Location = new System.Drawing.Point(350, 225);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(126, 33);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // grabarButton
            // 
            this.grabarButton.AutoSize = true;
            this.grabarButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grabarButton.ImageKey = "grabar.png";
            this.grabarButton.ImageList = this.formularioImageList;
            this.grabarButton.Location = new System.Drawing.Point(225, 225);
            this.grabarButton.Name = "grabarButton";
            this.grabarButton.Size = new System.Drawing.Size(108, 33);
            this.grabarButton.TabIndex = 8;
            this.grabarButton.Text = "&Grabar";
            this.grabarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grabarButton.UseVisualStyleBackColor = true;
            this.grabarButton.Click += new System.EventHandler(this.grabarButton_Click);
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(225, 125);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(250, 31);
            this.tipoComboBox.TabIndex = 6;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLabel.Location = new System.Drawing.Point(50, 125);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(117, 23);
            this.tipoLabel.TabIndex = 5;
            this.tipoLabel.Text = "Tipo transporte:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(225, 75);
            this.nombreTextBox.MaxLength = 25;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(250, 29);
            this.nombreTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(50, 75);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(89, 23);
            this.nombreLabel.TabIndex = 3;
            this.nombreLabel.Text = "Transporte:";
            // 
            // datosLabel
            // 
            this.datosLabel.AutoSize = true;
            this.datosLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosLabel.ForeColor = System.Drawing.Color.DimGray;
            this.datosLabel.Location = new System.Drawing.Point(0, 0);
            this.datosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosLabel.Name = "datosLabel";
            this.datosLabel.Size = new System.Drawing.Size(395, 55);
            this.datosLabel.TabIndex = 2;
            this.datosLabel.Text = "Nuevo transporte";
            this.datosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listadoMetroPanel
            // 
            this.listadoMetroPanel.Controls.Add(this.listadoTableLayoutPanel);
            this.listadoMetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoMetroPanel.HorizontalScrollbarBarColor = true;
            this.listadoMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.listadoMetroPanel.HorizontalScrollbarSize = 10;
            this.listadoMetroPanel.Location = new System.Drawing.Point(0, 0);
            this.listadoMetroPanel.Name = "listadoMetroPanel";
            this.listadoMetroPanel.Size = new System.Drawing.Size(678, 243);
            this.listadoMetroPanel.TabIndex = 2;
            this.listadoMetroPanel.VerticalScrollbarBarColor = true;
            this.listadoMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.listadoMetroPanel.VerticalScrollbarSize = 10;
            // 
            // listadoTableLayoutPanel
            // 
            this.listadoTableLayoutPanel.ColumnCount = 2;
            this.listadoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.listadoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.listadoTableLayoutPanel.Controls.Add(this.tituloLabel, 0, 0);
            this.listadoTableLayoutPanel.Controls.Add(this.listadoDataGridView, 1, 1);
            this.listadoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.listadoTableLayoutPanel.Name = "listadoTableLayoutPanel";
            this.listadoTableLayoutPanel.RowCount = 2;
            this.listadoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.07792F));
            this.listadoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.92208F));
            this.listadoTableLayoutPanel.Size = new System.Drawing.Size(678, 243);
            this.listadoTableLayoutPanel.TabIndex = 2;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.listadoTableLayoutPanel.SetColumnSpan(this.tituloLabel, 2);
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.DimGray;
            this.tituloLabel.Location = new System.Drawing.Point(2, 0);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(674, 53);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Listado de transportes";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.AllowUserToOrderColumns = true;
            this.listadoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.listadoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoDataGridView.Location = new System.Drawing.Point(70, 56);
            this.listadoDataGridView.MultiSelect = false;
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.RowHeadersVisible = false;
            this.listadoDataGridView.RowTemplate.Height = 23;
            this.listadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDataGridView.ShowCellErrors = false;
            this.listadoDataGridView.ShowCellToolTips = false;
            this.listadoDataGridView.ShowEditingIcon = false;
            this.listadoDataGridView.ShowRowErrors = false;
            this.listadoDataGridView.Size = new System.Drawing.Size(605, 184);
            this.listadoDataGridView.TabIndex = 4;
            this.listadoDataGridView.SelectionChanged += new System.EventHandler(this.listadoDataGridView_SelectionChanged);
            this.listadoDataGridView.DoubleClick += new System.EventHandler(this.listadoDataGridView_DoubleClick);
            // 
            // TransportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackImage = global::Ontour.View.Desktop.Properties.Resources.transportes;
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.ControlBox = false;
            this.Controls.Add(this.formularioTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransportesForm";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Agencia de viajes On-Tour: Módulo de transportes.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransportesForm_Load);
            this.formularioTableLayoutPanel.ResumeLayout(false);
            this.formularioTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.opcionesMetroPanel.ResumeLayout(false);
            this.opcionesTableLayoutPanel.ResumeLayout(false);
            this.opcionesTableLayoutPanel.PerformLayout();
            this.accionesMetroPanel.ResumeLayout(false);
            this.datosMetroPanel.ResumeLayout(false);
            this.datosMetroPanel.PerformLayout();
            this.listadoMetroPanel.ResumeLayout(false);
            this.listadoTableLayoutPanel.ResumeLayout(false);
            this.listadoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formularioTableLayoutPanel;
        private System.Windows.Forms.PictureBox bannerPictureBox;
        private MetroFramework.Controls.MetroPanel opcionesMetroPanel;
        private System.Windows.Forms.TableLayoutPanel opcionesTableLayoutPanel;
        private System.Windows.Forms.Label opcionesLabel;
        private System.Windows.Forms.LinkLabel listarLinkLabel;
        private System.Windows.Forms.LinkLabel nuevoLinkLabel;
        private System.Windows.Forms.LinkLabel editarLinkLabel;
        private System.Windows.Forms.LinkLabel inhabilitarLinkLabel;
        private System.Windows.Forms.LinkLabel volverLinkLabel;
        private MetroFramework.Controls.MetroLabel pieDePaginaMetroLabel;
        private MetroFramework.Controls.MetroPanel accionesMetroPanel;
        private MetroFramework.Controls.MetroPanel listadoMetroPanel;
        private MetroFramework.Controls.MetroPanel datosMetroPanel;
        private System.Windows.Forms.TableLayoutPanel listadoTableLayoutPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.Button grabarButton;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label datosLabel;
        private System.Windows.Forms.CheckBox habilitarCheckBox;
    }
}