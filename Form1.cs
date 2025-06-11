using WinFormsApp1.Datos;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUser.Text == "")
            //{
            //    MessageBox.Show("Debe Igresar un nombre de usuario");
            //    return;
            //}
            //Login login = new Login();
            //login.login("admin", "1234");

            frmClub frmClub = new frmClub();
            frmClub.Show();


            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
