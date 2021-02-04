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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularLoading.Value += 1;
            circularLoading.Text = circularLoading.Value.ToString();
            if (circularLoading.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
            circularLoading.Value = 0;
            circularLoading.Minimum = 0;
            circularLoading.Maximum = 100;
        }
    }
}
