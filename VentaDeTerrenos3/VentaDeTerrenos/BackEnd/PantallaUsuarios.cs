using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace VentaDeTerrenos.BackEnd
{
    public partial class PantallaUsuarios : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        List<VoiceInfo> vocesInfo = new List<VoiceInfo>();
        DataBase basedatos;
        

        public PantallaUsuarios()
        {
            
            InitializeComponent();
          /*  foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                vocesInfo.Add(voice.VoiceInfo);
                btnGuardar.Items.Add(voice.VoiceInfo.Name);
            }
            btnGuardar.SelectedIndex = 0;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PantallaUsuarios_Load(object sender, EventArgs e)
        {
            basedatos = new DataBase();
            basedatos.CargarPersona(dgvTablas);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            
            /*  int indice;

              double Volumen = trackBar1.Value = 90;
              double Rate = rate.Value;

              indice = cbVoces.SelectedIndex;
              String nombre = vocesInfo.ElementAt(indice).Name;
              synthesizer.SelectVoice(nombre);

              synthesizer.Volume = (int)Volumen;
              synthesizer.Rate = (int)Rate;
              synthesizer.Speak("Jajajajaja que buenos momos");*/

            

            if (textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox4.Text==textBox5.Text)
            {
                basedatos = new DataBase();
                if (basedatos.EditarContraseña(textBox6.Text, textBox5.Text) == true)
                {
                    MessageBox.Show("Cambio hecho.");
                    basedatos.CargarPersona(dgvTablas);
                   
                }
                else MessageBox.Show("Error en cambio.");
            }
            else MessageBox.Show("Las contraseñas no coiciden.");


        }

        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            basedatos = new DataBase();
            if (basedatos.Buscar(textBox2.Text,dgvTablas) == true)
            {
                  

            }
            else MessageBox.Show("Ingrese el nombre de un usuario.");

        }

        private void dgvTablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0)
            {
                basedatos = new DataBase();
                if (basedatos.EliminarUsuario(textBox1.Text) == true)
                {
                    MessageBox.Show("Usuario eliminado.");
                    basedatos.CargarPersona(dgvTablas);

                }
                else MessageBox.Show("Error en cambio.");
            }
            else MessageBox.Show("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox3.Text.Length != 0 )
            {
                basedatos = new DataBase();
                if (basedatos.Editarusuario(textBox1.Text,textBox3.Text) == true)
                {
                    MessageBox.Show("Cambio hecho.");
                    basedatos.CargarPersona(dgvTablas);

                }
                else MessageBox.Show("Error en cambio.");
            }
            else MessageBox.Show("Los nombres no coiciden.");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
