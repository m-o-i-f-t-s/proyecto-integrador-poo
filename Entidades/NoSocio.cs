using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using logIn.Datos;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Entidades
{
    internal class NoSocio
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Telefono { get; set; }
        private string Dni{ get; set; }
        private string Email { get; set; }
        private bool AptoFisico { get; set; }


        public void RegistroNoSocio(
            string nombre, 
            string apellido, 
            string dni, 
            string telefono,
            string email, 
            int aptoFisico
            )
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "call RegistroNoSocio " +
                    "(@nombre, @apellido, @dni, @telefono, @email, @aptoFisico)";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@aptoFisico", aptoFisico);

                MySqlDataReader read = cmd.ExecuteReader();
                //
                while (read.Read())
                {
                    string respuesta = read[0].ToString();
                    MessageBox.Show(respuesta);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
            }

        }
    }
}
