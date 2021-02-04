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

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class MenuVentas : Form
	{
		int globalWidth;
		int globalHeight;
		const int asesor = 5;
		public MenuVentas()
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
		void MenuVentasLoad(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			globalWidth = this.Width;
			globalHeight = this.Height;

			btnVender.Width = globalWidth/asesor-5;
			button2.Width = globalWidth/asesor-5;
			btnVendido.Width = globalWidth/asesor-5;
			bnConfigUsers.Width = globalWidth/asesor-5;
			button4.Width = globalWidth/asesor-5;
			btnVender.Height = globalHeight;
			button2.Height = globalHeight;
			btnVendido.Height = globalHeight;
			button4.Height = globalHeight;
			bnConfigUsers.Height = globalHeight;
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			Ventas mostrarVentas = new Ventas();
			mostrarVentas.ShowDialog();
			this.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void bnConfigUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Config configUsuarios = new Config();
            configUsuarios.ShowDialog();
            this.Show();
        }
    }
	
}
