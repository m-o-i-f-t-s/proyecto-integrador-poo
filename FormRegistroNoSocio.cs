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
                
                NoSocio noSocio = new NoSocio();
                //noSocio.RegistroNoSocio("Vale", "apellido","456","456","val",1);
                //noSocio.RegistroNoSocio("Diego","Apellido","345","345","di",0);

                noSocio.RegistroNoSocio(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDni.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    cboAptoFisico.Text.ToString() == "Si" ? 1 : 0
                    );
            }

        }
    }
}
