using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace logIn.Datos
{
    public class Conexion
    // la clase debe ser PUBLICA
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        // asignamos valores a las variables de la conexion
        {

            // variables usadas para larepetición de líneas de código
            bool correcto = false;
            int mensaje;
            // creamos las variables para recibir los datos desde el teclado
            // ======
            string T_servidor = "localhost";
            string T_puerto = "3306";
            string T_usuario = "root";
            string T_clave = "";

            //this.baseDatos = "c_rueba_1";
            //this.servidor = "localhost";
            //this.puerto = "3306";
            //this.usuario = "root";
            //this.clave = "admin";

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("ingrese servidor --> localhost (por defecto)", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("ingrese puerto --> 3306 (por defecto)", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("ingrese usuario --> root (por defecto)", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                if (string.IsNullOrWhiteSpace(T_servidor)) T_servidor = "localhost";
                if (string.IsNullOrWhiteSpace(T_puerto)) T_puerto = "3306";
                if (string.IsNullOrWhiteSpace(T_usuario)) T_usuario = "root";
                // controlamos que los datos ingresados para acceder a MySQL sean correctos
                //mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " + T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                //T_usuario + " CLAVE: " + T_clave, "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                mensaje = (int)MessageBox.Show(
                        "Su ingreso:\n" +
                        "SERVIDOR = " + (T_servidor) + "\n" +
                        "PUERTO = " + (T_puerto) + "\n" +
                        "USUARIO = " + (T_usuario) + "\n" +
                        "CLAVE = " + T_clave + "\n\n" +
                        "Nota: Si deja los campos en blanco, se usarán los valores por defecto indicados arriba.\n" +
                        "¿Desea continuar con estos datos?",
                        "AVISO DEL SISTEMA",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }

                this.baseDatos = "c_rueba_1";
                this.servidor = T_servidor;
                this.puerto = T_puerto;
                this.usuario = T_usuario;
                this.clave = T_clave;

             


            }

        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString =
                "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                Console.WriteLine(ex.ToString());
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }

        public bool QueryBool(string user, string pass)
        {

            return true;
        }


    }

}
