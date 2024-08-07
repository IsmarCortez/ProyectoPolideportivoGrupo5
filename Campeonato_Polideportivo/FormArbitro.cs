using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Campeonato_Polideportivo
{

    public partial class FormArbitro : Form
    {
        private UsuarioValidator usuarioValidator;
        private Conexion FormConexion;
        private string connectionString;
        public FormArbitro()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            DateTime fechaNacimiento = DtpFechaNacimiento.Value;
            string nacionalidad = TxtNacionalidad.Text;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                string query = "INSERT INTO arbitro (nombre, apellido, fechanacimiento, nacionalidad) VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@nacionalidad", nacionalidad);

                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Árbitro ingresado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar el árbitro.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
                }
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idArbitro;
            if (!int.TryParse(TxtId.Text, out idArbitro))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            conn.Open();
            string query = "DELETE FROM arbitro WHERE pkidarbitro = @id_arbitro";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_arbitro", TxtId.Text);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Árbitro eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el árbitro. Verifique el ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            try
            {
                // Obtener los datos de los TextBoxes
                string nombre = TxtNombre.Text;
                string apellido = TxtApellido.Text;
                DateTime fechaNacimiento = DtpFechaNacimiento.Value; // Asumimos que el DateTimePicker se llama TxtFechaNacimiento
                string nacionalidad = TxtNacionalidad.Text;

                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del arbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtApellido.Text))
                {
                    MessageBox.Show("Por favor ingrese el apellido del arbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtNacionalidad.Text))
                {
                    MessageBox.Show("Por favor ingrese la nacionalidad del arbitro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {

                    conn.Open();
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE arbitro SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, " +
                           "nacionalidad = @nacionalidad WHERE pkidarbitro = @pkidarbitro";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                        cmd.Parameters.AddWithValue("@pkidarbitro", TxtId.Text); // Usa el valor del TextBox

                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Datos modificados correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Mensaje si no se encontró el registro
                                MessageBox.Show("No se encontró el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // El usuario hizo clic en "No"
                            MessageBox.Show("No se realizó ninguna acción.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = DgwArbitro.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgwArbitro.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = DgwArbitro.CurrentRow.Cells[2].Value.ToString();
                DtpFechaNacimiento.Text = DgwArbitro.CurrentRow.Cells[3].Value.ToString();
                TxtNacionalidad.Text = DgwArbitro.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            try
            {
                string query = "SELECT * FROM arbitro";

                // Crear el adaptador
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    conn.Open();
                    // Crear un DataTable para almacenar los datos
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    adapter.Fill(dt);

                    // Asignar el DataTable como el origen de datos del DataGridView
                    DgwArbitro.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        

        private void FormArbitro_Load(object sender, EventArgs e)
        {
            // Maximizar la ventana
            this.WindowState = FormWindowState.Maximized;

            // Crear instancias
            Conexion conexion = new Conexion();
            UsuarioValidator usuarioValidator = new UsuarioValidator(connectionString);

            // Obtener el nombre de usuario actual
            string usuario = GlobalVariables.usuario;

            // Obtener el nivel de acceso del usuario
            int nivelDeAcceso = usuarioValidator.ObtenerNivelDeAcceso(usuario);

            // Controlar la visibilidad de los botones basado en el nivel de acceso
            if (nivelDeAcceso == 1)
            {

                BtnIngresar.Visible = true;
                BtnVer.Visible = true;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            else if (nivelDeAcceso == 2)
            {

                BtnIngresar.Visible = true;
                BtnVer.Visible = true;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            else if (nivelDeAcceso == 3)
            {
                BtnIngresar.Visible = true;
                BtnVer.Visible = true;
                BtnModificar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                // Si el nivel de acceso no está definido (por ejemplo, usuario no encontrado)
                BtnIngresar.Visible = false;
                BtnVer.Visible = false;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }

        }
    }
    }
