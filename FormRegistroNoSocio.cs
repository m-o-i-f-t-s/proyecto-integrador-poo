using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistroNoSocio : Form
    {
        public FormRegistroNoSocio()
        {
            InitializeComponent();
        }


       
        public bool Validacion(string texto)
            // FUNCIO N PARA validar campos en blanco
        {
            if (texto == "")
            {
                return false;
            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validacion(txtNombre.Text) &&
                Validacion(txtApellido.Text) &&
                Validacion(txtDni.Text) &&
                Validacion(txtTelefono.Text)&&
                Validacion(txtEmail.Text) &&
                (cboAptoFisico.SelectedIndex != -1) //comboBox apto fisico -1 = en blanco
                )
            {
                // FLATA BUSCAR EN LA BASE SI NO EXISTE
                MessageBox.Show("TODO LISO");
                // FALTA SUBIR A LA BASE DE DATOS
            }

        }
    }
}
