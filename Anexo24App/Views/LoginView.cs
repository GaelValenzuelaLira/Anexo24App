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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();

            //Ponemos de background esta imagen 
            this.BackgroundImage = Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            //Ejecutamos la ventana principal(DashBoardView)
            //Nota: Aun no cuenta con validaciones de contraseña, simplemente llamamos al form principal

            DashBoardView DashBoardView = new DashBoardView();
            DashBoardView.Show();
            this.Hide();
        }
    }
}
