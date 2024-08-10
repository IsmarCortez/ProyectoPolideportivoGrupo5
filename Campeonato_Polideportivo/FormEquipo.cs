using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; // Para Process y ProcessStartInfo
using System.IO; // Para Path


namespace Campeonato_Polideportivo
{
    public partial class FormEquipo : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormEquipo()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
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
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();
            string nombre = TxtNombreEquipo.Text;
            string estadio = TxtEstadio.Text;
            string ciudad = TxtCiudad.Text;
            // Verificar si contiene dígitos
            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (estadio.Any(char.IsDigit))
            {
                MessageBox.Show("El estadio no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ciudad.Any(char.IsDigit))
            {
                MessageBox.Show("La ciudad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    // Consulta SQL para insertar datos sin el ID
                    string query = "INSERT INTO equipo (nombre, estadio, ciudad) VALUES (@nombre, @estadio, @ciudad)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@estadio", estadio);
                        cmd.Parameters.AddWithValue("@ciudad", ciudad);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        bitacora.RegistrarEvento("Ingresó un nuevo equipo", usuarioId);
                        MessageBox.Show("Datos ingresados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();

            try
            {
                // Obtener el id_equipo del TextBox
                int pkidequipo = int.Parse(TxtIdEquipo.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM equipo WHERE pkidequipo = @pkidequipo";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidequipo", pkidequipo);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se eliminó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de que si se elimino
                            bitacora.RegistrarEvento("Eliminó un equipo", usuarioId);
                            MessageBox.Show("Datos eliminados correctamente.");
                        }
                        else
                        {
                            //  mensaje si no se encontró el registro
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();
            try
            {
                // Obtener los datos de los TextBoxes
                int id_equipo = int.Parse(TxtIdEquipo.Text);
                string nombre = TxtNombreEquipo.Text;
                string estadio = TxtEstadio.Text;
                string ciudad = TxtCiudad.Text;
                // Verificar si contiene dígitos
                if (nombre.Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (estadio.Any(char.IsDigit))
                {
                    MessageBox.Show("El estadio no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ciudad.Any(char.IsDigit))
                {
                    MessageBox.Show("La ciudad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE equipo SET nombre = @nombre, estadio = @estadio, ciudad = @ciudad WHERE pkidequipo = @pkidequipo";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidequipo", id_equipo);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@estadio", estadio);
                        cmd.Parameters.AddWithValue("@ciudad", ciudad);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se modificó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Modificó un equipo", usuarioId);
                            MessageBox.Show("Datos modificados correctamente.");
                        }
                        else
                        {
                            // Mostrar mensaje si no se encontró el registro
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
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

        private void BtnVer_Click(object sender, EventArgs e)
        {
            //conexion del SQL
            Conexion conexion = new Conexion();

            try
            {
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para obtener datos
                    string query = "SELECT * FROM equipo";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvEquipo.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
          
                // Limpiar los TextBox del form
                TxtIdEquipo.Text = string.Empty;
                TxtNombreEquipo.Text = string.Empty;
                TxtEstadio.Text = string.Empty;
                TxtCiudad.Text = string.Empty;
            

        }

       
        private void FormEquipo_Load(object sender, EventArgs e)
        {

            TxtIdEquipo.TabIndex = 0;
            TxtNombreEquipo.TabIndex = 1;
            TxtEstadio.TabIndex = 2;
            TxtCiudad.TabIndex = 3;

            //desactivar dataGridView1
            DgvEquipo.TabStop = false;

            // Desactivar TabStop para los botones para que no reciban el foco con Tab
            BtnIngresar.TabIndex = 4;
            BtnModificar.TabIndex = 5;
            BtnEliminar.TabIndex = 6;
            BtnLimpiar.TabIndex = 7;
            BtnVer.TabIndex = 8;
            BtnAyuda.TabIndex = 9;


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

                BtnIngresar.Visible = false;
                BtnVer.Visible = true;
                BtnLimpiar.Visible = true;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            else if (nivelDeAcceso == 2)
            {

                BtnIngresar.Visible = true;
                BtnVer.Visible = true;
                BtnLimpiar.Visible = true;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            else if (nivelDeAcceso == 3)
            {
                BtnIngresar.Visible = true;
                BtnVer.Visible = true;
                BtnLimpiar.Visible = true;
                BtnModificar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                // Si el nivel de acceso no está definido (por ejemplo, usuario no encontrado)
                BtnIngresar.Visible = false;
                BtnVer.Visible = false;
                BtnLimpiar.Visible = false;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            
            TxtIdEquipo.TabIndex = 0;
            TxtNombreEquipo.TabIndex = 1;
            TxtEstadio.TabIndex = 2;
            TxtCiudad.TabIndex = 3;

            BtnIngresar.TabIndex= 4;
            BtnModificar.TabIndex = 5;
            BtnEliminar.TabIndex = 6;
            BtnLimpiar.TabIndex = 7;
            BtnVer.TabIndex = 8;
            //desactivar dataGridView1
            DgvEquipo.TabStop = false;

        }

        private void TxtIdEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdEquipo.Text = DgvEquipo.CurrentRow.Cells[0].Value.ToString();
                TxtNombreEquipo.Text = DgvEquipo.CurrentRow.Cells[1].Value.ToString();
                TxtEstadio.Text = DgvEquipo.CurrentRow.Cells[2].Value.ToString();
                TxtCiudad.Text = DgvEquipo.CurrentRow.Cells[3].Value.ToString();
               
            }
            catch
            {
            }
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            // Obtén la ruta del directorio base del proyecto
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Ruta al archivo PDF en la raíz del proyecto
            string pdfPath = Path.Combine(baseDirectory, "..", "..", "..", "manual.pdf");

            // Verifica la ruta construida
            string fullPath = Path.GetFullPath(pdfPath);
            MessageBox.Show($"Ruta del PDF: {fullPath}");

            // Número de página a la que deseas ir (comienza desde 1)
            int pageNumber = 11;

            // URL para abrir el PDF en una página específica
            string pdfUrl = $"file:///{fullPath.Replace('\\', '/')}#page={pageNumber}";

            // Escapa espacios en la URL
            pdfUrl = pdfUrl.Replace(" ", "%20");

            try
            {
                // Usa ProcessStartInfo para abrir el archivo con el programa asociado
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pdfUrl,
                    UseShellExecute = true  // Asegúrate de que UseShellExecute esté en true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el PDF. Error: {ex.Message}");
            }


        }
    }
}
