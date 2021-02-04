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
        DataBase baseDeDatos;
        int globalFromHeight;
        string timenow = (Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy"));
        public Ventas()
        {
            InitializeComponent();
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

        private void Ventas_Load(object sender, EventArgs e)
        {
            btnGuardar.Width = flpGEE.Width;
            //btnEditar.Width = flpGEE.Width / 3-7;
            //btnEliminar.Width = flpGEE.Width / 3-7;
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
            lblLot.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblManz.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            txtSupTerreno.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtPlazoPago.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtEnganche.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtMens.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtPrecioT.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtLot.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtManz.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);

            lblInfoCliente.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblFecha.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblFechaTime.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblNombre.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblApellido.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblDireccion.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblCiudad.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            lblPais.Font = new Font("Microsoft Sans Serif", 11 * globalFromHeight / 571, FontStyle.Regular);
            txtNombreClient.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtApellidosClient.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtDireccionClient.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtCiudadClient.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);
            txtPaisClient.Font = new Font("Microsoft Sans Serif", 15 * globalFromHeight / 571, FontStyle.Regular);

            lblFechaTime.Text = timenow;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            baseDeDatos = new DataBase();
            baseDeDatos.GuardarVenta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
