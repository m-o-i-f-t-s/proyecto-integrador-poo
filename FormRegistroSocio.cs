using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entidades;

namespace WinFormsApp1
{
    public partial class frmRegistroSocio : Form
    {
        public frmRegistroSocio()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool respuesta;
            // Validaciones
            

            // CAMPOS Vacios
            if (Utilidades.Validacion(txtNombre.Text) &&
                Utilidades.Validacion(txtApellido.Text) &&
                Utilidades.Validacion(txtDni.Text) &&
                Utilidades.Validacion(txtTelefono.Text) &&
                Utilidades.Validacion(txtEmail.Text) &&
                (cboAptoFisico.SelectedIndex != -1) &&
                (cboEntregaCarnet.SelectedIndex != -1)
                //comboBox -1 = en blanco
                )
            {
                // APTO Físico
                if (cboAptoFisico.Text.ToString() != "Si")
                {
                    MessageBox.Show("Debe tener apto físico para poder registrarse");
                    return;
                }
                else
                {
                    // Toma la fecha
                    DateTime fechaSeleccionada = dateFechaPago.Value;
                    // Modifica Formato para DB
                    string fechaModificada = fechaSeleccionada.ToString("yyyy-MM-dd");
                    // Crea nuevo socio
                    Socio socio = new Socio();

                    // BUSCA EN NO SOCIO
                    respuesta = socio.BuscarNoSocio(txtDni.Text);
                    if (respuesta)
                    {
                        // MessageBoxButtons.YesNoCancel.
                    }
                

                    socio.RegistroSocio(
                        txtNombre.Text,
                        txtApellido.Text,
                        txtDni.Text,
                        txtTelefono.Text,
                        txtEmail.Text,
                        cboAptoFisico.Text.ToString() == "Si" ? 1 : 0,// si = 1
                        fechaModificada,
                        cboEntregaCarnet.Text.ToString() == "Si" ? 1 : 0 // no = 0
                        );
                }
                
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos para continuar.");

            }

        }

        private void frmRegistroSocio_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
