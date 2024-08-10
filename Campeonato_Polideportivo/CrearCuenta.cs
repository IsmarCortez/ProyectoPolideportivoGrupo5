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
using System.Security.Cryptography;

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

        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            string usuario = TxtUsuario.Text;
            string contrasenia = TxtContrasenia.Text;
            string correo = TxtCorreo.Text;
            string confirmacion = TxtConfirmacion.Text;

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
                        if (confirmacion == contrasenia)
                        {
                            string contraseniaEncriptada = GetSHA256Hash(contrasenia);
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@correo", correo);
                            cmd.Parameters.AddWithValue("@contrasenia", contraseniaEncriptada);
                            cmd.Parameters.AddWithValue("@ultimaconexion", DateTime.Now.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario insertado exitosamente");
                            TxtConfirmacion.Text = string.Empty;
                            TxtUsuario.Text = string.Empty;
                            TxtContrasenia.Text = string.Empty;
                            TxtCorreo.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coiciden intentelo nuevamente");
                            TxtConfirmacion.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            TxtUsuario.TabIndex = 0;
            TxtContrasenia.TabIndex = 1;
            TxtConfirmacion.TabIndex = 2;
            TxtCorreo.TabIndex = 3;
            BtnRegistrar.TabIndex = 4;
        }
    }
}
    

