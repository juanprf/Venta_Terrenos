/*
 * Created by SharpDevelop.
 * User: LOPMIP
 * Date: 10/28/2019
 * Time: 11:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using UsuarioCache.Cache;
using System.IO;

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of DataBase.
	/// </summary>
	public class DataBase
	{
        string validado = "",userNameAct = "",numFolioAct = "";
        string connectionString = "datasource=127.0.0.2;port=3306;username=root;password=123;database=pv_terreno;";
        string timenow = (Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
        MySqlConnection databaseConnection;
        MySqlCommand myCmd = new MySqlCommand();
        MySqlDataReader myReader;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataTable dta;
        MySqlDataReader dtr;
        MySqlDataAdapter dtad;
        MySqlConnection cncc;

        public DataBase()
		{
            Conexion();
        }

        public void Conexion()
        {
            try
            {
                cncc = new MySqlConnection("datasource=127.0.0.2;port=3306;username=root;password=123;database=pv_terreno; Allow Zero Datetime=true;");
                cncc.Open();
                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                myCmd.Connection = databaseConnection;
            }
            catch (Exception ex)
            {
                //Mostrar cualquier error
                Console.WriteLine(ex);
            }
        }
		public string validarExistUsuario(string usuarioDado,string passwordDado)
		{
            string comandoComprobar = "select Usuarios.nombre_u, Usuarios.Folio_Asesor, Usuarios.existe,Usuarios.ad_permisos from usuarios where nombre_u ='" + usuarioDado + "' and binary contraseña = '" + passwordDado + "';";
            try
            {
                myCmd.CommandText = comandoComprobar;
                myReader = myCmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        myReader.Read();
                        userNameAct = (myReader["nombre_u"].ToString());
                        numFolioAct = (myReader["Folio_Asesor"].ToString());
                        validado = Convert.ToString(myReader["existe"] + Convert.ToString(myReader["ad_permisos"]));
                    }
                }
                UsuarioLoginCache.userNameAct = userNameAct.ToUpper();
                UsuarioLoginCache.folioAsesor = numFolioAct.ToUpper();
            }
            catch (Exception ex)
            {
                //Mostrar cualquier error
                MessageBox.Show(ex.ToString());
            }
            databaseConnection.Close();
            return validado;
        }
        public bool GuardarUsuario(string nombreU, string password, string nombre, string apellidoP, string apellidoM)
        {
            string comandoComprobar = "select Usuarios.existe from usuarios where nombre_u ='" + nombreU + "';";
            string comandoAdd = "INSERT INTO Usuarios VALUES (FOLIO_ASESOR,'" + nombreU + "','" + password + "','" + nombre + "','" + apellidoP + " " + apellidoM + "','" + timenow + "','" + 0 + "',existe);";
            try
            {
                myCmd.CommandText = comandoComprobar;
                myReader = myCmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        myReader.Read();
                        validado = Convert.ToString(myReader["existe"]);
                    }
                }
                databaseConnection.Close();
                if (validado == "1")
                {
                    MessageBox.Show("El usuario que ingreo ya existe\nPruebe con otro nombre de usuario", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    validado = "0";
                    return false;
                }
                else
                {
                    validado = "";
                    Conexion();
                    myCmd.CommandText = comandoAdd;
                    myCmd.ExecuteReader();
                    MessageBox.Show("Bienvenido " + nombre + " ha sido registrado", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    databaseConnection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                //Mostrar cualquier error
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        



        public void GuardarVenta()
        {

        }
        public void Mostrar_Ventas(DataGridView dgv)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM venta",databaseConnection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Mostrar_TerrenosD(DataGridView dgv)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM Terrenos", databaseConnection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CargarPersona(DataGridView dgv)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter("Select * from usuarios;", cncc);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());

            }
        }

        public static int CrearCuentas(string pusuario,string pcontraseña)
        {
            int resultado = 0;
            MySqlConnection conn;


            return resultado;
        }

        public bool EditarContraseña(string usuario,string contraseña)
        {
            string registrarU = "Update usuarios set contraseña ='" + contraseña + "' where nombre_u = '" + usuario + "';";
            try
            {
                myCmd.CommandText = registrarU;
                myCmd.ExecuteReader();
            }
            catch(Exception)
            {

            }
            return true;
        }

        public bool EliminarUsuario(string usuario)
        {
            string eliminar = "delete from usuarios where nombre_u = '" + usuario + "';";
            try
            {
                myCmd.CommandText = eliminar;
                myCmd.ExecuteReader();
            }
            catch (Exception)
            {

            }
            return true;
        }

        public bool Buscar(string usuario,DataGridView dgv)
        {
            string buscar = "Select * from usuarios where nombre_u = '" + usuario + "';";
            try
            {
                if(usuario == "*" || usuario == "") buscar = "Select * from usuarios";
                if (usuario == "nombres") buscar = "Select Nombre from usuarios";
                if(usuario == "apellidos") buscar = "Select Apellidos from usuarios";
                dataAdapter = new MySqlDataAdapter(buscar, cncc);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;

            }
            catch (Exception)
            {

            }
            return true;
        }

        public bool Editarusuario(string usuario,string nombreU) 
        {
            string registrarUsuario = "Update usuarios set nombre_u ='" + nombreU + "' where nombre_u = '" + usuario + "';";
            try
            {
                myCmd.CommandText = registrarUsuario;
                myCmd.ExecuteReader();
            }
            catch (Exception)
            {

            }
            return true;
        }
    }
}