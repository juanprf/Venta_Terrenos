/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/9/2019
 * Time: 8:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Login : Form
	{
		DataBase baseDeDatos = new DataBase();
		int intentos = 0;
		int timeLeft = 10;
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TxtUserEnter(object sender, EventArgs e)
		{
			if(txtUser.Text == "User Name")
			{
				txtUser.Clear();
				txtUser.ForeColor = Color.FromArgb(0,0,0);
			}
		}
		void TxtUserLeave(object sender, EventArgs e)
		{
			if(txtUser.Text == "")
			{
				txtUser.Text = "User Name";
				txtUser.ForeColor = Color.FromArgb(152,152,152);
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
				btnOjoPassword.ImageIndex = 0;
				txtPassword.Size = new System.Drawing.Size(194,38);
				txtPassword.ForeColor = Color.FromArgb(152,152,152);
				btnOjoPassword.Visible = false;
			}
		}
		void TxtPasswordTextChanged(object sender, EventArgs e)
		{
			if(txtPassword.Text != "")
			{
				txtPassword.Size = new System.Drawing.Size(165,38);
				btnOjoPassword.Visible = true;
			}
			else if(txtPassword.Text == "" || txtPassword.Text == "Password")
			{
				txtPassword.Size = new System.Drawing.Size(194,38);
				btnOjoPassword.Visible = false;
				btnOjoPassword.ImageIndex = 0;
				txtPassword.PasswordChar = '*';
			}
		}
		void BtnIngresoClick(object sender, EventArgs e)
		{
			Ingrear();
		}
		void BtnRegistroClick(object sender, EventArgs e)
		{
			RegistraUsuario rgUser = new RegistraUsuario();
			this.Hide();
			txtUser.Text = "User Name";
			txtUser.ForeColor = Color.FromArgb(152,152,152);
			txtPassword.Text = "Password";
			btnOjoPassword.ImageIndex = 0;
			txtPassword.PasswordChar = '\0';
			txtPassword.ForeColor = Color.FromArgb(152,152,152);
			rgUser.ShowDialog();
			this.Show();
		}
		void BtnOjoPasswordClick(object sender, EventArgs e)
		{
			if(txtPassword.Text != "Password")
			{
				if(btnOjoPassword.ImageIndex == 0)
				{
					btnOjoPassword.ImageIndex = 1;
					txtPassword.PasswordChar = '\0';
				}
				else if(btnOjoPassword.ImageIndex == 1)
				{
					btnOjoPassword.ImageIndex = 0;
					if(txtPassword.Text != "Password")txtPassword.PasswordChar = '*';
				}
			}
		}
        void Ingrear()
        {
            switch (baseDeDatos.validarExistUsuario(txtUser.Text, txtPassword.Text))
            {
                case "11":
                    {
                        txtUser.Text = "User Name";
                        txtUser.ForeColor = Color.FromArgb(152, 152, 152);
                        txtPassword.Text = "Password";
                        txtPassword.PasswordChar = '\0';
                        intentos = 0;
                        txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
                        baseDeDatos = new DataBase();
                        MenuVentas mv = new MenuVentas();
                        this.Hide();
                        mv.ShowDialog();
                        btnOjoPassword.ImageIndex = 0;
                        this.Show();
                        
                    }break;
                case "10":
                {
                txtUser.Text = "User Name";
                txtUser.ForeColor = Color.FromArgb(152, 152, 152);
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                intentos = 0;
                txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
                baseDeDatos = new DataBase();
                MenuVentas mv = new MenuVentas();
                this.Hide();
                mv.ShowDialog();
                btnOjoPassword.ImageIndex = 0;
                this.Show();
                }break;
                case "91":
                {
                txtUser.Text = "User Name";
                txtUser.ForeColor = Color.FromArgb(152, 152, 152);
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                intentos = 0;
                txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
                baseDeDatos = new DataBase();
                Primer_inicio pi = new Primer_inicio();
                this.Hide();
                pi.ShowDialog();
                btnOjoPassword.ImageIndex = 0;
                this.Show();
                }break;
                default:
                    {
                        MessageBox.Show("No se pudo ingresar\nEl nombre de usuario y/o la contraseña son incorrectos", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos += 1;
                        txtPassword.Clear();
                        txtPassword.Text = "Password";
                        btnOjoPassword.ImageIndex = 0;
                        txtPassword.Size = new System.Drawing.Size(194, 38);
                        btnOjoPassword.Visible = false;
                        txtPassword.ForeColor = Color.FromArgb(152, 152, 152);
                        txtPassword.PasswordChar = '\0';
                    }break;
                
            }
            if (intentos == 5)
			{
				btnIngreso.Enabled = false;
				timerRegresiva.Enabled = true;
				lblRegresiva.Visible = true;
				timerIntentos.Enabled = true;
				MessageBox.Show("Demasiados intentos\nEspera un poco antes de volver a intentar","Exeso de intentos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				intentos = 0;
			}
			txtPassword.ForeColor = Color.FromArgb(152,152,152);
		}
		void TxtPasswordKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				this.GetNextControl(ActiveControl, true).Focus();
				Ingrear();
			}
		}
		void IntentosTick(object sender, EventArgs e)
		{
			btnIngreso.Enabled = true;
			timerIntentos.Stop();
		}
		void RegresivaTick(object sender, EventArgs e)
		{
			lblRegresiva.Text = "Puedes volver a intentarlo en: "+timeLeft.ToString();
			timeLeft -= 1;
			if(timeLeft < 0)
			{
				timerRegresiva.Stop();
				lblRegresiva.Text = "";
				lblRegresiva.Visible = false;
				timeLeft = 10;
			}
		}
	}
}