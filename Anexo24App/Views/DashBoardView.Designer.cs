namespace Anexo24App.Views
{
    partial class DashBoardView
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.ImCatalogos = new FontAwesome.Sharp.IconMenuItem();
            this.datosDelContribuyenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submanufacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesAduanalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImInterfases = new FontAwesome.Sharp.IconMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeManufacturaYAjustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImAduanas = new FontAwesome.Sharp.IconMenuItem();
            this.importacionesTemporalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activoFijoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImProcesos = new FontAwesome.Sharp.IconMenuItem();
            this.entradasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosYAjustesDeManufacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImReportes = new FontAwesome.Sharp.IconMenuItem();
            this.ImMas = new FontAwesome.Sharp.IconMenuItem();
            this.ImConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.panelTitulo.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTitulo.Controls.Add(this.panelExit);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1261, 61);
            this.panelTitulo.TabIndex = 2;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.btnExit);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExit.Location = new System.Drawing.Point(1033, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(228, 61);
            this.panelExit.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(12, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Cerrar Sesion";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEMA DE CONTROL DE INVENTARIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.mainmenuStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 43);
            this.panel2.TabIndex = 3;
            // 
            // mainmenuStrip
            // 
            this.mainmenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImCatalogos,
            this.ImInterfases,
            this.ImAduanas,
            this.ImProcesos,
            this.ImReportes,
            this.ImMas,
            this.ImConfiguracion});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Size = new System.Drawing.Size(1261, 43);
            this.mainmenuStrip.TabIndex = 0;
            this.mainmenuStrip.Text = "menuStrip1";
            // 
            // ImCatalogos
            // 
            this.ImCatalogos.BackColor = System.Drawing.Color.White;
            this.ImCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelContribuyenteToolStripMenuItem,
            this.materialesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.submanufacturaToolStripMenuItem,
            this.agentesAduanalesToolStripMenuItem,
            this.activoFijoToolStripMenuItem});
            this.ImCatalogos.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImCatalogos.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.ImCatalogos.IconColor = System.Drawing.Color.Black;
            this.ImCatalogos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImCatalogos.IconSize = 200;
            this.ImCatalogos.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImCatalogos.Name = "ImCatalogos";
            this.ImCatalogos.Size = new System.Drawing.Size(159, 39);
            this.ImCatalogos.Text = "Catalogos";
            // 
            // datosDelContribuyenteToolStripMenuItem
            // 
            this.datosDelContribuyenteToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosDelContribuyenteToolStripMenuItem.Name = "datosDelContribuyenteToolStripMenuItem";
            this.datosDelContribuyenteToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.datosDelContribuyenteToolStripMenuItem.Text = "Datos del contribuyente";
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.materialesToolStripMenuItem.Text = "Materiales";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // submanufacturaToolStripMenuItem
            // 
            this.submanufacturaToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submanufacturaToolStripMenuItem.Name = "submanufacturaToolStripMenuItem";
            this.submanufacturaToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.submanufacturaToolStripMenuItem.Text = "Submanufactura";
            // 
            // agentesAduanalesToolStripMenuItem
            // 
            this.agentesAduanalesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentesAduanalesToolStripMenuItem.Name = "agentesAduanalesToolStripMenuItem";
            this.agentesAduanalesToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.agentesAduanalesToolStripMenuItem.Text = "Agentes aduanales";
            // 
            // activoFijoToolStripMenuItem
            // 
            this.activoFijoToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoFijoToolStripMenuItem.Name = "activoFijoToolStripMenuItem";
            this.activoFijoToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.activoFijoToolStripMenuItem.Text = "Activo fijo";
            // 
            // ImInterfases
            // 
            this.ImInterfases.BackColor = System.Drawing.Color.White;
            this.ImInterfases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.movimientosDeManufacturaYAjustesToolStripMenuItem});
            this.ImInterfases.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImInterfases.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.ImInterfases.IconColor = System.Drawing.Color.Black;
            this.ImInterfases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImInterfases.IconSize = 90;
            this.ImInterfases.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImInterfases.Name = "ImInterfases";
            this.ImInterfases.Size = new System.Drawing.Size(164, 39);
            this.ImInterfases.Text = "Interfases";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(505, 34);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(505, 34);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // movimientosDeManufacturaYAjustesToolStripMenuItem
            // 
            this.movimientosDeManufacturaYAjustesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosDeManufacturaYAjustesToolStripMenuItem.Name = "movimientosDeManufacturaYAjustesToolStripMenuItem";
            this.movimientosDeManufacturaYAjustesToolStripMenuItem.Size = new System.Drawing.Size(505, 34);
            this.movimientosDeManufacturaYAjustesToolStripMenuItem.Text = "Movimientos de manufactura y ajustes";
            // 
            // ImAduanas
            // 
            this.ImAduanas.BackColor = System.Drawing.Color.White;
            this.ImAduanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importacionesTemporalesToolStripMenuItem,
            this.entradasToolStripMenuItem1,
            this.salidasToolStripMenuItem1,
            this.activoFijoToolStripMenuItem1});
            this.ImAduanas.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImAduanas.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.ImAduanas.IconColor = System.Drawing.Color.Black;
            this.ImAduanas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImAduanas.IconSize = 90;
            this.ImAduanas.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImAduanas.Name = "ImAduanas";
            this.ImAduanas.Size = new System.Drawing.Size(143, 39);
            this.ImAduanas.Text = "Aduanas";
            // 
            // importacionesTemporalesToolStripMenuItem
            // 
            this.importacionesTemporalesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importacionesTemporalesToolStripMenuItem.Name = "importacionesTemporalesToolStripMenuItem";
            this.importacionesTemporalesToolStripMenuItem.Size = new System.Drawing.Size(369, 34);
            this.importacionesTemporalesToolStripMenuItem.Text = "Importaciones temporales";
            // 
            // entradasToolStripMenuItem1
            // 
            this.entradasToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradasToolStripMenuItem1.Name = "entradasToolStripMenuItem1";
            this.entradasToolStripMenuItem1.Size = new System.Drawing.Size(369, 34);
            this.entradasToolStripMenuItem1.Text = "Entradas";
            // 
            // salidasToolStripMenuItem1
            // 
            this.salidasToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasToolStripMenuItem1.Name = "salidasToolStripMenuItem1";
            this.salidasToolStripMenuItem1.Size = new System.Drawing.Size(369, 34);
            this.salidasToolStripMenuItem1.Text = "Salidas";
            // 
            // activoFijoToolStripMenuItem1
            // 
            this.activoFijoToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoFijoToolStripMenuItem1.Name = "activoFijoToolStripMenuItem1";
            this.activoFijoToolStripMenuItem1.Size = new System.Drawing.Size(369, 34);
            this.activoFijoToolStripMenuItem1.Text = "Activo fijo";
            // 
            // ImProcesos
            // 
            this.ImProcesos.BackColor = System.Drawing.Color.White;
            this.ImProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem2,
            this.salidasToolStripMenuItem2,
            this.movimientosYAjustesDeManufacturaToolStripMenuItem,
            this.descargosToolStripMenuItem});
            this.ImProcesos.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImProcesos.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ImProcesos.IconColor = System.Drawing.Color.Black;
            this.ImProcesos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImProcesos.IconSize = 90;
            this.ImProcesos.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImProcesos.Name = "ImProcesos";
            this.ImProcesos.Size = new System.Drawing.Size(146, 39);
            this.ImProcesos.Text = "Procesos";
            // 
            // entradasToolStripMenuItem2
            // 
            this.entradasToolStripMenuItem2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradasToolStripMenuItem2.Name = "entradasToolStripMenuItem2";
            this.entradasToolStripMenuItem2.Size = new System.Drawing.Size(505, 34);
            this.entradasToolStripMenuItem2.Text = "Entradas";
            // 
            // salidasToolStripMenuItem2
            // 
            this.salidasToolStripMenuItem2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasToolStripMenuItem2.Name = "salidasToolStripMenuItem2";
            this.salidasToolStripMenuItem2.Size = new System.Drawing.Size(505, 34);
            this.salidasToolStripMenuItem2.Text = "Salidas";
            // 
            // movimientosYAjustesDeManufacturaToolStripMenuItem
            // 
            this.movimientosYAjustesDeManufacturaToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosYAjustesDeManufacturaToolStripMenuItem.Name = "movimientosYAjustesDeManufacturaToolStripMenuItem";
            this.movimientosYAjustesDeManufacturaToolStripMenuItem.Size = new System.Drawing.Size(505, 34);
            this.movimientosYAjustesDeManufacturaToolStripMenuItem.Text = "Movimientos y ajustes de manufactura";
            // 
            // descargosToolStripMenuItem
            // 
            this.descargosToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descargosToolStripMenuItem.Name = "descargosToolStripMenuItem";
            this.descargosToolStripMenuItem.Size = new System.Drawing.Size(505, 34);
            this.descargosToolStripMenuItem.Text = "Descargos";
            // 
            // ImReportes
            // 
            this.ImReportes.BackColor = System.Drawing.Color.White;
            this.ImReportes.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ImReportes.IconColor = System.Drawing.Color.Black;
            this.ImReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImReportes.IconSize = 90;
            this.ImReportes.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImReportes.Name = "ImReportes";
            this.ImReportes.Size = new System.Drawing.Size(150, 39);
            this.ImReportes.Text = "Reportes";
            // 
            // ImMas
            // 
            this.ImMas.BackColor = System.Drawing.Color.White;
            this.ImMas.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImMas.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.ImMas.IconColor = System.Drawing.Color.Black;
            this.ImMas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImMas.IconSize = 90;
            this.ImMas.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImMas.Name = "ImMas";
            this.ImMas.Size = new System.Drawing.Size(88, 39);
            this.ImMas.Text = "Mas";
            // 
            // ImConfiguracion
            // 
            this.ImConfiguracion.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ImConfiguracion.IconColor = System.Drawing.Color.Black;
            this.ImConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImConfiguracion.IconSize = 90;
            this.ImConfiguracion.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.ImConfiguracion.Name = "ImConfiguracion";
            this.ImConfiguracion.Size = new System.Drawing.Size(210, 39);
            this.ImConfiguracion.Text = "Configuracion";
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DashBoardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoardView_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mainmenuStrip;
        private FontAwesome.Sharp.IconMenuItem ImCatalogos;
        private FontAwesome.Sharp.IconMenuItem ImReportes;
        private FontAwesome.Sharp.IconMenuItem ImAduanas;
        private FontAwesome.Sharp.IconMenuItem ImInterfases;
        private FontAwesome.Sharp.IconMenuItem ImProcesos;
        private FontAwesome.Sharp.IconMenuItem ImMas;
        private FontAwesome.Sharp.IconMenuItem ImConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem datosDelContribuyenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submanufacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentesAduanalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeManufacturaYAjustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionesTemporalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem activoFijoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem movimientosYAjustesDeManufacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargosToolStripMenuItem;
        private System.Windows.Forms.Panel panelExit;
    }
}