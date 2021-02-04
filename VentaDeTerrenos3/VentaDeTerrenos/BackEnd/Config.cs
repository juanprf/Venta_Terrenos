using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VentaDeTerrenos.BackEnd
{
    public partial class Config : Form
    {

        
        public Config()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirPanelU(new RegistraUsuario());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AbrirPanelU(new PantallaUsuarios());
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void AbrirPanelU (object panelhijou)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form ph = panelhijou as Form;
            ph.TopLevel = false;
            ph.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ph);
            this.panel2.Tag = ph;
            ph.Show();

        }

    }
}