/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 21/10/2019
 * Time: 11:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of RegistraUsuario.
	/// </summary>
	public partial class RegistraUsuario : Form
	{
        DataBase baseDeDatos;
        public RegistraUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
            baseDeDatos = new DataBase();
            
			if(txtPassword.Text.Length >= 5)
			{
				if(txtPassword.Text == txtConfirmPassword.Text)
				{
                    if(baseDeDatos.GuardarUsuario(txtUserName.Text,txtPassword.Text,txtNombre.Text,txtApellidoP.Text,txtApellidoM.Text) == true)
                    {
                        txtUserName.Text = "Nombre de usuario";
                        txtNombre.Text = "Nombre";
                        txtApellidoP.Text = "Apellido Paterno";
                        txtApellidoM.Text = "Apellido Materno";
                        txtPassword.Text = "Password";
                        txtConfirmPassword.Text = "Confirm Password";
                        txtUserName.ForeColor = Color.FromArgb(152, 152, 152);
                        txtNombre.ForeColor = Color.FromArgb(152, 152, 152);
                        txtApellidoP.ForeColor = Color.FromArgb(152, 152, 152);
                        txtApellidoM.ForeColor = Color.FromArgb(152, 152, 152);
                        txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
                        txtConfirmPassword.ForeColor = Color.FromArgb(152, 152, 152);
                        txtPassword.PasswordChar = '\0';
                        txtConfirmPassword.PasswordChar = '\0';
                    }
				}
				else 
					MessageBox.Show("La contraseña no coincide","Error en la contraseña", MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if(txtPassword.Text.Length < 5)MessageBox.Show("La contraseña es demasiado corta\nEsta debe contener almenos 5 caracteres","Contraseña debil",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		void TxtUserNameEnter(object sender, EventArgs e)
		{
			if(txtUserName.Text == "Nombre de usuario")
			{
				txtUserName.Clear();
				txtUserName.ForeColor = Color.FromArgb(0,0,0);
			}
		}
		void TxtUserNameLeave(object sender, EventArgs e)
		{
			if(txtUserName.Text == "")
			{
				txtUserName.Text = "Nombre de usuario";
				txtUserName.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtNombreEnter(object sender, EventArgs e)
		{
			if(txtNombre.Text == "Nombre")
			{
				txtNombre.Clear();
				txtNombre.ForeColor = Color.FromArgb(0,0,0);
			}
		}
		void TxtNombreLeave(object sender, EventArgs e)
		{
			if(txtNombre.Text == "")
			{
				txtNombre.Text = "Nombre";
				txtNombre.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtApellidoPEnter(object sender, EventArgs e)
		{
			if(txtApellidoP.Text == "Apellido Paterno")
			{
				txtApellidoP.Clear();
				txtApellidoP.ForeColor = Color.FromArgb(0,0,0);
			}
		}
		void TxtApellidoPLeave(object sender, EventArgs e)
		{
			if(txtApellidoP.Text == "")
			{
				txtApellidoP.Text = "Apellido Paterno";
				txtApellidoP.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtApellidoMEnter(object sender, EventArgs e)
		{
			if(txtApellidoM.Text == "Apellido Materno")
			{
				txtApellidoM.Clear();
				txtApellidoM.ForeColor = Color.FromArgb(0,0,0);
			}
		}
		void TxtApellidoMLeave(object sender, EventArgs e)
		{
			if(txtApellidoM.Text == "")
			{
				txtApellidoM.Text = "Apellido Materno";
				txtApellidoM.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtPasswordEnter(object sender, EventArgs e)
		{
			if(txtPassword.Text == "Password")
			{
				txtPassword.Clear();
				txtPassword.ForeColor = Color.FromArgb(0,0,0);
				txtPassword.PasswordChar = '*';
			}
		}
		void TxtPasswordLeave(object sender, EventArgs e)
		{
			if(txtPassword.Text == "")
			{
				txtPassword.PasswordChar = '\0';
				txtPassword.Text = "Password";
				txtPassword.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtConfirmPasswordEnter(object sender, EventArgs e)
		{
			if(txtConfirmPassword.Text == "Confirm Password")
			{
				txtConfirmPassword.Clear();
				txtConfirmPassword.ForeColor = Color.FromArgb(0,0,0);
				txtConfirmPassword.PasswordChar = '*';
			}
		}
		void TxtConfirmPasswordLeave(object sender, EventArgs e)
		{
			if(txtConfirmPassword.Text == "")
			{
				txtConfirmPassword.PasswordChar = '\0';
				txtConfirmPassword.Text = "Confirm Password";
				txtConfirmPassword.ForeColor = Color.FromArgb(152,152,152);
			}
		}
		void TxtsChanged(object sender, EventArgs e)
		{
			if(txtUserName.Text != ""&&txtNombre.Text != ""&&txtApellidoP.Text != ""&&txtApellidoM.Text != ""&&txtPassword.Text != ""&&txtConfirmPassword.Text != "")
			{
                if (txtUserName.Text != "Nombre de usuario" && txtNombre.Text != "Nombre" && txtApellidoP.Text != "Apellido Paterno" && txtApellidoM.Text != "Apellido Materno" && txtPassword.Text != "Password" && txtConfirmPassword.Text != "Confirm Password")
                {
                    btnGuardar.Enabled = true;
                }
                else btnGuardar.Enabled = false;
			}
			else btnGuardar.Enabled = false;
		}

        private void RegistraUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}