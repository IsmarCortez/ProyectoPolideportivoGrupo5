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
// Código hecho por Gabriela Suc 0901-21-1278
namespace Campeonato_Polideportivo
{
    public partial class FormPartidosIndividuales : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormPartidosIndividuales()
        {
            InitializeComponent();
            CargarComboBoxLocal();
            CargarComboBoxVis();
            CargarComboBoxTorneo();

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

        private void FormPartidosIndividuales_Load(object sender, EventArgs e)
        {


            CmbLocal.Text = "Seleccione un deportista local..";
            CmbVis.Text = "Seleccione un deportista visitante..";
            CmbTorneo.Text = "Seleccione un Torneo";

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
                CmbLocal.Enabled = false;
                CmbVis.Enabled = false;
                CmbTorneo.Enabled = false;
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

            CmbLocal.TabIndex = 0;
            CmbVis.TabIndex = 1;
            CmbTorneo.TabIndex = 2;
            BtnIngresar.TabIndex = 3;
            BtnVer.TabIndex = 4;
            BtnModificar.TabIndex = 5;
            BtnEliminar.TabIndex = 6;
            BtnAyuda.TabIndex = 7;

            DgvPartidosIndividuales.TabStop = false;
        }

        private void CargarComboBox(ComboBox comboBox, string query)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        Dictionary<int, string> items = new Dictionary<int, string>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            items.Add(id, nombre);
                        }
                        comboBox.DataSource = new BindingSource(items, null);
                        comboBox.DisplayMember = "Value";
                        comboBox.ValueMember = "Key";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarComboBoxLocal()
        {
            CargarComboBox(CmbLocal, "SELECT pkidjugador, nombre FROM deportista");
        }

        private void CargarComboBoxVis()
        {
            CargarComboBox(CmbVis, "SELECT pkidjugador, nombre FROM deportista");
        }

        private void CargarComboBoxTorneo()
        {
            CargarComboBox(CmbTorneo, "SELECT pkidtorneo, nombre FROM torneo");
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
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO partidosindividuales (fkdeportistalocal, fkdeportistavisitante, fkidtorneo) VALUES (@fkdeportistalocal, @fkdeportistavisitante, @fkidtorneo)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@fkdeportistalocal", selectedLocal.Key);
                        command.Parameters.AddWithValue("@fkdeportistavisitante", selectedVis.Key);
                        command.Parameters.AddWithValue("@fkidtorneo", selectedTorneo.Key);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            bitacora.RegistrarEvento("Ingresó un nuevo partido individual", usuarioId);
                            MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void limpiar()
        {
            TxtId.Text = string.Empty;
            CmbLocal.Text = "Seleccione un deportista local..";
            CmbVis.Text = "Seleccione un deportista visitante..";
            CmbTorneo.Text = "Seleccione un Torneo";
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string query = "SELECT * FROM VistaPartidosIndividuales";

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
                    DgvPartidosIndividuales.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvPartidosIndividuales.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DgvPartidosIndividuales.CurrentRow.Cells[0].Value.ToString();
            CmbLocal.Text = DgvPartidosIndividuales.CurrentRow.Cells[1].Value.ToString();
            CmbVis.Text = DgvPartidosIndividuales.CurrentRow.Cells[2].Value.ToString();
            CmbTorneo.Text = DgvPartidosIndividuales.CurrentRow.Cells[3].Value.ToString();


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE partidosindividuales SET fkdeportistalocal = @fkdeportistalocal, fkdeportistavisitante = @fkdeportistavisitante, fkidtorneo = @fkidtorneo WHERE pkidsesion = @pkidsesion";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@pkidsesion", TxtId.Text);
                        command.Parameters.AddWithValue("@fkdeportistalocal", selectedLocal.Key);
                        command.Parameters.AddWithValue("@fkdeportistavisitante", selectedVis.Key);
                        command.Parameters.AddWithValue("@fkidtorneo", selectedTorneo.Key);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            bitacora.RegistrarEvento("Modificó un partido individual", usuarioId);
                            MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM partidosindividuales WHERE pkidsesion = @pkidsesion";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidsesion", TxtId.Text);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se eliminó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de que si se elimino
                            bitacora.RegistrarEvento("Eliminó un partido individual", usuarioId);
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
            limpiar();
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
            int pageNumber = 47;

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


