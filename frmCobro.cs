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

            // NO SOCIO
            if (!dateFechaPago.Visible &&
                txtMonto.Text != "")
            {
                // Imprimir No Socio
                btnBuscar.Visible = false;
                btnCobrar.Visible = false;
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
                pd.Print();

                btnBuscar.Visible = true;
                btnCobrar.Visible = true;
                MessageBox.Show("Actividad Cobrada");

            }
            // Socio 
            else if (dateFechaPago.Visible &&
                txtDni.Text != "" &&
                txtMonto.Text != "" &&
                (chkEfectivo.Checked || chkTarjeta.Checked)
                )
            {
                if(chkTarjeta.Checked && cboCuotas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Completar todos los campos");
                    return;
                }
                // Cambiar Fecha de vencimiento
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

                // IMPRIMIR 
                btnBuscar.Visible = false;
                btnCobrar.Visible = false;
                if (!chkTarjeta.Checked)
                {
                    lblCuotas.Visible = false;
                    cboCuotas.Visible = false;
                }
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
                pd.Print();

                btnBuscar.Visible = true;
                btnCobrar.Visible = true;
                if (!chkTarjeta.Checked)
                {
                    lblCuotas.Visible = true;
                    cboCuotas.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos");
            }


        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Declaración
            Boolean busqueda = false;
            string nombre, apellido;

            // reset
            lblTotal.Visible = false;
            txtMonto.Visible = false;
            lblMedio.Visible = false;
            chkTarjeta.Visible = false;
            chkEfectivo.Visible = false;
            btnCobrar.Visible = false;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblCuotas.Visible = false;
            cboCuotas.Visible = false;
            lblVencimiento.Visible = false;
            dateFechaPago.Visible = false;
            lblTituloCobro.Visible = false;

            //  VALIDACIONES
            if (txtDni.Text != "")
            {
                // BUSCA EN NO SOCIO
                NoSocio noSocio = new NoSocio();
                busqueda = noSocio.NombreApellidoNoSocio(txtDni.Text, out nombre, out apellido);
                if (busqueda)
                {
                    // ES NO SOCIO
                    lblTotal.Visible = true;
                    txtMonto.Visible = true;
                    //lblMedio.Visible = true;
                    //chkTarjeta.Visible = true;
                    //chkEfectivo.Visible = true;
                    btnCobrar.Visible = true;
                    txtApellido.Visible = true;
                    txtNombre.Visible = true;
                    lblApellido.Visible = true;
                    lblNombre.Visible = true;
                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    lblTituloCobro.Text = "Cobro de Actividad";
                    lblTituloCobro.Visible = true;

                }
                else
                {
                    // BSUCA EN SOCIO
                    busqueda = false;
                    Socio socio = new Socio();
                    busqueda = socio.NombreApellidoSocio(txtDni.Text, out nombre, out apellido);
                    if (busqueda)
                    {
                        // ES SOCIO
                        lblTotal.Visible = true;
                        txtMonto.Visible = true;
                        lblMedio.Visible = true;
                        chkTarjeta.Visible = true;
                        chkEfectivo.Visible = true;
                        btnCobrar.Visible = true;
                        txtApellido.Visible = true;
                        txtNombre.Visible = true;
                        lblApellido.Visible = true;
                        lblNombre.Visible = true;
                        txtNombre.Text = nombre;
                        txtApellido.Text = apellido;
                        lblCuotas.Visible = true;
                        cboCuotas.Visible = true;
                        lblVencimiento.Visible = true;
                        dateFechaPago.Visible = true;
                        lblTituloCobro.Text = "Cobro de Cuota";
                        lblTituloCobro.Visible = true;
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

        private void lblVencimiento_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir solo nums
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela la tecla
            }
        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
