namespace Anexo24App.Views
{
    partial class Cat_MaterialesView
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
            this.tabControlMateriales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelAddRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panelBusquedas = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewDGC = new System.Windows.Forms.DataGridView();
            this.tabPageDetalles = new System.Windows.Forms.TabPage();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.cbPlantasBodegas = new System.Windows.Forms.ComboBox();
            this.lblPlantasBodegas = new System.Windows.Forms.Label();
            this.cbFraccionArancelaria = new System.Windows.Forms.ComboBox();
            this.cbUnidadesMedidaT = new System.Windows.Forms.ComboBox();
            this.cbUnidadesMedidaC = new System.Windows.Forms.ComboBox();
            this.dateFechaUltimaModificacion = new System.Windows.Forms.DateTimePicker();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.lblFraccionArancelaria = new System.Windows.Forms.Label();
            this.lblUnidadesMedidaT = new System.Windows.Forms.Label();
            this.lblUnidadesMedidaC = new System.Windows.Forms.Label();
            this.lblFechaUltimaModificacion = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.txtFactorConversion = new System.Windows.Forms.TextBox();
            this.lblFactorConversion = new System.Windows.Forms.Label();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.tabControlMateriales.SuspendLayout();
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
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(2, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Materiales";
            // 
            // tabControlMateriales
            // 
            this.tabControlMateriales.Controls.Add(this.tabPage1);
            this.tabControlMateriales.Controls.Add(this.tabPageDetalles);
            this.tabControlMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMateriales.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMateriales.Location = new System.Drawing.Point(0, 47);
            this.tabControlMateriales.Name = "tabControlMateriales";
            this.tabControlMateriales.SelectedIndex = 0;
            this.tabControlMateriales.Size = new System.Drawing.Size(1138, 798);
            this.tabControlMateriales.TabIndex = 2;
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
            this.tabPage1.Size = new System.Drawing.Size(1130, 761);
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
            this.dataGridViewDGC.Size = new System.Drawing.Size(1124, 755);
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
            this.tabPageDetalles.Size = new System.Drawing.Size(1130, 761);
            this.tabPageDetalles.TabIndex = 1;
            this.tabPageDetalles.Text = "Detalles";
            this.tabPageDetalles.UseVisualStyleBackColor = true;
            // 
            // panelDatos
            // 
            this.panelDatos.AutoScroll = true;
            this.panelDatos.Controls.Add(this.cbPlantasBodegas);
            this.panelDatos.Controls.Add(this.lblPlantasBodegas);
            this.panelDatos.Controls.Add(this.cbFraccionArancelaria);
            this.panelDatos.Controls.Add(this.cbUnidadesMedidaT);
            this.panelDatos.Controls.Add(this.cbUnidadesMedidaC);
            this.panelDatos.Controls.Add(this.dateFechaUltimaModificacion);
            this.panelDatos.Controls.Add(this.dateFechaAlta);
            this.panelDatos.Controls.Add(this.cbTipoMaterial);
            this.panelDatos.Controls.Add(this.lblFraccionArancelaria);
            this.panelDatos.Controls.Add(this.lblUnidadesMedidaT);
            this.panelDatos.Controls.Add(this.lblUnidadesMedidaC);
            this.panelDatos.Controls.Add(this.lblFechaUltimaModificacion);
            this.panelDatos.Controls.Add(this.lblFechaAlta);
            this.panelDatos.Controls.Add(this.txtFactorConversion);
            this.panelDatos.Controls.Add(this.lblFactorConversion);
            this.panelDatos.Controls.Add(this.lblTipoMaterial);
            this.panelDatos.Controls.Add(this.txtDescripcion);
            this.panelDatos.Controls.Add(this.lblDescripcion);
            this.panelDatos.Controls.Add(this.txtClave);
            this.panelDatos.Controls.Add(this.lblClave);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(3, 50);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1124, 624);
            this.panelDatos.TabIndex = 20;
            // 
            // cbPlantasBodegas
            // 
            this.cbPlantasBodegas.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlantasBodegas.FormattingEnabled = true;
            this.cbPlantasBodegas.Location = new System.Drawing.Point(16, 541);
            this.cbPlantasBodegas.Name = "cbPlantasBodegas";
            this.cbPlantasBodegas.Size = new System.Drawing.Size(289, 37);
            this.cbPlantasBodegas.TabIndex = 44;
            // 
            // lblPlantasBodegas
            // 
            this.lblPlantasBodegas.AutoSize = true;
            this.lblPlantasBodegas.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantasBodegas.Location = new System.Drawing.Point(16, 502);
            this.lblPlantasBodegas.Name = "lblPlantasBodegas";
            this.lblPlantasBodegas.Size = new System.Drawing.Size(391, 29);
            this.lblPlantasBodegas.TabIndex = 43;
            this.lblPlantasBodegas.Text = "10. Planta/Bodega donde se ubica:";
            // 
            // cbFraccionArancelaria
            // 
            this.cbFraccionArancelaria.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFraccionArancelaria.FormattingEnabled = true;
            this.cbFraccionArancelaria.Location = new System.Drawing.Point(769, 407);
            this.cbFraccionArancelaria.Name = "cbFraccionArancelaria";
            this.cbFraccionArancelaria.Size = new System.Drawing.Size(289, 37);
            this.cbFraccionArancelaria.TabIndex = 42;
            // 
            // cbUnidadesMedidaT
            // 
            this.cbUnidadesMedidaT.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadesMedidaT.FormattingEnabled = true;
            this.cbUnidadesMedidaT.Location = new System.Drawing.Point(400, 407);
            this.cbUnidadesMedidaT.Name = "cbUnidadesMedidaT";
            this.cbUnidadesMedidaT.Size = new System.Drawing.Size(289, 37);
            this.cbUnidadesMedidaT.TabIndex = 41;
            // 
            // cbUnidadesMedidaC
            // 
            this.cbUnidadesMedidaC.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadesMedidaC.FormattingEnabled = true;
            this.cbUnidadesMedidaC.Location = new System.Drawing.Point(15, 407);
            this.cbUnidadesMedidaC.Name = "cbUnidadesMedidaC";
            this.cbUnidadesMedidaC.Size = new System.Drawing.Size(289, 37);
            this.cbUnidadesMedidaC.TabIndex = 40;
            // 
            // dateFechaUltimaModificacion
            // 
            this.dateFechaUltimaModificacion.CalendarFont = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaUltimaModificacion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaUltimaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaUltimaModificacion.Location = new System.Drawing.Point(769, 270);
            this.dateFechaUltimaModificacion.Name = "dateFechaUltimaModificacion";
            this.dateFechaUltimaModificacion.Size = new System.Drawing.Size(290, 35);
            this.dateFechaUltimaModificacion.TabIndex = 39;
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.CalendarFont = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAlta.Location = new System.Drawing.Point(400, 270);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(288, 35);
            this.dateFechaAlta.TabIndex = 38;
            this.dateFechaAlta.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // cbTipoMaterial
            // 
            this.cbTipoMaterial.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMaterial.FormattingEnabled = true;
            this.cbTipoMaterial.Location = new System.Drawing.Point(769, 76);
            this.cbTipoMaterial.Name = "cbTipoMaterial";
            this.cbTipoMaterial.Size = new System.Drawing.Size(289, 37);
            this.cbTipoMaterial.TabIndex = 37;
            // 
            // lblFraccionArancelaria
            // 
            this.lblFraccionArancelaria.AutoSize = true;
            this.lblFraccionArancelaria.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraccionArancelaria.Location = new System.Drawing.Point(769, 368);
            this.lblFraccionArancelaria.Name = "lblFraccionArancelaria";
            this.lblFraccionArancelaria.Size = new System.Drawing.Size(272, 29);
            this.lblFraccionArancelaria.TabIndex = 35;
            this.lblFraccionArancelaria.Text = "9. Fracción arancelaria:";
            // 
            // lblUnidadesMedidaT
            // 
            this.lblUnidadesMedidaT.AutoSize = true;
            this.lblUnidadesMedidaT.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesMedidaT.Location = new System.Drawing.Point(400, 368);
            this.lblUnidadesMedidaT.Name = "lblUnidadesMedidaT";
            this.lblUnidadesMedidaT.Size = new System.Drawing.Size(152, 29);
            this.lblUnidadesMedidaT.TabIndex = 33;
            this.lblUnidadesMedidaT.Text = "8. U.M Tigie:";
            // 
            // lblUnidadesMedidaC
            // 
            this.lblUnidadesMedidaC.AutoSize = true;
            this.lblUnidadesMedidaC.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesMedidaC.Location = new System.Drawing.Point(16, 368);
            this.lblUnidadesMedidaC.Name = "lblUnidadesMedidaC";
            this.lblUnidadesMedidaC.Size = new System.Drawing.Size(284, 29);
            this.lblUnidadesMedidaC.TabIndex = 31;
            this.lblUnidadesMedidaC.Text = "7. U.M Comercialización:";
            // 
            // lblFechaUltimaModificacion
            // 
            this.lblFechaUltimaModificacion.AutoSize = true;
            this.lblFechaUltimaModificacion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaUltimaModificacion.Location = new System.Drawing.Point(769, 231);
            this.lblFechaUltimaModificacion.Name = "lblFechaUltimaModificacion";
            this.lblFechaUltimaModificacion.Size = new System.Drawing.Size(270, 29);
            this.lblFechaUltimaModificacion.TabIndex = 29;
            this.lblFechaUltimaModificacion.Text = "6. Ultima modificacion:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(400, 231);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(94, 29);
            this.lblFechaAlta.TabIndex = 27;
            this.lblFechaAlta.Text = "5. Alta:";
            // 
            // txtFactorConversion
            // 
            this.txtFactorConversion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorConversion.Location = new System.Drawing.Point(15, 270);
            this.txtFactorConversion.Name = "txtFactorConversion";
            this.txtFactorConversion.Size = new System.Drawing.Size(288, 35);
            this.txtFactorConversion.TabIndex = 26;
            // 
            // lblFactorConversion
            // 
            this.lblFactorConversion.AutoSize = true;
            this.lblFactorConversion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorConversion.Location = new System.Drawing.Point(16, 231);
            this.lblFactorConversion.Name = "lblFactorConversion";
            this.lblFactorConversion.Size = new System.Drawing.Size(276, 29);
            this.lblFactorConversion.TabIndex = 25;
            this.lblFactorConversion.Text = "4. Factor de conversión:";
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(769, 37);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(229, 29);
            this.lblTipoMaterial.TabIndex = 23;
            this.lblTipoMaterial.Text = "3. Tipo de material:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(400, 76);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 104);
            this.txtDescripcion.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(400, 37);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(175, 29);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "2. Descripción:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(16, 76);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(288, 35);
            this.txtClave.TabIndex = 20;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(16, 37);
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
            this.panelOpciones.Location = new System.Drawing.Point(3, 674);
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
            // Cat_MaterialesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 845);
            this.Controls.Add(this.tabControlMateriales);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Cat_MaterialesView";
            this.Text = "Cat_MaterialesView";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tabControlMateriales.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControlMateriales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelAddRefresh;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewDGC;
        private System.Windows.Forms.TabPage tabPageDetalles;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblFraccionArancelaria;
        private System.Windows.Forms.Label lblUnidadesMedidaT;
        private System.Windows.Forms.Label lblUnidadesMedidaC;
        private System.Windows.Forms.Label lblFechaUltimaModificacion;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtFactorConversion;
        private System.Windows.Forms.Label lblFactorConversion;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelTituloDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoMaterial;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.DateTimePicker dateFechaUltimaModificacion;
        private System.Windows.Forms.ComboBox cbUnidadesMedidaC;
        private System.Windows.Forms.ComboBox cbUnidadesMedidaT;
        private System.Windows.Forms.ComboBox cbFraccionArancelaria;
        private System.Windows.Forms.ComboBox cbPlantasBodegas;
        private System.Windows.Forms.Label lblPlantasBodegas;
        private System.Windows.Forms.ToolTip toolTip;
    }
}