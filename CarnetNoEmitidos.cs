using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logIn.Datos;
using MySql.Data.MySqlClient;
using WinFormsApp1.Entidades;

namespace WinFormsApp1
{
    public partial class frmCarnetNoEmitidos : Form
    {
        public frmCarnetNoEmitidos()
        {
            InitializeComponent();
        }

        private void frmCarnetNoEmitidos_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "SELECT nombre as Nombre, apellido as Apellido, dni as DNI FROM socio WHERE carnet = 0;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbgrdNoEmitidos.DataSource = dt;

                dbgrdNoEmitidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            Boolean busqueda = false;
            if (txtDni.Text != "")
            {
                Socio socio = new Socio();
                busqueda = socio.NombreApellidoSocio(txtDni.Text, out nombre, out apellido);
                if (busqueda)
                {
                    socio.ImprimirCarnet(nombre, apellido, txtDni.Text);
                }
                else
                {
                    MessageBox.Show("No se encuentra Socio con el DNI ingresado");

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un DNI");
            }
        }

        private void dbgrdNoEmitidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
