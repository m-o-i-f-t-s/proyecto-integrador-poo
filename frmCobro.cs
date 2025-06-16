using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logIn.Datos;
using MySql.Data.MySqlClient;
using WinFormsApp1.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //  VALIDACIONES
            if (txtDni.Text != "")
            {
                DateTime fechaSeleccionada = dateFechaPago.Value;
                string fechaModificada = fechaSeleccionada.ToString("yyyy-MM-dd");

                MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    sqlCon.Open();
                    String query = "call CambioVencimiento " +
                        "(@dni, @fechaDeVencimiento)";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);

                    cmd.Parameters.AddWithValue("@dni", txtDni.Text);
                    cmd.Parameters.AddWithValue("@fechaDeVencimiento", fechaModificada);

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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean busqueda = false;
            //  VALIDACIONES
            if (txtDni.Text != "")
            {
                // BUSCA EN NO SOCIO
                NoSocio noSocio = new NoSocio();
                busqueda = noSocio.BuscarNoSocio(txtDni.Text);
                if (busqueda)
                {
                    // ES NO SOCIO
                }
                else
                {
                    // BSUCA EN SOCIO
                    Socio socio = new Socio();
                    busqueda = socio.BuscarSocio(txtDni.Text);
                    if(busqueda)
                    {
                        // ES SOCIO
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran Clientes con el DNI ingresado");
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un DNI");
            }
        }
    }
}
