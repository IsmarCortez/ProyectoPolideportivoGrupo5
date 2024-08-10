using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_Polideportivo
{
    public partial class FormEntrenador : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormEntrenador()
        {
            InitializeComponent();
            CargarEquipos();
            CmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

       

        private void FormEntrenador_Load(object sender, EventArgs e)
        {
            CmbEquipo.Text = "Seleccione un equipo...";

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

            TxtNombre.TabIndex = 0;
            TxtApellido.TabIndex = 1;
            DtpEntrenador.TabIndex = 2;
            TxtNacionalidad.TabIndex = 3;
            CmbEquipo.TabIndex = 4;
            BtnIngresar.TabIndex = 5;
            BtnVer.TabIndex = 6;
            BtnModificar.TabIndex = 7;
            BtnEliminar.TabIndex = 8;
            BtnAyuda.TabIndex = 9;
            DgvEntrenador.TabStop = false;
        }

        private void CargarEquipos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidequipo, nombre FROM equipo";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbEquipo.DataSource = dt;
                CmbEquipo.DisplayMember = "nombre";
                CmbEquipo.ValueMember = "pkidequipo";
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

            string Nombre = TxtNombre.Text;
            string Apellido = TxtApellido.Text;
            DateTime FechaNacimiento = DtpEntrenador.Value;
            string Nacionalidad = TxtNacionalidad.Text;
            int Equipo = Convert.ToInt32(CmbEquipo.SelectedValue);

            if (string.IsNullOrWhiteSpace(TxtNombre.Text)) //Para obligar a llenar los campos
            {
                MessageBox.Show("Por favor ingrese el nombre del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNacionalidad.Text))
            {
                MessageBox.Show("Por favor ingrese la nacionalidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                MessageBox.Show("Por favor ingrese el apellido del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO entrenador (nombre, apellido, fechanacimiento, nacionalidad, fkidequipo) VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad, @equipo)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fechanacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        bitacora.RegistrarEvento("Ingresó un nuevo entrenador", usuarioId);
                        MessageBox.Show("Datos ingresados correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
                Limpiar();
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();


            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    //  string query = "SELECT * FROM entrenador";

                    string query = @"
                        SELECT 
                            entrenador.pkidentrenador AS IDEntrenador,
                            entrenador.Nombre AS Nombre, 
                            entrenador.Apellido AS Apellido, 
                            entrenador.fechanacimiento AS FechaDeNacimiento, 
                            entrenador.Nacionalidad AS Nacionalidad, 
                            equipo.Nombre AS EquipoNombre
                        FROM 
                            entrenador
                        JOIN 
                            equipo ON entrenador.fkidequipo = equipo.pkidequipo";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvEntrenador.DataSource = dt;
                    }
                }

                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
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
                string Nombre = TxtNombre.Text;
                string Apellido = TxtApellido.Text;
               // DateTime.TryParse(TxtFechaNacimiento.Text, out FechaNacimiento);
                DateTime FechaNacimiento = DtpEntrenador.Value;
                string Nacionalidad = TxtNacionalidad.Text;
                int Equipo = Convert.ToInt32(CmbEquipo.SelectedValue);
                if (string.IsNullOrWhiteSpace(TxtNombre.Text)) //Para obligar a llenar los campos
                {
                    MessageBox.Show("Por favor ingrese el nombre del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtNacionalidad.Text))
                {
                    MessageBox.Show("Por favor ingrese la nacionalidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtApellido.Text))
                {
                    MessageBox.Show("Por favor ingrese el apellido del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE Entrenador SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, nacionalidad = @nacionalidad, fkidequipo = @equipo WHERE pkidentrenador = @pkidentrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidentrenador", TxtID.Text);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fechanacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                bitacora.RegistrarEvento("Modificó un entrenador", usuarioId);
                                MessageBox.Show("Datos modificados correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //  mensaje si no se encontró el registro
                                MessageBox.Show("No se encontro el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // El usuario hizo clic en "No"
                            MessageBox.Show("No se realizó ninguna acción.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    Limpiar();
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
                TxtID.Text = DgvEntrenador.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgvEntrenador.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = DgvEntrenador.CurrentRow.Cells[2].Value.ToString();
                DtpEntrenador.Text = DgvEntrenador.CurrentRow.Cells[3].Value.ToString();
                TxtNacionalidad.Text = DgvEntrenador.CurrentRow.Cells[4].Value.ToString();
                CmbEquipo.Text = DgvEntrenador.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

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
                // Obtener el id_entrenador del TextBox
                int identrenador = int.Parse(TxtID.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM Entrenador WHERE pkidentrenador = @pkidentrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidentrenador", identrenador);

                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                bitacora.RegistrarEvento("Eliminó un entrenador", usuarioId);
                                MessageBox.Show("Datos eliminados correctamente.", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                //  mensaje si no se encontró el registro
                                MessageBox.Show("No se encontro el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Limpiar();
        }

        private void Limpiar(){
            TxtID.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            DtpEntrenador.Value = DateTime.Now;
            CmbEquipo.Text = "Seleccione un equipo...";
            TxtNacionalidad.Clear();
       }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            int pageNumber = 21;

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
