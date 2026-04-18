namespace Anexo24App.Views
{
    partial class Int_EntradasView
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlDGC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelAddRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panelBusquedas = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewE = new System.Windows.Forms.DataGridView();
            this.tabPageDetalles = new System.Windows.Forms.TabPage();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTituloDetalles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstadoT = new System.Windows.Forms.ComboBox();
            this.lblEstadoT = new System.Windows.Forms.Label();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTrans = new System.Windows.Forms.Label();
            this.lblMontoUSD = new System.Windows.Forms.Label();
            this.txtMontoUSD = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            this.tabControlDGC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelAddRefresh.SuspendLayout();
            this.panelBusquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(110, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Entradas";
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
            this.tabControlDGC.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelAddRefresh);
            this.tabPage1.Controls.Add(this.panelBusquedas);
            this.tabPage1.Controls.Add(this.dataGridViewE);
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
            this.toolTip.SetToolTip(this.btnAdd, "Cargar nuevo pedimento");
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
            // dataGridViewE
            // 
            this.dataGridViewE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewE.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewE.Name = "dataGridViewE";
            this.dataGridViewE.RowHeadersWidth = 51;
            this.dataGridViewE.Size = new System.Drawing.Size(1124, 597);
            this.dataGridViewE.TabIndex = 0;
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
            this.panelDatos.Controls.Add(this.txtMontoUSD);
            this.panelDatos.Controls.Add(this.lblMontoUSD);
            this.panelDatos.Controls.Add(this.dateFechaAlta);
            this.panelDatos.Controls.Add(this.lblFechaTrans);
            this.panelDatos.Controls.Add(this.cbEstadoT);
            this.panelDatos.Controls.Add(this.lblEstadoT);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(3, 50);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1124, 466);
            this.panelDatos.TabIndex = 20;
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
            // cbEstadoT
            // 
            this.cbEstadoT.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoT.FormattingEnabled = true;
            this.cbEstadoT.Location = new System.Drawing.Point(16, 76);
            this.cbEstadoT.Name = "cbEstadoT";
            this.cbEstadoT.Size = new System.Drawing.Size(289, 37);
            this.cbEstadoT.TabIndex = 42;
            // 
            // lblEstadoT
            // 
            this.lblEstadoT.AutoSize = true;
            this.lblEstadoT.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoT.Location = new System.Drawing.Point(16, 37);
            this.lblEstadoT.Name = "lblEstadoT";
            this.lblEstadoT.Size = new System.Drawing.Size(288, 29);
            this.lblEstadoT.TabIndex = 41;
            this.lblEstadoT.Text = "1. Estado de transmisión:";
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.CalendarFont = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAlta.Location = new System.Drawing.Point(400, 76);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(288, 35);
            this.dateFechaAlta.TabIndex = 44;
            this.dateFechaAlta.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // lblFechaTrans
            // 
            this.lblFechaTrans.AutoSize = true;
            this.lblFechaTrans.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTrans.Location = new System.Drawing.Point(400, 37);
            this.lblFechaTrans.Name = "lblFechaTrans";
            this.lblFechaTrans.Size = new System.Drawing.Size(280, 29);
            this.lblFechaTrans.TabIndex = 43;
            this.lblFechaTrans.Text = "2. Fecha de transmisión:";
            // 
            // lblMontoUSD
            // 
            this.lblMontoUSD.AutoSize = true;
            this.lblMontoUSD.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoUSD.Location = new System.Drawing.Point(769, 37);
            this.lblMontoUSD.Name = "lblMontoUSD";
            this.lblMontoUSD.Size = new System.Drawing.Size(227, 29);
            this.lblMontoUSD.TabIndex = 45;
            this.lblMontoUSD.Text = "3. Monto total USD:";
            // 
            // txtMontoUSD
            // 
            this.txtMontoUSD.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoUSD.Location = new System.Drawing.Point(769, 76);
            this.txtMontoUSD.Name = "txtMontoUSD";
            this.txtMontoUSD.Size = new System.Drawing.Size(288, 35);
            this.txtMontoUSD.TabIndex = 46;
            // 
            // Int_EntradasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 687);
            this.Controls.Add(this.tabControlDGC);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Int_EntradasView";
            this.Text = "Int_EntradasView";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tabControlDGC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelAddRefresh.ResumeLayout(false);
            this.panelBusquedas.ResumeLayout(false);
            this.panelBusquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControlDGC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelAddRefresh;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewE;
        private System.Windows.Forms.TabPage tabPageDetalles;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelTituloDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstadoT;
        private System.Windows.Forms.Label lblEstadoT;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.Label lblFechaTrans;
        private System.Windows.Forms.Label lblMontoUSD;
        private System.Windows.Forms.TextBox txtMontoUSD;
    }
}