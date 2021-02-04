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
    partial class MenuVentas2
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnVender;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas2));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsarioActual = new System.Windows.Forms.Label();
            this.lblInterfaz = new System.Windows.Forms.Label();
            this.btnConfigUsers = new System.Windows.Forms.Button();
            this.bntLogOut = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnTerrenos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelVisual = new System.Windows.Forms.Panel();
            this.panelVisualCarga = new System.Windows.Forms.Panel();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblUserFolio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelVisualCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.YellowGreen;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 132);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(285, 50);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "  Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentasClick);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Olive;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Location = new System.Drawing.Point(0, 0);
            this.btnVender.Margin = new System.Windows.Forms.Padding(2);
            this.btnVender.Name = "btnVender";
            this.btnVender.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnVender.Size = new System.Drawing.Size(285, 48);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Nueva Venta";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVenderClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.lblUserFolio);
            this.panel1.Controls.Add(this.lblUsarioActual);
            this.panel1.Controls.Add(this.lblFolio);
            this.panel1.Controls.Add(this.lblInterfaz);
            this.panel1.Controls.Add(this.btnConfigUsers);
            this.panel1.Controls.Add(this.bntLogOut);
            this.panel1.Controls.Add(this.panelBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.panelVentas);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 670);
            this.panel1.TabIndex = 1;
            // 
            // lblUsarioActual
            // 
            this.lblUsarioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsarioActual.AutoSize = true;
            this.lblUsarioActual.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsarioActual.Location = new System.Drawing.Point(80, 416);
            this.lblUsarioActual.Name = "lblUsarioActual";
            this.lblUsarioActual.Size = new System.Drawing.Size(119, 24);
            this.lblUsarioActual.TabIndex = 7;
            this.lblUsarioActual.Text = "User Name";
            this.lblUsarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterfaz
            // 
            this.lblInterfaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterfaz.AutoSize = true;
            this.lblInterfaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterfaz.Location = new System.Drawing.Point(79, 391);
            this.lblInterfaz.Name = "lblInterfaz";
            this.lblInterfaz.Size = new System.Drawing.Size(109, 25);
            this.lblInterfaz.TabIndex = 6;
            this.lblInterfaz.Text = "Interfaz de:";
            // 
            // btnConfigUsers
            // 
            this.btnConfigUsers.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfigUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigUsers.FlatAppearance.BorderSize = 0;
            this.btnConfigUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigUsers.Image")));
            this.btnConfigUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigUsers.Location = new System.Drawing.Point(0, 325);
            this.btnConfigUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigUsers.Name = "btnConfigUsers";
            this.btnConfigUsers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfigUsers.Size = new System.Drawing.Size(285, 47);
            this.btnConfigUsers.TabIndex = 5;
            this.btnConfigUsers.Text = "  Administrar Usuarios";
            this.btnConfigUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigUsers.UseVisualStyleBackColor = false;
            this.btnConfigUsers.Click += new System.EventHandler(this.btnConfigUsers_Click);
            // 
            // bntLogOut
            // 
            this.bntLogOut.BackColor = System.Drawing.Color.YellowGreen;
            this.bntLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntLogOut.FlatAppearance.BorderSize = 0;
            this.bntLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogOut.Image = ((System.Drawing.Image)(resources.GetObject("bntLogOut.Image")));
            this.bntLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLogOut.Location = new System.Drawing.Point(0, 600);
            this.bntLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bntLogOut.Name = "bntLogOut";
            this.bntLogOut.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bntLogOut.Size = new System.Drawing.Size(285, 70);
            this.bntLogOut.TabIndex = 4;
            this.bntLogOut.Text = "LogOut";
            this.bntLogOut.UseVisualStyleBackColor = false;
            this.bntLogOut.Click += new System.EventHandler(this.btnLogOutClick);
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.Olive;
            this.panelBuscar.Controls.Add(this.btnTerrenos);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(0, 277);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(285, 48);
            this.panelBuscar.TabIndex = 4;
            // 
            // btnTerrenos
            // 
            this.btnTerrenos.BackColor = System.Drawing.Color.Olive;
            this.btnTerrenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerrenos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerrenos.FlatAppearance.BorderSize = 0;
            this.btnTerrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerrenos.Location = new System.Drawing.Point(0, 0);
            this.btnTerrenos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerrenos.Name = "btnTerrenos";
            this.btnTerrenos.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnTerrenos.Size = new System.Drawing.Size(285, 48);
            this.btnTerrenos.TabIndex = 1;
            this.btnTerrenos.Text = "Buscar Terrenos";
            this.btnTerrenos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerrenos.UseVisualStyleBackColor = false;
            this.btnTerrenos.Click += new System.EventHandler(this.btnTerrenos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 230);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(285, 47);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "  Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.Olive;
            this.panelVentas.Controls.Add(this.btnVender);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 182);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(285, 48);
            this.panelVentas.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(285, 132);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelVisual
            // 
            this.panelVisual.BackColor = System.Drawing.Color.SeaGreen;
            this.panelVisual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVisual.BackgroundImage")));
            this.panelVisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisual.Location = new System.Drawing.Point(0, 0);
            this.panelVisual.Name = "panelVisual";
            this.panelVisual.Size = new System.Drawing.Size(760, 670);
            this.panelVisual.TabIndex = 2;
            // 
            // panelVisualCarga
            // 
            this.panelVisualCarga.BackColor = System.Drawing.Color.SeaGreen;
            this.panelVisualCarga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVisualCarga.BackgroundImage")));
            this.panelVisualCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelVisualCarga.Controls.Add(this.panelVisual);
            this.panelVisualCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisualCarga.Location = new System.Drawing.Point(285, 0);
            this.panelVisualCarga.Name = "panelVisualCarga";
            this.panelVisualCarga.Size = new System.Drawing.Size(760, 670);
            this.panelVisualCarga.TabIndex = 0;
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(79, 461);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(60, 25);
            this.lblFolio.TabIndex = 6;
            this.lblFolio.Text = "Folio:";
            // 
            // lblUserFolio
            // 
            this.lblUserFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserFolio.AutoSize = true;
            this.lblUserFolio.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFolio.Location = new System.Drawing.Point(80, 486);
            this.lblUserFolio.Name = "lblUserFolio";
            this.lblUserFolio.Size = new System.Drawing.Size(122, 24);
            this.lblUserFolio.TabIndex = 7;
            this.lblUserFolio.Text = "User Folio";
            this.lblUserFolio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuVentas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1045, 670);
            this.Controls.Add(this.panelVisualCarga);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuVentas2";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuVentasLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelVisualCarga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnTerrenos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfigUsers;
        private System.Windows.Forms.Panel panelVisual;
        private System.Windows.Forms.Panel panelVisualCarga;
        private System.Windows.Forms.Button bntLogOut;
        private System.Windows.Forms.Label lblUsarioActual;
        private System.Windows.Forms.Label lblInterfaz;
        private System.Windows.Forms.Label lblUserFolio;
        private System.Windows.Forms.Label lblFolio;
    }
}