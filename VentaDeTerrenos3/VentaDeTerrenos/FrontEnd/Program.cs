/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/9/2019
 * Time: 8:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using VentaDeTerrenos.BackEnd;

namespace VentaDeTerrenos
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuVentas2());
		}
		
	}
}
