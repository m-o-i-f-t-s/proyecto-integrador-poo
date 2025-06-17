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
            Boolean busqueda = false;
            
            // Validaciones en blanco
            if (Utilidades.Validacion(txtNombre.Text) &&
                Utilidades.Validacion(txtApellido.Text) &&
                Utilidades.Validacion(txtDni.Text) &&
                Utilidades.Validacion(txtTelefono.Text) &&
                Utilidades.Validacion(txtEmail.Text) &&
                (cboAptoFisico.SelectedIndex != -1) //comboBox apto fisico -1 = en blanco
                )
            {
                // Validación apto físoco
                if(cboAptoFisico.Text.ToString() != "Si")
                {
                    MessageBox.Show("Debe tener apto físico para poder registrarse");
                    return;
                }


                //BUSCA EN Socio
                Socio socio = new Socio();
                busqueda = socio.BuscarSocio(txtDni.Text);
                if (busqueda)
                {
                    var pregunta = MessageBox.Show("Socio registrado. ¿Desea registrarlo como No Socio?", "Advertencia", MessageBoxButtons.YesNoCancel);
                    //ELIMINA no socio
                    if (pregunta == DialogResult.Yes)
                    {
                        busqueda = false;
                        busqueda = socio.EliminarSocio(txtDni.Text);
                        if (!busqueda)
                        {
                            MessageBox.Show("Error al eliminar al Socio", "Error");
                            return;
                        }

                    }
                    if (pregunta == DialogResult.No || pregunta == DialogResult.Cancel)
                    {
                        return;
                    }
                    
                }

                // Registro de No Socio
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
