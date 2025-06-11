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

namespace WinFormsApp1
{
    public partial class frmVencimiento : Form
    {
        public frmVencimiento()
        {
            InitializeComponent();
        }

        private void frmVencimiento_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "SELECT nombre as Nombre, apellido as Apellido, dni as DNI, fechaDeVencimiento as 'Fecha de Vencimiento'" +
                    "FROM socio WHERE fechaDeVencimiento = CURDATE();";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, sqlCon);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbgrdVencimiento.DataSource = dt;

                dbgrdVencimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
            }

        }

        private void dbgrdVencimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
