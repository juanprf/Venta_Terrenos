/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/21/2019
 * Time: 4:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using UsuarioCache.Cache;
using System.Threading;
using System.Threading.Tasks;

namespace VentaDeTerrenos.BackEnd
{
    /// <summary>
    /// Description of Menu.
    /// </summary>
    public partial class MenuVentas2 : Form
    {
        private Form activeForm = null;
        int globalHeight;

        public MenuVentas2()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void BtnLogOutClick(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Carga de la pantalla
        //
        void MenuVentasLoad(object sender, EventArgs e)
        {
            lblUsarioActual.Text = UsuarioLoginCache.userNameAct;
            lblUserFolio.Text = UsuarioLoginCache.folioAsesor;
            panelVentas.Visible = false;
            panelBuscar.Visible = false;
            panelVisual.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            globalHeight = this.Height;
            lblUsarioActual.Font = new Font("Microsoft Sans Serif", 15 * globalHeight / 670, FontStyle.Regular);
            lblUserFolio.Font = new Font("Microsoft Sans Serif", 15 * globalHeight / 670, FontStyle.Regular);
            this.picLogo.Height = (globalHeight * picLogo.Height) / 670;
            this.btnVentas.Height = (globalHeight * btnVentas.Height) / 670;
            this.btnVender.Height = (globalHeight * btnVender.Height) / 670;
            this.btnBuscar.Height = (globalHeight * btnBuscar.Height) / 670;
            this.btnTerrenos.Height = (globalHeight * btnTerrenos.Height) / 670;
            this.btnLogOut.Height = (globalHeight * btnLogOut.Height) / 670;
            this.btnConfigUsers.Height = (globalHeight * btnConfigUsers.Height) / 670;
            this.panelVentas.Height = (globalHeight * panelVentas.Height) / 670;
            this.panelBuscar.Height = (globalHeight * panelBuscar.Height) / 670;
        }
        //
        //Boton de Sub menu Ventas
        //
        void btnVentasClick(object sender, EventArgs e)
        {
            showSubMenu(panelVentas);
        }
        //
        //Boton de Sub menu Buscar
        //
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBuscar);
        }
        //
        //Boton de nueva venta
        //
        private void btnVenderClick(object sender, EventArgs e)
        {
            openchildForm(new Ventas(), new Loading());
        }
        //
        //Boton de Buscar por Terrenos
        //
        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            openchildForm(new Buscar(), new Loading());
        }
        void btnLogOutClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hideSubMenu()
        {
            if (panelVentas.Visible == true)
                panelVentas.Visible = false;
            if (panelBuscar.Visible == true)
                panelBuscar.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnConfigUsers_Click(object sender, EventArgs e)
        {
            openchildForm(new Config(), new Loading());
        }
        private void openchildForm(Form childForm, Form carga)
        {
            if (activeForm != null)
            {
                panelVisual.Visible = false;
                activeForm.Close();
            }
            carga.TopLevel = false;
            carga.Dock = DockStyle.Fill;
            panelVisualCarga.Controls.Add(carga);
            carga.Show();
            carga.BringToFront();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelVisual.Controls.Add(childForm);
            panelVisual.Tag = childForm;
            panelVisual.Visible = true;
            childForm.Show();
        }
    }
}
