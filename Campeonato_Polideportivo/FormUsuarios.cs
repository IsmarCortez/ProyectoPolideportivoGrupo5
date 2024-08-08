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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;
            string correo = txtCorreo.Text;
            string permiso = cmbPermisos.Text;

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
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
                        cmd.Parameters.AddWithValue("@fkpermisos", fkpermisos);
                        cmd.Parameters.AddWithValue("@fkprivilegios", fkprivilegios);
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

                txtUsuario.Text = string.Empty;
                txtContrasenia.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                cmbPermisos.Text = string.Empty;
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
                    dgvUsuarios.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvUsuarios.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
