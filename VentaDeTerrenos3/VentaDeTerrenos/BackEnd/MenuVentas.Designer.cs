/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/21/2019
 * Time: 4:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VentaDeTerrenos.BackEnd
{
    partial class MenuVentas
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayPanBotones;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVendido;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bnConfigUsers;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.btnLogOut = new System.Windows.Forms.Button();
            this.flowLayPanBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVendido = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bnConfigUsers = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayPanBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(2360, 1270);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(183, 44);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOutClick);
            // 
            // flowLayPanBotones
            // 
            this.flowLayPanBotones.Controls.Add(this.btnVender);
            this.flowLayPanBotones.Controls.Add(this.btnVendido);
            this.flowLayPanBotones.Controls.Add(this.button2);
            this.flowLayPanBotones.Controls.Add(this.bnConfigUsers);
            this.flowLayPanBotones.Controls.Add(this.button4);
            this.flowLayPanBotones.Location = new System.Drawing.Point(0, 0);
            this.flowLayPanBotones.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayPanBotones.Name = "flowLayPanBotones";
            this.flowLayPanBotones.Size = new System.Drawing.Size(360, 253);
            this.flowLayPanBotones.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(2, 2);
            this.btnVender.Margin = new System.Windows.Forms.Padding(2);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(56, 205);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Realizar Ventas";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.Button1Click);
            // 
            // btnVendido
            // 
            this.btnVendido.Location = new System.Drawing.Point(62, 2);
            this.btnVendido.Margin = new System.Windows.Forms.Padding(2);
            this.btnVendido.Name = "btnVendido";
            this.btnVendido.Size = new System.Drawing.Size(56, 205);
            this.btnVendido.TabIndex = 1;
            this.btnVendido.Text = "Terrenos vendidos";
            this.btnVendido.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 205);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bnConfigUsers
            // 
            this.bnConfigUsers.Location = new System.Drawing.Point(183, 3);
            this.bnConfigUsers.Name = "bnConfigUsers";
            this.bnConfigUsers.Size = new System.Drawing.Size(54, 204);
            this.bnConfigUsers.TabIndex = 3;
            this.bnConfigUsers.Text = "Configurar usuarios";
            this.bnConfigUsers.UseVisualStyleBackColor = true;
            this.bnConfigUsers.Click += new System.EventHandler(this.bnConfigUsers_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(242, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 205);
            this.button4.TabIndex = 4;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.flowLayPanBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuVentas";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuVentasLoad);
            this.flowLayPanBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}