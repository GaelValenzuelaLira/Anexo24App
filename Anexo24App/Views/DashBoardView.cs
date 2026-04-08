using FontAwesome.Sharp;
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
    public partial class DashBoardView : Form
    {
        private bool mouseencimademenustrip = false;

        public DashBoardView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashBoardView_Load(object sender, EventArgs e)
        {
            DespliegueAutomatico(mainmenuStrip);
            CierreAutomatico(mainmenuStrip);
        }


        // region funciones creadas

        #region
        private void DespliegueAutomatico(MenuStrip menuStrip)
        {
            foreach (IconMenuItem item in menuStrip.Items.OfType<IconMenuItem>())
            {
                item.MouseEnter += (s, e) =>
                {
                    foreach (IconMenuItem x in menuStrip.Items.OfType<IconMenuItem>())
                    {
                        if (x != item)
                        {
                            x.HideDropDown();
                        }
                        else
                        {
                            item.ShowDropDown();
                        }
                    }
                };
            }
        }

        private void CierreAutomatico(MenuStrip menuStrip)
        {
            foreach (IconMenuItem item in menuStrip.Items.OfType<IconMenuItem>())
            {
                item.DropDown.MouseLeave += (s, e) =>
                {
                    if (!item.DropDown.Bounds.Contains(Cursor.Position) && !item.Bounds.Contains(menuStrip.PointToClient(Cursor.Position)))
                    {
                        item.HideDropDown();
                    }
                };
            }
        }


        #endregion

        //fin region funciones



    }
}


