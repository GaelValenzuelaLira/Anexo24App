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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.dawdawdwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Interfases = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submanufacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentesAduanalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeManufacturaYAjustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionesTemporalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activoFijoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosYAjustesDeManufacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 61);
            this.panel1.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(1045, 12);
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
            this.iconMenuItem1,
            this.Interfases,
            this.iconMenuItem4,
            this.iconMenuItem5,
            this.iconMenuItem2,
            this.iconMenuItem6,
            this.iconMenuItem7});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Size = new System.Drawing.Size(1261, 43);
            this.mainmenuStrip.TabIndex = 0;
            this.mainmenuStrip.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.BackColor = System.Drawing.Color.White;
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dawdawdwToolStripMenuItem,
            this.materialesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.submanufacturaToolStripMenuItem,
            this.agentesAduanalesToolStripMenuItem,
            this.activoFijoToolStripMenuItem});
            this.iconMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 200;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(159, 39);
            this.iconMenuItem1.Text = "Catalogos";
            // 
            // dawdawdwToolStripMenuItem
            // 
            this.dawdawdwToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dawdawdwToolStripMenuItem.Name = "dawdawdwToolStripMenuItem";
            this.dawdawdwToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.dawdawdwToolStripMenuItem.Text = "Datos del contribuyente";
            // 
            // Interfases
            // 
            this.Interfases.BackColor = System.Drawing.Color.White;
            this.Interfases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.movimientosDeManufacturaYAjustesToolStripMenuItem});
            this.Interfases.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interfases.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.Interfases.IconColor = System.Drawing.Color.Black;
            this.Interfases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Interfases.IconSize = 90;
            this.Interfases.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.Interfases.Name = "Interfases";
            this.Interfases.Size = new System.Drawing.Size(164, 39);
            this.Interfases.Text = "Interfases";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.BackColor = System.Drawing.Color.White;
            this.iconMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importacionesTemporalesToolStripMenuItem,
            this.entradasToolStripMenuItem1,
            this.salidasToolStripMenuItem1,
            this.activoFijoToolStripMenuItem1});
            this.iconMenuItem4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 90;
            this.iconMenuItem4.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(143, 39);
            this.iconMenuItem4.Text = "Aduanas";
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.BackColor = System.Drawing.Color.White;
            this.iconMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem2,
            this.salidasToolStripMenuItem2,
            this.movimientosYAjustesDeManufacturaToolStripMenuItem,
            this.descargosToolStripMenuItem});
            this.iconMenuItem5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 90;
            this.iconMenuItem5.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(146, 39);
            this.iconMenuItem5.Text = "Procesos";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.BackColor = System.Drawing.Color.White;
            this.iconMenuItem2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 90;
            this.iconMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(150, 39);
            this.iconMenuItem2.Text = "Reportes";
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.BackColor = System.Drawing.Color.White;
            this.iconMenuItem6.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.IconSize = 90;
            this.iconMenuItem6.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(88, 39);
            this.iconMenuItem6.Text = "Mas";
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconMenuItem7.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem7.IconSize = 90;
            this.iconMenuItem7.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Size = new System.Drawing.Size(210, 39);
            this.iconMenuItem7.Text = "Configuracion";
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
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardView";
            this.Load += new System.EventHandler(this.DashBoardView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mainmenuStrip;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem Interfases;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem dawdawdwToolStripMenuItem;
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
    }
}