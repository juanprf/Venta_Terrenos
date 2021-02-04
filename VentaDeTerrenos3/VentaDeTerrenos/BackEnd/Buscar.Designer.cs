/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/11/2019
 * Time: 05:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VentaDeTerrenos.BackEnd
{
	partial class Buscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTodosLosT = new System.Windows.Forms.RadioButton();
            this.rbDisponibles = new System.Windows.Forms.RadioButton();
            this.rbVendidos = new System.Windows.Forms.RadioButton();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTextBox1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblTextBox2 = new System.Windows.Forms.Label();
            this.lblTextBox3 = new System.Windows.Forms.Label();
            this.lblTextBox4 = new System.Windows.Forms.Label();
            this.lblTextBox5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblTextBox5);
            this.panel1.Controls.Add(this.lblTextBox4);
            this.panel1.Controls.Add(this.lblTextBox3);
            this.panel1.Controls.Add(this.lblTextBox2);
            this.panel1.Controls.Add(this.lblTextBox1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.rbTodosLosT);
            this.panel1.Controls.Add(this.rbDisponibles);
            this.panel1.Controls.Add(this.rbVendidos);
            this.panel1.Controls.Add(this.lblBuscarPor);
            this.panel1.Controls.Add(this.cbBoxBuscarPor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 124);
            this.panel1.TabIndex = 0;
            // 
            // rbTodosLosT
            // 
            this.rbTodosLosT.AutoSize = true;
            this.rbTodosLosT.Location = new System.Drawing.Point(172, 80);
            this.rbTodosLosT.Name = "rbTodosLosT";
            this.rbTodosLosT.Size = new System.Drawing.Size(112, 17);
            this.rbTodosLosT.TabIndex = 3;
            this.rbTodosLosT.Text = "Todos los terrenos";
            this.rbTodosLosT.UseVisualStyleBackColor = true;
            this.rbTodosLosT.CheckedChanged += new System.EventHandler(this.RdTodosLosT_CheckedChanged);
            // 
            // rbDisponibles
            // 
            this.rbDisponibles.AutoSize = true;
            this.rbDisponibles.Location = new System.Drawing.Point(87, 80);
            this.rbDisponibles.Name = "rbDisponibles";
            this.rbDisponibles.Size = new System.Drawing.Size(79, 17);
            this.rbDisponibles.TabIndex = 3;
            this.rbDisponibles.Text = "Disponibles";
            this.rbDisponibles.UseVisualStyleBackColor = true;
            this.rbDisponibles.CheckedChanged += new System.EventHandler(this.RdDisponibles_CheckedChanged);
            // 
            // rbVendidos
            // 
            this.rbVendidos.AutoSize = true;
            this.rbVendidos.Location = new System.Drawing.Point(12, 80);
            this.rbVendidos.Name = "rbVendidos";
            this.rbVendidos.Size = new System.Drawing.Size(69, 17);
            this.rbVendidos.TabIndex = 3;
            this.rbVendidos.Text = "Vendidos";
            this.rbVendidos.UseVisualStyleBackColor = true;
            this.rbVendidos.CheckedChanged += new System.EventHandler(this.RdVendidos_CheckedChanged);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(12, 19);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(85, 18);
            this.lblBuscarPor.TabIndex = 2;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cbBoxBuscarPor
            // 
            this.cbBoxBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxBuscarPor.FormattingEnabled = true;
            this.cbBoxBuscarPor.Items.AddRange(new object[] {
            "ID TERRENO",
            "MANZANA&LOTE",
            "DATOS DEL CLIENTE",
            "DATOS DEL VENDEDOR",
            "NUMERO DE VENTA",
            "FECHA DE VENTA"});
            this.cbBoxBuscarPor.Location = new System.Drawing.Point(12, 40);
            this.cbBoxBuscarPor.Name = "cbBoxBuscarPor";
            this.cbBoxBuscarPor.Size = new System.Drawing.Size(185, 26);
            this.cbBoxBuscarPor.TabIndex = 1;
            this.cbBoxBuscarPor.Text = "Seleccione una opcion...";
            this.cbBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBoxBuscarPor_SelectedIndexChanged);
            // 
            // dgvTablas
            // 
            this.dgvTablas.AllowUserToDeleteRows = false;
            this.dgvTablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablas.Location = new System.Drawing.Point(0, 124);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.ReadOnly = true;
            this.dgvTablas.Size = new System.Drawing.Size(889, 437);
            this.dgvTablas.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 24);
            this.textBox1.TabIndex = 4;
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.AutoSize = true;
            this.lblTextBox1.Location = new System.Drawing.Point(200, 19);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(78, 13);
            this.lblTextBox1.TabIndex = 5;
            this.lblTextBox1.Text = "Primer TextBox";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(301, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(339, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 24);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(475, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 24);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(611, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 24);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(750, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 24);
            this.textBox5.TabIndex = 4;
            // 
            // lblTextBox2
            // 
            this.lblTextBox2.AutoSize = true;
            this.lblTextBox2.Location = new System.Drawing.Point(336, 19);
            this.lblTextBox2.Name = "lblTextBox2";
            this.lblTextBox2.Size = new System.Drawing.Size(92, 13);
            this.lblTextBox2.TabIndex = 5;
            this.lblTextBox2.Text = "Segunda TextBox";
            // 
            // lblTextBox3
            // 
            this.lblTextBox3.AutoSize = true;
            this.lblTextBox3.Location = new System.Drawing.Point(472, 19);
            this.lblTextBox3.Name = "lblTextBox3";
            this.lblTextBox3.Size = new System.Drawing.Size(80, 13);
            this.lblTextBox3.TabIndex = 5;
            this.lblTextBox3.Text = "Tercer TextBox";
            // 
            // lblTextBox4
            // 
            this.lblTextBox4.AutoSize = true;
            this.lblTextBox4.Location = new System.Drawing.Point(608, 19);
            this.lblTextBox4.Name = "lblTextBox4";
            this.lblTextBox4.Size = new System.Drawing.Size(80, 13);
            this.lblTextBox4.TabIndex = 5;
            this.lblTextBox4.Text = "Cuarta TextBox";
            // 
            // lblTextBox5
            // 
            this.lblTextBox5.AutoSize = true;
            this.lblTextBox5.Location = new System.Drawing.Point(747, 19);
            this.lblTextBox5.Name = "lblTextBox5";
            this.lblTextBox5.Size = new System.Drawing.Size(80, 13);
            this.lblTextBox5.TabIndex = 5;
            this.lblTextBox5.Text = "Quinta TextBox";
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(889, 561);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.panel1);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBoxBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.RadioButton rbDisponibles;
        private System.Windows.Forms.RadioButton rbVendidos;
        private System.Windows.Forms.RadioButton rbTodosLosT;
        private System.Windows.Forms.Label lblTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTextBox5;
        private System.Windows.Forms.Label lblTextBox4;
        private System.Windows.Forms.Label lblTextBox3;
        private System.Windows.Forms.Label lblTextBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}
