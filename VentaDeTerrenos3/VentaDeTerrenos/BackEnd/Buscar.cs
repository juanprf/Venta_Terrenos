/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/11/2019
 * Time: 05:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of Buscar.
	/// </summary>
	public partial class Buscar : Form
	{
        DataBase baseDeDatos;
        public Buscar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        private void Buscar_Load(object sender, EventArgs e)
        {
            rbVendidos.Visible = false;
            rbDisponibles.Visible = false;
            rbTodosLosT.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            lblTextBox1.Visible = false;
            lblTextBox2.Visible = false;
            lblTextBox3.Visible = false;
            lblTextBox4.Visible = false;
            lblTextBox5.Visible = false;
            btnBuscar.Visible = false;
        }
        private void cbBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            switch(cbBoxBuscarPor.SelectedIndex)
            {
                case 0:
                    {
                        ActivDesactivRadioButtons(1, 1, 1);
                        ActivDesactivLblAndTextBoxs(1, 0, 0, 0, 0);
                        lblTextBox1.Text = "ID_TERRENO";
                    }
                    break;
                case 1:
                    {
                        ActivDesactivRadioButtons(1, 1, 1);
                        ActivDesactivLblAndTextBoxs(1, 1, 0, 0, 0);
                        lblTextBox1.Text = "LOTE";
                        lblTextBox2.Text = "MANZANA";
                    }
                    break;
                case 2:
                    {
                        ActivDesactivRadioButtons(1, 0, 0);
                        ActivDesactivLblAndTextBoxs(1, 1, 1, 1, 1);
                        lblTextBox1.Text = "NOMBRE_CLIENTE";
                        lblTextBox2.Text = "APELLIDOS_CLIENTE";
                        lblTextBox3.Text = "DIRECCION";
                        lblTextBox4.Text = "CIUDAD";
                        lblTextBox5.Text = "PAIS";
                        rbVendidos.Checked = true;
                    }break;
                case 3:
                    {
                        ActivDesactivRadioButtons(1, 0, 0);
                        ActivDesactivLblAndTextBoxs(1, 1, 1, 0, 0);
                        lblTextBox1.Text = "ID_ASESOR";
                        lblTextBox2.Text = "NOMBRE_ASESOR";
                        lblTextBox3.Text = "APELLIDOS_ASESOR";
                        rbVendidos.Checked = true;
                    }break;
                case 4:
                    {
                        ActivDesactivRadioButtons(1, 0, 0);
                        ActivDesactivLblAndTextBoxs(1, 0, 0, 0, 0);
                        lblTextBox1.Text = "NUMERO DE VENTA";
                        rbVendidos.Checked = true;
                    }break;
                case 5:
                    {
                        ActivDesactivRadioButtons(1, 0, 0);
                        ActivDesactivLblAndTextBoxs(1, 1, 1, 0, 0);
                        lblTextBox1.Text = "AÑO";
                        lblTextBox2.Text = "MES";
                        lblTextBox3.Text = "DIA";
                        rbVendidos.Checked = true;
                    }break;
            }
        }
        private void RdVendidos_CheckedChanged(object sender, EventArgs e)
        {
            baseDeDatos = new DataBase();
            baseDeDatos.Mostrar_Ventas(dgvTablas);
        }

        private void RdDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            baseDeDatos = new DataBase();
            baseDeDatos.Mostrar_TerrenosD(dgvTablas);
        }
        private void RdTodosLosT_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ActivDesactivRadioButtons(int rb1, int rb2, int rb3)
        {
            if (rbVendidos.Visible == false && rb1 == 1) rbVendidos.Visible = true;
            if (rbDisponibles.Visible == false && rb2 == 1) rbDisponibles.Visible = true;
            if (rbTodosLosT.Visible == false && rb3 == 1) rbTodosLosT.Visible = true;
            else
            if (rbVendidos.Visible == true && rb1 == 0) rbVendidos.Visible = false;
            if (rbDisponibles.Visible == true && rb2 == 0) rbDisponibles.Visible = false;
            if (rbTodosLosT.Visible == true && rb3 == 0) rbTodosLosT.Visible = false;
        }
        private void ActivDesactivLblAndTextBoxs(int campo1, int campo2, int campo3, int campo4, int campo5)
        {
            if (textBox1.Visible == false && campo1 == 1)
            {
                lblTextBox1.Visible = true;
                textBox1.Visible = true;
            }
            if (textBox2.Visible == false && campo2 == 1)
            {
                lblTextBox2.Visible = true;
                textBox2.Visible = true;
            }
            if (textBox3.Visible == false && campo3 == 1)
            {
                lblTextBox3.Visible = true;
                textBox3.Visible = true;
            }
            if (textBox4.Visible == false && campo4 == 1)
            {
                lblTextBox4.Visible = true;
                textBox4.Visible = true;
            }
            if (textBox5.Visible == false && campo5 == 1)
            {
                lblTextBox5.Visible = true;
                textBox5.Visible = true;
            }
            else
            if (textBox1.Visible == true && campo1 == 0)
            {
                lblTextBox1.Visible = false;
                textBox1.Visible = false;
            }
            if (textBox2.Visible == true && campo2 == 0)
            {
                lblTextBox2.Visible = false;
                textBox2.Visible = false;
            }
            if (textBox3.Visible == true && campo3 == 0)
            {
                lblTextBox3.Visible = false;
                textBox3.Visible = false;
            }
            if (textBox4.Visible == true && campo4 == 0)
            {
                lblTextBox4.Visible = false;
                textBox4.Visible = false;
            }
            if (textBox5.Visible == true && campo5 == 0)
            {
                lblTextBox5.Visible = false;
                textBox5.Visible = false;
            }
        }
    }
}
