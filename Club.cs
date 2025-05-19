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
    public partial class frmClub : Form
    {
        public frmClub()
        {
            InitializeComponent();
        }

        private void Club_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            FormRegistroNoSocio formRegistroNoSocio = new FormRegistroNoSocio();
            formRegistroNoSocio.ShowDialog();
            //this.Hide();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmRegistroSocio FormRegistroSocio = new frmRegistroSocio();
            FormRegistroSocio.ShowDialog();
            //this.Hide();
        }

        private void btnListarVencimientos_Click(object sender, EventArgs e)
        {
            frmVencimiento frmVencimiento = new frmVencimiento();
            frmVencimiento.ShowDialog();
        }
    }
}
