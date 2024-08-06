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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            // Asociar el evento KeyPress
            TxtContrasenia.KeyPress += TxtContrasenia_KeyPress;
        }



        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            GlobalVariables.usuario = TxtUsuario.Text;
            string contrasenia = TxtContrasenia.Text;

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bool tienePermisos = false;
                    bool esValido = false;
                    int userId = 0;

                    // Consulta para verificar permisos del usuario
                    string permisosQuery = "SELECT pkidusuario, fkpermisos, fkprivilegios FROM usuario WHERE usuario = @usuario";

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
                                // Lee los permisos del usuario
                                int fkPermisos = reader.GetInt32("fkpermisos");
                                int fkPrivilegios = reader.GetInt32("fkprivilegios");

                                // Guarda el pkidusuario
                                userId = reader.GetInt32("pkidusuario");

                                // Verifica si los permisos son 3 y 3
                                if (fkPermisos == 3 || fkPrivilegios == 3 && fkPermisos == 2 || fkPrivilegios == 2)
                                {
                                    tienePermisos = true;
                                }
                            }
                        }
                    }

                    if (tienePermisos)
                    {
                        // Consulta para verificar usuario y contraseña
                        string credencialesQuery = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contrasenia = @contrasenia";

                        using (MySqlCommand credencialesCmd = new MySqlCommand(credencialesQuery, conn))
                        {
                            credencialesCmd.Parameters.AddWithValue("@usuario", GlobalVariables.usuario);
                            credencialesCmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                            int count = Convert.ToInt32(credencialesCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                esValido = true;
                            }
                        }

                        if (esValido)
                        {
                            // Actualizar iniciodesesion a true para activar el trigger
                            string actualizarInicioSesionQuery = "UPDATE usuario SET iniciosesion = @iniciosesion WHERE pkidusuario = @userId";

                            using (MySqlCommand actualizarCmd = new MySqlCommand(actualizarInicioSesionQuery, conn))
                            {
                                actualizarCmd.Parameters.AddWithValue("@iniciosesion", true);
                                actualizarCmd.Parameters.AddWithValue("@userId", userId);
                                actualizarCmd.ExecuteNonQuery();
                            }

                            // Acción a realizar si el usuario y la contraseña son válidos
                            Form1 obj = new Form1();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Acción a realizar si el usuario y/o la contraseña no son válidos
                            MessageBox.Show("No puedes pasar, tu cuenta no existe!");
                        }
                    }
                    else
                    {
                        // Mensaje si el usuario no tiene permisos suficientes
                        MessageBox.Show("No tienes permisos suficientes para acceder a esta función.");
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    // Asegurarse de que la conexión se cierra
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
