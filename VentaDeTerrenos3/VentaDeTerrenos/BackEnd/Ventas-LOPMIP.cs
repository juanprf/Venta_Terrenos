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
    public partial class Ventas : Form
    {
        int globalFromHeight;
        string timenow = (Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy"));
        public Ventas()
        {
            InitializeComponent();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            btnGuardar.Width = flpGEE.Width / 3-7;
            btnEditar.Width = flpGEE.Width / 3-7;
            btnEliminar.Width = flpGEE.Width / 3-7;
            btnGuardar.Height = flpGEE.Height;
            btnEditar.Height = flpGEE.Height;
            btnEliminar.Height = flpGEE.Height;
            globalFromHeight = this.Height;

            btnGuardar.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            btnEditar.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);

            lblSupTerreno.Font = new Font("Microsoft Sans Serif", 11*globalFromHeight/571, FontStyle.Regular);
            lblPlazoPago.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblEnganche.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblMens.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblPrecioT.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblLotManz.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            txtSupTerreno.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtPlazoPago.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtEnganche.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtMens.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtPrecioT.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtLotManz.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);

            label1.Text = timenow;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
