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
    public partial class Usuarios : Form
    {
        private string connectionString;
        public Usuarios()
        {
            InitializeComponent();
        }
        private int ObtenerIdUsuario(string nombreUsuario)
        {
            Conexion conexion = new Conexion();
            int usuarioId = 0;
            Bitacora bitacora = new Bitacora(connectionString);
            string query = "SELECT pkidusuario FROM usuario WHERE usuario = @nombreUsuario";

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                using (var command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    usuarioId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return usuarioId;
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
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            string usuario = TxtUsuario.Text;
            string contrasenia = TxtContrasenia.Text;
            string correo = TxtCorreo.Text;
            string permiso = CmbPermisos.Text;
            string confirmar = TxtConfirmacion.Text;

            // Definir valores predeterminados para permisos y privilegios
            int fkpermisos = 1;
            int fkprivilegios = 1;

            // Asignar valores basados en la selección en el ComboBox
            switch (permiso)
            {
                case "Administrador":
                    fkpermisos = 3;
                    fkprivilegios = 3;
                    break;
                case "Gerente":
                    fkpermisos = 2;
                    fkprivilegios = 2;
                    break;
                case "Usuario Estándar":
                    fkpermisos = 1;
                    fkprivilegios = 1;
                    break;
                default:
                    // Manejo de errores en caso de selección no válida
                    MessageBox.Show("Selección de permisos no válida.");
                    return; // Termina el método si la selección no es válida
            }

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
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
                                         "VALUES (@usuario, @correo, @contrasenia, @fkpermisos, @fkprivilegios, @ultimaconexion)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        if (contrasenia == confirmar)
                        {
                            string contraseniaEncriptada = GetSHA256Hash(contrasenia);
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@correo", correo);
                            cmd.Parameters.AddWithValue("@contrasenia", contraseniaEncriptada);
                            cmd.Parameters.AddWithValue("@fkpermisos", fkpermisos);
                            cmd.Parameters.AddWithValue("@fkprivilegios", fkprivilegios);
                            cmd.Parameters.AddWithValue("@ultimaconexion", DateTime.Now.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();
                            bitacora.RegistrarEvento("Creó un nuevo usuario", usuarioId);
                            MessageBox.Show("Usuario insertado exitosamente");
                            TxtUsuario.Text = string.Empty;
                            TxtContrasenia.Text = string.Empty;
                            TxtCorreo.Text = string.Empty;
                            TxtConfirmacion.Text = string.Empty;
                            CmbPermisos.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden");
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

        private void LblCampeonato_Click(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaUsuarios";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvUsuarios.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvUsuarios.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            TxtUsuario.TabIndex = 0;
            TxtContrasenia.TabIndex = 1;
            TxtConfirmacion.TabIndex = 2;
            TxtCorreo.TabIndex = 3;
            CmbPermisos.TabIndex = 4;
            BtnRegistrar.TabIndex = 5;
            BtnVer.TabIndex = 6;
            DgvUsuarios.TabStop = false;
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                      
        }
    }
}
