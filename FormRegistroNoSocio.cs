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
    public partial class FormRegistroNoSocio : Form
    {
        public FormRegistroNoSocio()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (Utilidades.Validacion(txtNombre.Text) &&
                Utilidades.Validacion(txtApellido.Text) &&
                Utilidades.Validacion(txtDni.Text) &&
                Utilidades.Validacion(txtTelefono.Text) &&
                Utilidades.Validacion(txtEmail.Text) &&
                (cboAptoFisico.SelectedIndex != -1) //comboBox apto fisico -1 = en blanco
                )
            {


                NoSocio noSocio = new NoSocio();
                noSocio.RegistroNoSocio(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDni.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    cboAptoFisico.Text.ToString() == "Si" ? 1 : 0
                    );
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos para continuar.","Error");
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
