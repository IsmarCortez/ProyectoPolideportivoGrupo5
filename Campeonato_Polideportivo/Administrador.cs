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
    public partial class Administrador : Form
    {
        private string connectionString;
        public Administrador()
        {
            InitializeComponent();
            // Asociar el evento KeyPress
            TxtContrasenia.KeyPress += TxtContrasenia_KeyPress;
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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            GlobalVariables.usuario = TxtUsuario.Text;
            string contrasenia = TxtContrasenia.Text;
            string contraseniaHashIngresada = GetSHA256Hash(contrasenia);

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bool tienePermisos = false;
                    bool esValido = false;
                    int userId = 0;

                    Bitacora bitacora = new Bitacora(connectionString);

                    // Consulta para verificar permisos del usuario y obtener la contraseña hasheada
                    string permisosQuery = "SELECT pkidusuario, fkpermisos, fkprivilegios, contrasenia FROM usuario WHERE usuario = @usuario";

                    using (MySqlCommand permisosCmd = new MySqlCommand(permisosQuery, conn))
                    {
                        permisosCmd.Parameters.AddWithValue("@usuario", GlobalVariables.usuario);

                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open(); // Abrir la conexión solo si está cerrada
                        }

                        using (MySqlDataReader reader = permisosCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int fkPermisos = reader.GetInt32("fkpermisos");
                                int fkPrivilegios = reader.GetInt32("fkprivilegios");
                                userId = reader.GetInt32("pkidusuario");
                                string contraseniaAlmacenada = reader.GetString("contrasenia").Trim();

                                // Combinación de condiciones para permisos y privilegios
                                if ((fkPermisos == 3 && fkPrivilegios == 3) || (fkPermisos == 2 && fkPrivilegios == 2))
                                {
                                    tienePermisos = true;
                                }

                                esValido = (contraseniaHashIngresada == contraseniaAlmacenada);
                            }
                            else
                            {
                                MessageBox.Show("El usuario no existe.");
                                return; // Salir si el usuario no existe
                            }
                        }
                    }

                    if (tienePermisos && esValido)
                    {
                        bitacora.RegistrarEvento("Inicio de sesión exitoso.", userId);

                        string actualizarInicioSesionQuery = "UPDATE usuario SET iniciosesion = @iniciosesion WHERE pkidusuario = @userId";

                        using (MySqlCommand actualizarCmd = new MySqlCommand(actualizarInicioSesionQuery, conn))
                        {
                            actualizarCmd.Parameters.AddWithValue("@iniciosesion", true);
                            actualizarCmd.Parameters.AddWithValue("@userId", userId);
                            actualizarCmd.ExecuteNonQuery();
                        }

                        Form1 obj = new Form1();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No puedes pasar, tu cuenta no existe o no tienes permisos suficientes!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void TxtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Evita el beep cuando se presiona Enter
                e.Handled = true;
                // Llama al método del botón como si se hubiera hecho clic en él
                BtnIngresar_Click(sender, e);
            }
        }

    }
   
}
