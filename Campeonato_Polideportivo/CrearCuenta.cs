using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public partial class CrearCuenta : Form
    {
        private Conexion FormConexion;
        public CrearCuenta()
        {
            InitializeComponent();
            FormConexion = new Conexion();  //Se manda a llamar la conexion
            this.Load += new EventHandler(CrearCuenta_Load); //evento para poner el programa en pantalla completa
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            string correo = txtCorreo.Text;

            // Usa la conexión dentro de un bloque using
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open(); // Abre la conexión aquí

                    // Verifica si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario OR email = @correo";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@usuario", usuario);
                        checkCmd.Parameters.AddWithValue("@correo", correo);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            // Si ya existe, muestra un mensaje de error
                            MessageBox.Show("Usuario o correo en uso.");
                            return; // Termina el método si ya existe
                        }
                    }

                    // Prepara la consulta SQL para insertar el nuevo usuario
                    string insertQuery = "INSERT INTO usuario (usuario, email, contrasenia, fkpermisos, fkprivilegios, ultimaconexion) " +
                                         "VALUES (@usuario, @correo, @contrasenia, 1, 1, @ultimaconexion)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@ultimaconexion", DateTime.Now.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario insertado exitosamente");
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
    

