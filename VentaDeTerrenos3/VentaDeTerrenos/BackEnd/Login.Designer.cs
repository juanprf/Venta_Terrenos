/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/9/2019
 * Time: 8:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VentaDeTerrenos.BackEnd
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.Button btnRegistro;
		private System.Windows.Forms.Button btnOjoPassword;
		private System.Windows.Forms.ImageList imagenesOjo;
		private System.Windows.Forms.Label lblRegresiva;
		private System.Windows.Forms.Timer timerRegresiva;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnOjoPassword = new System.Windows.Forms.Button();
            this.imagenesOjo = new System.Windows.Forms.ImageList(this.components);
            this.lblRegresiva = new System.Windows.Forms.Label();
            this.timerRegresiva = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(223, 44);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(194, 72);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txtUser.Location = new System.Drawing.Point(223, 136);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 32);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "User Name";
            this.txtUser.Enter += new System.EventHandler(this.TxtUserEnter);
            this.txtUser.Leave += new System.EventHandler(this.TxtUserLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txtPassword.Location = new System.Drawing.Point(223, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPasswordTextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.TxtPasswordEnter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPasswordKeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPasswordLeave);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngreso.BackColor = System.Drawing.Color.Transparent;
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(223, 246);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(92, 27);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.BtnIngresoClick);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(319, 246);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(98, 27);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistroClick);
            // 
            // btnOjoPassword
            // 
            this.btnOjoPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOjoPassword.BackColor = System.Drawing.Color.White;
            this.btnOjoPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOjoPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjoPassword.ImageIndex = 0;
            this.btnOjoPassword.ImageList = this.imagenesOjo;
            this.btnOjoPassword.Location = new System.Drawing.Point(386, 172);
            this.btnOjoPassword.Name = "btnOjoPassword";
            this.btnOjoPassword.Size = new System.Drawing.Size(32, 32);
            this.btnOjoPassword.TabIndex = 5;
            this.btnOjoPassword.UseVisualStyleBackColor = false;
            this.btnOjoPassword.Visible = false;
            this.btnOjoPassword.Click += new System.EventHandler(this.BtnOjoPasswordClick);
            // 
            // imagenesOjo
            // 
            this.imagenesOjo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesOjo.ImageStream")));
            this.imagenesOjo.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenesOjo.Images.SetKeyName(0, "OjoTachado.png");
            this.imagenesOjo.Images.SetKeyName(1, "Ojo.png");
            // 
            // lblRegresiva
            // 
            this.lblRegresiva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegresiva.BackColor = System.Drawing.Color.Transparent;
            this.lblRegresiva.Location = new System.Drawing.Point(223, 210);
            this.lblRegresiva.Name = "lblRegresiva";
            this.lblRegresiva.Size = new System.Drawing.Size(194, 16);
            this.lblRegresiva.TabIndex = 6;
            this.lblRegresiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegresiva.Visible = false;
            // 
            // timerRegresiva
            // 
            this.timerRegresiva.Interval = 1000;
            this.timerRegresiva.Tick += new System.EventHandler(this.RegresivaTick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(584, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 24);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 370);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegresiva);
            this.Controls.Add(this.btnOjoPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnIngreso);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 370);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnSalir;
    }
}
