using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logIn.Datos;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class frmImpresionCarnet : Form
    {
        public frmImpresionCarnet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmImpresionCarnet_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                String query = "update socio set carnet = 1 where dni = (@dni)";
                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@dni", lblDni.Text);

                MySqlDataReader read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    string respuesta = read[0].ToString();
                    
                //}
               

            }
            catch (MySqlException ex)
            {

                MessageBox.Show($"Error al conectar o ejecutar la consulta: {ex.Message}");
                
            }


            btnImprimir.Visible = true;
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
