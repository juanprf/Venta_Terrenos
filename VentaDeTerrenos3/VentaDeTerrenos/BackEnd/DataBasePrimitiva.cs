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

namespace VentaDeTerrenos.BackEnd
{
	/// <summary>
	/// Description of DataBase.
	/// </summary>
	public class DataBasePrimitiva
	{
		string validado = "";
        string connectionString = "datasource=127.0.0.2;port=3306;username=root;password=;database=pv_terreno;";
        string timenow = (Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
       

        public DataBasePrimitiva()
		{
		}
        string ConectarDB(string comando)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
                databaseConnection.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd.Connection = databaseConnection;
                myCmd.CommandText = comando;
                MySqlDataReader myReader = myCmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        myReader.Read();
                        validado = Convert.ToString(myReader["existe"] + Convert.ToString(myReader["ad_permisos"]));
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                //Mostrar cualquier error
                Console.WriteLine(ex);
            }
            return validado;
        }

		public string validarExistUsuario(string usuarioDado,string passwordDado)
		{
            string comandoComprobar = "select Usuarios.existe,Usuarios.nombre_u,Usuarios.ad_permisos from usuarios where nombre_u ='" + usuarioDado + "' and binary contraseña = '" + passwordDado + "';";
            return ConectarDB(comandoComprobar);
		}

        public bool GuardarUsuario(string nombreU, string password, string nombre, string apellidoP, string apellidoM)
        {
            string comandoComprobar = "select Usuarios.existe,Usuarios.nombre_u,Usuarios.ad_permisos from usuarios where nombre_u ='" + nombreU + "';";
            string comandoAdd = "INSERT INTO Usuarios VALUES (ID_usuario,'" + nombreU + "','" + password + "','" + nombre + "','" + apellidoP + " " + apellidoM + "','" + timenow + "','" + 0 + "',existe);";
            validado = ConectarDB(comandoComprobar);
            MessageBox.Show(validado);
            if (validado == "11" || validado == "10")
            {
                MessageBox.Show("El usuario que ingreo ya existe\nPruebe con otro nombre de usuario", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                validado = "0";
                return false;
            }
            else if (validado != "11" && validado != "10")
            {
                validado = "";
                ConectarDB(comandoAdd);
                MessageBox.Show("Bienvenido " + nombre + " A sido registrado", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else return true;
        }

        public bool PrimerIngreso(string password)
        {

            return true;
        }

        
       
    }
}