﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logIn.Datos;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Entidades
{
    internal class Socio :NoSocio
    {
        private DateOnly VencimientoCuota;
        private bool Carnet;

        public void RegistroSocio(
            string nombre,
            string apellido,
            string dni,
            string telefono,
            string email,
            int aptoFisico,
            string fechaDeVencimiento,
            int carnet
            )
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "call RegistroSocio " +
                    "(@nombre, @apellido, @dni, @telefono, @email, @aptoFisico, @fechaDeVencimiento,@carnet)";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@aptoFisico", aptoFisico);
                cmd.Parameters.AddWithValue("@fechaDeVencimiento", fechaDeVencimiento);
                cmd.Parameters.AddWithValue("@carnet", carnet);

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
