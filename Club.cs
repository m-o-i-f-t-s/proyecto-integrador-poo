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
            formRegistroNoSocio.Show();
            this.Hide();
        }
    }
}
