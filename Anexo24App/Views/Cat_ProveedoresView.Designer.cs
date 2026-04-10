namespace Anexo24App.Views
{
    partial class Cat_ProveedoresView
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControlDGC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelAddRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panelBusquedas = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewDGC = new System.Windows.Forms.DataGridView();
            this.tabPageDetalles = new System.Windows.Forms.TabPage();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtEntidadFederativa = new System.Windows.Forms.TextBox();
            this.lblEntidadFederativa = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtClaveIdentifacionFiscal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoIdentificacionFiscal = new System.Windows.Forms.ComboBox();
            this.txtNumAutorizacionRFE = new System.Windows.Forms.TextBox();
            this.txtNumeroProgramaIMMEX = new System.Windows.Forms.TextBox();
            this.cbTipoDeNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblUMComercializacion = new System.Windows.Forms.Label();
            this.lblNumAutorizacionRFE = new System.Windows.Forms.Label();
            this.lblNumeroProgramaIMMEX = new System.Windows.Forms.Label();
            this.lblTipoDeNacionalidad = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTituloDetalles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTitulo.SuspendLayout();
            this.tabControlDGC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelAddRefresh.SuspendLayout();
            this.panelBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGC)).BeginInit();
            this.tabPageDetalles.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelTituloDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1138, 47);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(2, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proveedores";
            // 
            // tabControlDGC
            // 
            this.tabControlDGC.Controls.Add(this.tabPage1);
            this.tabControlDGC.Controls.Add(this.tabPageDetalles);
            this.tabControlDGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDGC.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDGC.Location = new System.Drawing.Point(0, 47);
            this.tabControlDGC.Name = "tabControlDGC";
            this.tabControlDGC.SelectedIndex = 0;
            this.tabControlDGC.Size = new System.Drawing.Size(1138, 640);
            this.tabControlDGC.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelAddRefresh);
            this.tabPage1.Controls.Add(this.panelBusquedas);
            this.tabPage1.Controls.Add(this.dataGridViewDGC);
            this.tabPage1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelAddRefresh
            // 
            this.panelAddRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelAddRefresh.Controls.Add(this.btnRefresh);
            this.panelAddRefresh.Controls.Add(this.btnAdd);
            this.panelAddRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddRefresh.Location = new System.Drawing.Point(3, 40);
            this.panelAddRefresh.Name = "panelAddRefresh";
            this.panelAddRefresh.Size = new System.Drawing.Size(1124, 54);
            this.panelAddRefresh.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRefresh.IconSize = 40;
            this.btnRefresh.Location = new System.Drawing.Point(1053, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 54);
            this.btnRefresh.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresca datos");
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 40;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 54);
            this.btnAdd.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnAdd, "Agrega un nuevo registro");
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panelBusquedas
            // 
            this.panelBusquedas.Controls.Add(this.txtBusqueda);
            this.panelBusquedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusquedas.Location = new System.Drawing.Point(3, 3);
            this.panelBusquedas.Name = "panelBusquedas";
            this.panelBusquedas.Size = new System.Drawing.Size(1124, 37);
            this.panelBusquedas.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(1124, 35);
            this.txtBusqueda.TabIndex = 1;
            // 
            // dataGridViewDGC
            // 
            this.dataGridViewDGC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDGC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDGC.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDGC.Name = "dataGridViewDGC";
            this.dataGridViewDGC.RowHeadersWidth = 51;
            this.dataGridViewDGC.Size = new System.Drawing.Size(1124, 597);
            this.dataGridViewDGC.TabIndex = 0;
            // 
            // tabPageDetalles
            // 
            this.tabPageDetalles.Controls.Add(this.panelDatos);
            this.tabPageDetalles.Controls.Add(this.panelOpciones);
            this.tabPageDetalles.Controls.Add(this.panelTituloDetalles);
            this.tabPageDetalles.Location = new System.Drawing.Point(4, 33);
            this.tabPageDetalles.Name = "tabPageDetalles";
            this.tabPageDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalles.Size = new System.Drawing.Size(1130, 603);
            this.tabPageDetalles.TabIndex = 1;
            this.tabPageDetalles.Text = "Detalles";
            this.tabPageDetalles.UseVisualStyleBackColor = true;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.txtPais);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.txtMunicipio);
            this.panelDatos.Controls.Add(this.lblMunicipio);
            this.panelDatos.Controls.Add(this.txtEntidadFederativa);
            this.panelDatos.Controls.Add(this.lblEntidadFederativa);
            this.panelDatos.Controls.Add(this.txtColonia);
            this.panelDatos.Controls.Add(this.lblColonia);
            this.panelDatos.Controls.Add(this.txtCP);
            this.panelDatos.Controls.Add(this.lblCP);
            this.panelDatos.Controls.Add(this.txtNumero);
            this.panelDatos.Controls.Add(this.lblNumero);
            this.panelDatos.Controls.Add(this.txtCalle);
            this.panelDatos.Controls.Add(this.lblCalle);
            this.panelDatos.Controls.Add(this.txtClaveIdentifacionFiscal);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.cbTipoIdentificacionFiscal);
            this.panelDatos.Controls.Add(this.txtNumAutorizacionRFE);
            this.panelDatos.Controls.Add(this.txtNumeroProgramaIMMEX);
            this.panelDatos.Controls.Add(this.cbTipoDeNacionalidad);
            this.panelDatos.Controls.Add(this.lblUMComercializacion);
            this.panelDatos.Controls.Add(this.lblNumAutorizacionRFE);
            this.panelDatos.Controls.Add(this.lblNumeroProgramaIMMEX);
            this.panelDatos.Controls.Add(this.lblTipoDeNacionalidad);
            this.panelDatos.Controls.Add(this.txtRazonSocial);
            this.panelDatos.Controls.Add(this.lblDescripcion);
            this.panelDatos.Controls.Add(this.txtClave);
            this.panelDatos.Controls.Add(this.lblClave);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(3, 50);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1124, 466);
            this.panelDatos.TabIndex = 20;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(587, 413);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(288, 35);
            this.txtPais.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 66;
            this.label4.Text = "14. Pais:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(197, 413);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(288, 35);
            this.txtMunicipio.TabIndex = 64;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(192, 381);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(166, 29);
            this.lblMunicipio.TabIndex = 63;
            this.lblMunicipio.Text = "13. Municipio:";
            // 
            // txtEntidadFederativa
            // 
            this.txtEntidadFederativa.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidadFederativa.Location = new System.Drawing.Point(767, 319);
            this.txtEntidadFederativa.Name = "txtEntidadFederativa";
            this.txtEntidadFederativa.Size = new System.Drawing.Size(288, 35);
            this.txtEntidadFederativa.TabIndex = 62;
            // 
            // lblEntidadFederativa
            // 
            this.lblEntidadFederativa.AutoSize = true;
            this.lblEntidadFederativa.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadFederativa.Location = new System.Drawing.Point(764, 281);
            this.lblEntidadFederativa.Name = "lblEntidadFederativa";
            this.lblEntidadFederativa.Size = new System.Drawing.Size(265, 29);
            this.lblEntidadFederativa.TabIndex = 61;
            this.lblEntidadFederativa.Text = "12. Entidad federativa:";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(399, 319);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(288, 35);
            this.txtColonia.TabIndex = 60;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(394, 281);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(144, 29);
            this.lblColonia.TabIndex = 59;
            this.lblColonia.Text = "11. Colonia:";
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(11, 319);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(288, 35);
            this.txtCP.TabIndex = 58;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(6, 281);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(91, 29);
            this.lblCP.TabIndex = 57;
            this.lblCP.Text = "10. CP:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(767, 234);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(288, 35);
            this.txtNumero.TabIndex = 56;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(762, 192);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(134, 29);
            this.lblNumero.TabIndex = 55;
            this.lblNumero.Text = "9. Número:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(399, 234);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(288, 35);
            this.txtCalle.TabIndex = 54;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(394, 192);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(105, 29);
            this.lblCalle.TabIndex = 53;
            this.lblCalle.Text = "8. Calle:";
            // 
            // txtClaveIdentifacionFiscal
            // 
            this.txtClaveIdentifacionFiscal.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveIdentifacionFiscal.Location = new System.Drawing.Point(11, 234);
            this.txtClaveIdentifacionFiscal.Name = "txtClaveIdentifacionFiscal";
            this.txtClaveIdentifacionFiscal.Size = new System.Drawing.Size(288, 35);
            this.txtClaveIdentifacionFiscal.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "7. Clave de identificacion fiscal:";
            // 
            // cbTipoIdentificacionFiscal
            // 
            this.cbTipoIdentificacionFiscal.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoIdentificacionFiscal.FormattingEnabled = true;
            this.cbTipoIdentificacionFiscal.Location = new System.Drawing.Point(768, 137);
            this.cbTipoIdentificacionFiscal.Name = "cbTipoIdentificacionFiscal";
            this.cbTipoIdentificacionFiscal.Size = new System.Drawing.Size(289, 37);
            this.cbTipoIdentificacionFiscal.TabIndex = 50;
            // 
            // txtNumAutorizacionRFE
            // 
            this.txtNumAutorizacionRFE.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAutorizacionRFE.Location = new System.Drawing.Point(399, 139);
            this.txtNumAutorizacionRFE.Name = "txtNumAutorizacionRFE";
            this.txtNumAutorizacionRFE.Size = new System.Drawing.Size(288, 35);
            this.txtNumAutorizacionRFE.TabIndex = 49;
            // 
            // txtNumeroProgramaIMMEX
            // 
            this.txtNumeroProgramaIMMEX.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroProgramaIMMEX.Location = new System.Drawing.Point(10, 139);
            this.txtNumeroProgramaIMMEX.Name = "txtNumeroProgramaIMMEX";
            this.txtNumeroProgramaIMMEX.Size = new System.Drawing.Size(288, 35);
            this.txtNumeroProgramaIMMEX.TabIndex = 48;
            // 
            // cbTipoDeNacionalidad
            // 
            this.cbTipoDeNacionalidad.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDeNacionalidad.FormattingEnabled = true;
            this.cbTipoDeNacionalidad.Items.AddRange(new object[] {
            "Nacional",
            "Extranjera"});
            this.cbTipoDeNacionalidad.Location = new System.Drawing.Point(768, 46);
            this.cbTipoDeNacionalidad.Name = "cbTipoDeNacionalidad";
            this.cbTipoDeNacionalidad.Size = new System.Drawing.Size(289, 37);
            this.cbTipoDeNacionalidad.TabIndex = 47;
            // 
            // lblUMComercializacion
            // 
            this.lblUMComercializacion.AutoSize = true;
            this.lblUMComercializacion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMComercializacion.Location = new System.Drawing.Point(763, 96);
            this.lblUMComercializacion.Name = "lblUMComercializacion";
            this.lblUMComercializacion.Size = new System.Drawing.Size(351, 29);
            this.lblUMComercializacion.TabIndex = 29;
            this.lblUMComercializacion.Text = "6. Tipo de identificacion fiscal:";
            // 
            // lblNumAutorizacionRFE
            // 
            this.lblNumAutorizacionRFE.AutoSize = true;
            this.lblNumAutorizacionRFE.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAutorizacionRFE.Location = new System.Drawing.Point(394, 96);
            this.lblNumAutorizacionRFE.Name = "lblNumAutorizacionRFE";
            this.lblNumAutorizacionRFE.Size = new System.Drawing.Size(289, 29);
            this.lblNumAutorizacionRFE.TabIndex = 27;
            this.lblNumAutorizacionRFE.Text = "5.Num. Autorizacion RFE:";
            // 
            // lblNumeroProgramaIMMEX
            // 
            this.lblNumeroProgramaIMMEX.AutoSize = true;
            this.lblNumeroProgramaIMMEX.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProgramaIMMEX.Location = new System.Drawing.Point(5, 96);
            this.lblNumeroProgramaIMMEX.Name = "lblNumeroProgramaIMMEX";
            this.lblNumeroProgramaIMMEX.Size = new System.Drawing.Size(307, 29);
            this.lblNumeroProgramaIMMEX.TabIndex = 25;
            this.lblNumeroProgramaIMMEX.Text = "4. Numero Programa IMMEX";
            // 
            // lblTipoDeNacionalidad
            // 
            this.lblTipoDeNacionalidad.AutoSize = true;
            this.lblTipoDeNacionalidad.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeNacionalidad.Location = new System.Drawing.Point(763, 14);
            this.lblTipoDeNacionalidad.Name = "lblTipoDeNacionalidad";
            this.lblTipoDeNacionalidad.Size = new System.Drawing.Size(276, 29);
            this.lblTipoDeNacionalidad.TabIndex = 23;
            this.lblTipoDeNacionalidad.Text = "3. Tipo de Nacionalidad:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(399, 46);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(288, 35);
            this.txtRazonSocial.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(394, 14);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 29);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "2. Razon social:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(10, 48);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(288, 35);
            this.txtClave.TabIndex = 20;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(6, 14);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(110, 29);
            this.lblClave.TabIndex = 19;
            this.lblClave.Text = "1. Clave:";
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelOpciones.Controls.Add(this.btnCancel);
            this.panelOpciones.Controls.Add(this.btnSave);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpciones.Location = new System.Drawing.Point(3, 516);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1124, 84);
            this.panelOpciones.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(996, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 84);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 84);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelTituloDetalles
            // 
            this.panelTituloDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTituloDetalles.Controls.Add(this.label1);
            this.panelTituloDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDetalles.Location = new System.Drawing.Point(3, 3);
            this.panelTituloDetalles.Name = "panelTituloDetalles";
            this.panelTituloDetalles.Size = new System.Drawing.Size(1124, 47);
            this.panelTituloDetalles.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuerda siempre \"Guardar cambios\" si realizas alguno.";
            // 
            // Cat_ProveedoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 687);
            this.Controls.Add(this.tabControlDGC);
            this.Controls.Add(this.panelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cat_ProveedoresView";
            this.Text = "Cat_ProveedoresView";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tabControlDGC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelAddRefresh.ResumeLayout(false);
            this.panelBusquedas.ResumeLayout(false);
            this.panelBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGC)).EndInit();
            this.tabPageDetalles.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelTituloDetalles.ResumeLayout(false);
            this.panelTituloDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlDGC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageDetalles;
        private System.Windows.Forms.DataGridView dataGridViewDGC;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panelAddRefresh;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelTituloDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblUMComercializacion;
        private System.Windows.Forms.Label lblNumAutorizacionRFE;
        private System.Windows.Forms.Label lblNumeroProgramaIMMEX;
        private System.Windows.Forms.Label lblTipoDeNacionalidad;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox cbTipoDeNacionalidad;
        private System.Windows.Forms.TextBox txtNumeroProgramaIMMEX;
        private System.Windows.Forms.ComboBox cbTipoIdentificacionFiscal;
        private System.Windows.Forms.TextBox txtNumAutorizacionRFE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveIdentifacionFiscal;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtEntidadFederativa;
        private System.Windows.Forms.Label lblEntidadFederativa;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label4;
    }
}