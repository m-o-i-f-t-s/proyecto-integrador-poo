using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logIn.Datos;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Datos
{
    internal class Login
    {

        public void login(string user, string pass)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "SELECT usuario FROM usuario where usuario = @usuario and pass = @pass";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                MySqlDataReader read = cmd.ExecuteReader();
                //
                while (read.Read())
                {
                    string usuario = read["usuario"].ToString();
                    MessageBox.Show(usuario);
                    //Debug.WriteLine(usuario);
                    if (usuario == user)
                    {
                        MessageBox.Show("entraste Fiera");

                    }

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
            }
        }
    }
}
