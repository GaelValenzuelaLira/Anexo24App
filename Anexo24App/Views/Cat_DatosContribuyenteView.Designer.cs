namespace Anexo24App.Views
{
    partial class Cat_DatosContribuyenteView
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.txtNumeroProgramaIMMEX = new System.Windows.Forms.TextBox();
            this.lblNumeroProgramaIMMEX = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdvertencia = new System.Windows.Forms.ToolTip(this.components);
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.tabControlDGC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelAddRefresh.SuspendLayout();
            this.panelBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGC)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1155, 47);
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
            this.lblTitulo.Size = new System.Drawing.Size(405, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos Generales del Contribuyente";
            // 
            // tabControlDGC
            // 
            this.tabControlDGC.Controls.Add(this.tabPage1);
            this.tabControlDGC.Controls.Add(this.tabPage2);
            this.tabControlDGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDGC.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDGC.Location = new System.Drawing.Point(0, 47);
            this.tabControlDGC.Name = "tabControlDGC";
            this.tabControlDGC.SelectedIndex = 0;
            this.tabControlDGC.Size = new System.Drawing.Size(1155, 690);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 653);
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
            this.panelAddRefresh.Size = new System.Drawing.Size(1141, 54);
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
            this.btnRefresh.Location = new System.Drawing.Point(1070, 0);
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
            this.panelBusquedas.Size = new System.Drawing.Size(1141, 37);
            this.panelBusquedas.TabIndex = 1;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(0, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(1141, 35);
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
            this.dataGridViewDGC.Size = new System.Drawing.Size(1141, 647);
            this.dataGridViewDGC.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelOpciones);
            this.tabPage2.Controls.Add(this.txtMunicipio);
            this.tabPage2.Controls.Add(this.lblMunicipio);
            this.tabPage2.Controls.Add(this.txtEntidadFederativa);
            this.tabPage2.Controls.Add(this.lblEntidadFederativa);
            this.tabPage2.Controls.Add(this.txtColonia);
            this.tabPage2.Controls.Add(this.lblColonia);
            this.tabPage2.Controls.Add(this.txtCP);
            this.tabPage2.Controls.Add(this.lblCP);
            this.tabPage2.Controls.Add(this.txtNumero);
            this.tabPage2.Controls.Add(this.lblNumero);
            this.tabPage2.Controls.Add(this.txtCalle);
            this.tabPage2.Controls.Add(this.lblCalle);
            this.tabPage2.Controls.Add(this.txtNumeroProgramaIMMEX);
            this.tabPage2.Controls.Add(this.lblNumeroProgramaIMMEX);
            this.tabPage2.Controls.Add(this.txtRFC);
            this.tabPage2.Controls.Add(this.lblRFC);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtRazonSocial);
            this.tabPage2.Controls.Add(this.lblRazonSocial);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(480, 459);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(288, 35);
            this.txtMunicipio.TabIndex = 18;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(475, 420);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(144, 29);
            this.lblMunicipio.TabIndex = 17;
            this.lblMunicipio.Text = "9. Municipio";
            // 
            // txtEntidadFederativa
            // 
            this.txtEntidadFederativa.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidadFederativa.Location = new System.Drawing.Point(480, 370);
            this.txtEntidadFederativa.Name = "txtEntidadFederativa";
            this.txtEntidadFederativa.Size = new System.Drawing.Size(288, 35);
            this.txtEntidadFederativa.TabIndex = 16;
            // 
            // lblEntidadFederativa
            // 
            this.lblEntidadFederativa.AutoSize = true;
            this.lblEntidadFederativa.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadFederativa.Location = new System.Drawing.Point(475, 331);
            this.lblEntidadFederativa.Name = "lblEntidadFederativa";
            this.lblEntidadFederativa.Size = new System.Drawing.Size(243, 29);
            this.lblEntidadFederativa.TabIndex = 15;
            this.lblEntidadFederativa.Text = "8. Entidad federativa";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(480, 281);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(288, 35);
            this.txtColonia.TabIndex = 14;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(475, 242);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(122, 29);
            this.lblColonia.TabIndex = 13;
            this.lblColonia.Text = "7. Colonia";
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(480, 192);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(288, 35);
            this.txtCP.TabIndex = 12;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(475, 153);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(78, 29);
            this.lblCP.TabIndex = 11;
            this.lblCP.Text = "6. CP:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(480, 103);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(288, 35);
            this.txtNumero.TabIndex = 10;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(475, 64);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(134, 29);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "5. Número:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(14, 399);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(288, 35);
            this.txtCalle.TabIndex = 8;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(9, 360);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(105, 29);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "4. Calle:";
            // 
            // txtNumeroProgramaIMMEX
            // 
            this.txtNumeroProgramaIMMEX.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroProgramaIMMEX.Location = new System.Drawing.Point(14, 310);
            this.txtNumeroProgramaIMMEX.Name = "txtNumeroProgramaIMMEX";
            this.txtNumeroProgramaIMMEX.Size = new System.Drawing.Size(288, 35);
            this.txtNumeroProgramaIMMEX.TabIndex = 6;
            // 
            // lblNumeroProgramaIMMEX
            // 
            this.lblNumeroProgramaIMMEX.AutoSize = true;
            this.lblNumeroProgramaIMMEX.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroProgramaIMMEX.Location = new System.Drawing.Point(9, 242);
            this.lblNumeroProgramaIMMEX.Name = "lblNumeroProgramaIMMEX";
            this.lblNumeroProgramaIMMEX.Size = new System.Drawing.Size(274, 58);
            this.lblNumeroProgramaIMMEX.TabIndex = 5;
            this.lblNumeroProgramaIMMEX.Text = "3. Número de programa \r\nIMMEX:";
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(14, 192);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(288, 35);
            this.txtRFC.TabIndex = 4;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(9, 153);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(92, 29);
            this.lblRFC.TabIndex = 3;
            this.lblRFC.Text = "2. RFC:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 47);
            this.panel1.TabIndex = 2;
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
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(14, 103);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(288, 35);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(9, 64);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(186, 29);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "1. Razon Social:";
            // 
            // toolTipAdvertencia
            // 
            this.toolTipAdvertencia.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAdvertencia.ToolTipTitle = "Advertencia";
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelOpciones.Controls.Add(this.btnCancel);
            this.panelOpciones.Controls.Add(this.btnSave);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpciones.Location = new System.Drawing.Point(3, 566);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1141, 84);
            this.panelOpciones.TabIndex = 19;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1013, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 84);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // Cat_DatosContribuyenteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 737);
            this.Controls.Add(this.tabControlDGC);
            this.Controls.Add(this.panelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cat_DatosContribuyenteView";
            this.Text = "Cat_DatosContribuyenteView";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tabControlDGC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelAddRefresh.ResumeLayout(false);
            this.panelBusquedas.ResumeLayout(false);
            this.panelBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDGC)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlDGC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewDGC;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panelAddRefresh;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipAdvertencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumeroProgramaIMMEX;
        private System.Windows.Forms.Label lblNumeroProgramaIMMEX;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblEntidadFederativa;
        private System.Windows.Forms.TextBox txtEntidadFederativa;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}