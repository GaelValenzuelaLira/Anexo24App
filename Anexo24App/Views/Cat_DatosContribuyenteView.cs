using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anexo24App.Views
{
    public partial class Cat_DatosContribuyenteView : Form
    {
        public Cat_DatosContribuyenteView()
        {
            InitializeComponent();
        }

        private void Cat_DatosContribuyenteView_Load(object sender, EventArgs e)
        {
            //Al cargar el form calculamos posiciones:
            
            //Primera fila 
            lblRazonSocial.Location = new Point(
                0,
                15
            );
            txtRazonSocial.Location = new Point(
                lblRazonSocial.Location.X,
                lblRazonSocial.Location.Y + lblRazonSocial.Height + 10
            );

            lblRFC.Location = new Point(
                panelDatos.Width / 2 - (txtRFC.Width / 2),
                15
            );
            txtRFC.Location = new Point(
                lblRFC.Location.X,
                lblRFC.Location.Y + lblRFC.Height + 10
            );

            lblNumeroProgramaIMMEX.Location = new Point(
                panelDatos.Location.X + panelDatos.Width - lblNumeroProgramaIMMEX.Width,
                15
            );
            txtNumeroProgramaIMMEX.Location = new Point(
                lblNumeroProgramaIMMEX.Location.X,
                lblNumeroProgramaIMMEX.Location.Y + lblNumeroProgramaIMMEX.Height + 10
            );

            //Segunda fila 
            lblCalle.Location = new Point(
                0,
                panelDatos.Height / 2 - (lblCalle.Height / 2)
            );
            txtCalle.Location = new Point(
                lblCalle.Location.X,
                lblCalle.Location.Y + lblCalle.Height + 10
            );

            lblNumero.Location = new Point(
                lblRFC.Location.X,
                lblCalle.Location.Y
            );
            txtNumero.Location = new Point(
                lblNumero.Location.X,
                lblNumero.Location.Y + lblNumero.Height + 10
            );

            lblCP.Location = new Point(
                lblNumeroProgramaIMMEX.Location.X,
                lblNumero.Location.Y
            );
            txtCP.Location = new Point(
                lblCP.Location.X,
                lblCP.Location.Y + lblCP.Height + 10
            );

            //Tercer fila 
            txtColonia.Location = new Point(
                lblCalle.Location.X,
                panelDatos.Height - txtColonia.Height - 10
            );
            lblColonia.Location = new Point(
                txtColonia.Location.X,
                txtColonia.Location.Y - lblColonia.Height - 10
            );

            lblEntidadFederativa.Location = new Point(
                lblNumero.Location.X,
                lblColonia.Location.Y
            );
            txtEntidadFederativa.Location = new Point(
                lblEntidadFederativa.Location.X,
                txtColonia.Location.Y
            );

            lblMunicipio.Location = new Point(
                lblCP.Location.X,
                lblEntidadFederativa.Location.Y
            );
            txtMunicipio.Location = new Point(
                lblMunicipio.Location.X,
                txtEntidadFederativa.Location.Y
            );
        }
    }
}
