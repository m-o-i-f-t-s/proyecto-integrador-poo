using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using logIn.Datos;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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


        //public NoSocio (string nombre, string apellido, 
        //    string telefono, string dni, string email, bool aptoFisico)
        //{
        //    this.Nombre = nombre;
        //    this.Apellido = apellido;
        //    this.Telefono = telefono;
        //    this.Dni = dni;
        //    this.Email = email;
        //    this.AptoFisico = aptoFisico;
        //}

        
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

        public Boolean EliminarNoSocio(string dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "call eliminarNoSocio(@dni)";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string respuesta = read[0].ToString();
                    if (respuesta == "1")
                    {
                        return true;
                    }
                    if (respuesta == "0")
                    {
                        MessageBox.Show(respuesta);
                        return false;
                    }
                }
                return false;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
                return false;
            }


        }


        public Boolean BuscarNoSocio(string dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "call BuscarNoSocio (@dni)";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string respuesta = read[0].ToString();
                    if (respuesta == "1")
                    {
                        return true;
                    }
                    if (respuesta == "0")
                    {
                        return false;
                    }
                }
                return false;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
                return false;
            }


        }



    }
}
