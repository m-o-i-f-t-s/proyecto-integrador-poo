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
                DateTime fechaSeleccionada = dateFechaPago.Value;
                string fechaModificada = fechaSeleccionada.ToString("yyyy-MM-dd");

                Socio socio = new Socio();
                socio.RegistroSocio(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDni.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    cboAptoFisico.Text.ToString() == "Si" ? 1 : 0,
                    fechaModificada,
                    cboEntregaCarnet.Text.ToString() == "Si" ? 1 : 0
                    );
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos para continuar.", "Error");

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
    }
}
