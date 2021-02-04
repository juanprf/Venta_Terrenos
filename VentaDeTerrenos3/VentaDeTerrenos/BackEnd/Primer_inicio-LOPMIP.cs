/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 08/11/2019
 * Time: 10:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Primer_inicio : Form
	{
		public Primer_inicio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        DataBase baseDeDatos = new DataBase();
        void TxtPasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.FromArgb(0, 0, 0);
                txtPassword.PasswordChar = '*';
            }
        }
        void TxtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
            }
        }
        void TxtConfirmPasswordEnter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Clear();
                txtConfirmPassword.ForeColor = Color.FromArgb(0, 0, 0);
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        void TxtConfirmPasswordLeave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.PasswordChar = '\0';
                txtConfirmPassword.Text = "Confirm Password";
                txtConfirmPassword.ForeColor = Color.FromArgb(152, 152, 152);
            }
        }
        void TxtsChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text != "Password" && txtConfirmPassword.Text != "Confirm Password")
                {
                    btnGuardar.Enabled = true;
                }
                else btnGuardar.Enabled = false;
            }
            else btnGuardar.Enabled = false;
        }
        void BtnGuardarClick(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 5)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (baseDeDatos.PrimerIngreso(txtPassword.Text) == true)
                    {
                        txtPassword.Text = "Password";
                        txtConfirmPassword.Text = "Confirm Password";
                        txtConfirmPassword.ForeColor = Color.FromArgb(152, 152, 152);
                        txtPassword.PasswordChar = '\0';
                        txtConfirmPassword.PasswordChar = '\0';
                    }
                }
                else
                    MessageBox.Show("La contraseña no coincide", "Error en la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Length < 5) MessageBox.Show("La contraseña es demasiado corta\nEsta debe contener almenos 5 caracteres", "Contraseña debil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
