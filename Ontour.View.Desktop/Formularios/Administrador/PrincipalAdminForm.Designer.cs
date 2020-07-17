namespace Ontour.View.Desktop.Formularios.Administrador
{
    partial class PrincipalAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAdminForm));
            this.formularioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.opcionesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.opcionesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registroTourLinkLabel = new System.Windows.Forms.LinkLabel();
            this.opcionesLabel = new System.Windows.Forms.Label();
            this.registrarActividadesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.registroDestinosLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registroTransportesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registroHotelesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cerrarSesionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pieDePaginaMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.accionesMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.formularioTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.opcionesMetroPanel.SuspendLayout();
            this.opcionesTableLayoutPanel.SuspendLayout();
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
            this.formularioTableLayoutPanel.Location = new System.Drawing.Point(29, 79);
            this.formularioTableLayoutPanel.Name = "formularioTableLayoutPanel";
            this.formularioTableLayoutPanel.RowCount = 3;
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.formularioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.formularioTableLayoutPanel.Size = new System.Drawing.Size(842, 395);
            this.formularioTableLayoutPanel.TabIndex = 0;
            // 
            // bannerPictureBox
            // 
            this.formularioTableLayoutPanel.SetColumnSpan(this.bannerPictureBox, 2);
            this.bannerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannerPictureBox.Image = global::Ontour.View.Desktop.Properties.Resources.onTourImage;
            this.bannerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(836, 112);
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
            this.opcionesMetroPanel.Location = new System.Drawing.Point(3, 121);
            this.opcionesMetroPanel.Name = "opcionesMetroPanel";
            this.formularioTableLayoutPanel.SetRowSpan(this.opcionesMetroPanel, 2);
            this.opcionesMetroPanel.Size = new System.Drawing.Size(162, 271);
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
            this.opcionesTableLayoutPanel.Controls.Add(this.registroTourLinkLabel, 0, 4);
            this.opcionesTableLayoutPanel.Controls.Add(this.opcionesLabel, 0, 0);
            this.opcionesTableLayoutPanel.Controls.Add(this.registrarActividadesLinkLabel, 0, 3);
            this.opcionesTableLayoutPanel.Controls.Add(this.registroDestinosLinkLabel, 0, 2);
            this.opcionesTableLayoutPanel.Controls.Add(this.registroTransportesLinkLabel, 0, 1);
            this.opcionesTableLayoutPanel.Controls.Add(this.registroHotelesLinkLabel, 0, 5);
            this.opcionesTableLayoutPanel.Controls.Add(this.cerrarSesionLinkLabel, 0, 10);
            this.opcionesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.opcionesTableLayoutPanel.Name = "opcionesTableLayoutPanel";
            this.opcionesTableLayoutPanel.RowCount = 11;
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
            this.opcionesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.opcionesTableLayoutPanel.Size = new System.Drawing.Size(162, 271);
            this.opcionesTableLayoutPanel.TabIndex = 2;
            // 
            // registroTourLinkLabel
            // 
            this.registroTourLinkLabel.AutoSize = true;
            this.registroTourLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroTourLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroTourLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroTourLinkLabel.Location = new System.Drawing.Point(3, 100);
            this.registroTourLinkLabel.Name = "registroTourLinkLabel";
            this.registroTourLinkLabel.Size = new System.Drawing.Size(156, 25);
            this.registroTourLinkLabel.TabIndex = 6;
            this.registroTourLinkLabel.TabStop = true;
            this.registroTourLinkLabel.Text = "Registro de tours";
            this.registroTourLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroTourLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registroTourLinkLabel_LinkClicked);
            // 
            // opcionesLabel
            // 
            this.opcionesLabel.AutoSize = true;
            this.opcionesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesLabel.Location = new System.Drawing.Point(3, 0);
            this.opcionesLabel.Name = "opcionesLabel";
            this.opcionesLabel.Size = new System.Drawing.Size(156, 25);
            this.opcionesLabel.TabIndex = 0;
            this.opcionesLabel.Text = "Opciones";
            this.opcionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrarActividadesLinkLabel
            // 
            this.registrarActividadesLinkLabel.AutoSize = true;
            this.registrarActividadesLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrarActividadesLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarActividadesLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarActividadesLinkLabel.Location = new System.Drawing.Point(3, 75);
            this.registrarActividadesLinkLabel.Name = "registrarActividadesLinkLabel";
            this.registrarActividadesLinkLabel.Size = new System.Drawing.Size(156, 25);
            this.registrarActividadesLinkLabel.TabIndex = 1;
            this.registrarActividadesLinkLabel.TabStop = true;
            this.registrarActividadesLinkLabel.Text = "Registro de actividades";
            this.registrarActividadesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarActividadesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrarActividadesLinkLabel_LinkClicked);
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "cerrarSesion.png");
            this.formularioImageList.Images.SetKeyName(1, "transportes.png");
            this.formularioImageList.Images.SetKeyName(2, "hotel.png");
            this.formularioImageList.Images.SetKeyName(3, "activities.png");
            this.formularioImageList.Images.SetKeyName(4, "destinos.png");
            // 
            // registroDestinosLinkLabel
            // 
            this.registroDestinosLinkLabel.AutoSize = true;
            this.registroDestinosLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroDestinosLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDestinosLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroDestinosLinkLabel.Location = new System.Drawing.Point(3, 50);
            this.registroDestinosLinkLabel.Name = "registroDestinosLinkLabel";
            this.registroDestinosLinkLabel.Size = new System.Drawing.Size(156, 25);
            this.registroDestinosLinkLabel.TabIndex = 2;
            this.registroDestinosLinkLabel.TabStop = true;
            this.registroDestinosLinkLabel.Text = "Registro de destinos";
            this.registroDestinosLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroDestinosLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registroDestinosLinkLabel_LinkClicked);
            // 
            // registroTransportesLinkLabel
            // 
            this.registroTransportesLinkLabel.AutoSize = true;
            this.registroTransportesLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroTransportesLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroTransportesLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroTransportesLinkLabel.Location = new System.Drawing.Point(3, 25);
            this.registroTransportesLinkLabel.Name = "registroTransportesLinkLabel";
            this.registroTransportesLinkLabel.Size = new System.Drawing.Size(156, 25);
            this.registroTransportesLinkLabel.TabIndex = 3;
            this.registroTransportesLinkLabel.TabStop = true;
            this.registroTransportesLinkLabel.Text = "Registro de transportes";
            this.registroTransportesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroTransportesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registroTransportesLinkLabel_LinkClicked);
            // 
            // registroHotelesLinkLabel
            // 
            this.registroHotelesLinkLabel.AutoSize = true;
            this.registroHotelesLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroHotelesLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroHotelesLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroHotelesLinkLabel.Location = new System.Drawing.Point(3, 125);
            this.registroHotelesLinkLabel.Name = "registroHotelesLinkLabel";
            this.registroHotelesLinkLabel.Size = new System.Drawing.Size(156, 25);
            this.registroHotelesLinkLabel.TabIndex = 4;
            this.registroHotelesLinkLabel.TabStop = true;
            this.registroHotelesLinkLabel.Text = "Registro de hoteles";
            this.registroHotelesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroHotelesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registroHotelesLinkLabel_LinkClicked);
            // 
            // cerrarSesionLinkLabel
            // 
            this.cerrarSesionLinkLabel.AutoSize = true;
            this.cerrarSesionLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cerrarSesionLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesionLinkLabel.Location = new System.Drawing.Point(3, 250);
            this.cerrarSesionLinkLabel.Name = "cerrarSesionLinkLabel";
            this.cerrarSesionLinkLabel.Size = new System.Drawing.Size(156, 21);
            this.cerrarSesionLinkLabel.TabIndex = 5;
            this.cerrarSesionLinkLabel.TabStop = true;
            this.cerrarSesionLinkLabel.Text = "Cerrar sesión";
            this.cerrarSesionLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesionLinkLabel_LinkClicked);
            // 
            // pieDePaginaMetroLabel
            // 
            this.pieDePaginaMetroLabel.AutoSize = true;
            this.pieDePaginaMetroLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pieDePaginaMetroLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieDePaginaMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pieDePaginaMetroLabel.Location = new System.Drawing.Point(171, 355);
            this.pieDePaginaMetroLabel.Name = "pieDePaginaMetroLabel";
            this.pieDePaginaMetroLabel.Size = new System.Drawing.Size(668, 40);
            this.pieDePaginaMetroLabel.TabIndex = 2;
            this.pieDePaginaMetroLabel.Text = "Agencia de viajes On-Tour, Los viajecitos 963, Santiago, correo electrónico: info" +
    "@ontour.cl,  telefonos de contacto: +562 98 76 15 75  -  +562 25 74 19 75.";
            this.pieDePaginaMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pieDePaginaMetroLabel.UseCustomBackColor = true;
            // 
            // accionesMetroPanel
            // 
            this.accionesMetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accionesMetroPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accionesMetroPanel.HorizontalScrollbarBarColor = true;
            this.accionesMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.accionesMetroPanel.HorizontalScrollbarSize = 10;
            this.accionesMetroPanel.Location = new System.Drawing.Point(171, 121);
            this.accionesMetroPanel.Name = "accionesMetroPanel";
            this.accionesMetroPanel.Size = new System.Drawing.Size(668, 231);
            this.accionesMetroPanel.TabIndex = 3;
            this.accionesMetroPanel.VerticalScrollbarBarColor = true;
            this.accionesMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.accionesMetroPanel.VerticalScrollbarSize = 10;
            // 
            // PrincipalAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.formularioTableLayoutPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalAdminForm";
            this.Padding = new System.Windows.Forms.Padding(29, 79, 29, 26);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Agencia On-Tour: Administrador.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.formularioTableLayoutPanel.ResumeLayout(false);
            this.formularioTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.opcionesMetroPanel.ResumeLayout(false);
            this.opcionesTableLayoutPanel.ResumeLayout(false);
            this.opcionesTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formularioTableLayoutPanel;
        private System.Windows.Forms.PictureBox bannerPictureBox;
        private MetroFramework.Controls.MetroPanel opcionesMetroPanel;
        private MetroFramework.Controls.MetroLabel pieDePaginaMetroLabel;
        private MetroFramework.Controls.MetroPanel accionesMetroPanel;
        private System.Windows.Forms.TableLayoutPanel opcionesTableLayoutPanel;
        private System.Windows.Forms.Label opcionesLabel;
        private System.Windows.Forms.LinkLabel registrarActividadesLinkLabel;
        private System.Windows.Forms.LinkLabel registroDestinosLinkLabel;
        private System.Windows.Forms.LinkLabel registroTransportesLinkLabel;
        private System.Windows.Forms.LinkLabel registroHotelesLinkLabel;
        private System.Windows.Forms.LinkLabel cerrarSesionLinkLabel;
        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.LinkLabel registroTourLinkLabel;
    }
}