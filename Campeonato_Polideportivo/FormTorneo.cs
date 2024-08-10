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
    public partial class FormTorneo : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormTorneo()
        {
            InitializeComponent();
            CargarComboBox();

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
            var selectedDeporte = (KeyValuePair<int, string>)CmbDeporte.SelectedItem;
            int fkiddeporte = selectedDeporte.Key;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO torneo (nombre, temporada, fechainicio, fechafin, fkiddeporte) " +
                                   "VALUES (@nombre, @temporada, @fechainicio, @fechafin, @fkiddeporte)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                        command.Parameters.AddWithValue("@fechainicio", DtpFechaInicio.Value);
                        command.Parameters.AddWithValue("@fechafin", DtpFechafin.Value);
                        command.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            bitacora.RegistrarEvento("Creó un nuevo torneo", usuarioId);
                            MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                finally
                {
                    limpiar();
                }
            }
        }

        private void CargarComboBox()
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT pkiddeporte, nombre FROM deporte";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        Dictionary<int, string> deportes = new Dictionary<int, string>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("pkiddeporte");
                            string nombre = reader.GetString("nombre");
                            deportes.Add(id, nombre);
                        }
                        CmbDeporte.DataSource = new BindingSource(deportes, null);
                        CmbDeporte.DisplayMember = "Value";
                        CmbDeporte.ValueMember = "Key";
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
            TxtNombre.Text = string.Empty;
            TxtTemporada.Text = string.Empty;
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechafin.Text = string.Empty;
            CmbDeporte.Text = "";
            // TxtSexo.Text = string.Empty;
            //PicFotografia.Image = null;
            //fotoBytes = null;
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM torneo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DgvTorneo.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DgvTorneo.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = DgvTorneo.CurrentRow.Cells[1].Value.ToString();
            TxtTemporada.Text = DgvTorneo.CurrentRow.Cells[2].Value.ToString();
            DtpFechaInicio.Text = DgvTorneo.CurrentRow.Cells[3].Value.ToString();
            DtpFechafin.Text = DgvTorneo.CurrentRow.Cells[4].Value.ToString();
            // TxtFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           // CmbDeporte.Text = GridVer.CurrentRow.Cells[5].Value.ToString();

            //PicFotografia.Text = GridVer.CurrentRow.Cells[6].Value.ToString();




        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            var selectedDeporte = (KeyValuePair<int, string>)CmbDeporte.SelectedItem;
            int fkiddeporte = selectedDeporte.Key;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE torneo SET nombre = @nombre, temporada = @temporada, fechainicio = @fechainicio, fechafin = @fechafin, fkiddeporte = @fkiddeporte WHERE pkidtorneo = @pkidtorneo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@pkidtorneo", TxtId.Text);
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                        command.Parameters.AddWithValue("@fechainicio", DtpFechaInicio.Value);
                        command.Parameters.AddWithValue("@fechafin", DtpFechafin.Value);
                        command.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            bitacora.RegistrarEvento("Modificó un torneo", usuarioId);
                            MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                finally
                {
                    limpiar();
                }
            }
        }


        private void FormTorneo_Load(object sender, EventArgs e)
        {
            CmbDeporte.Text = "Seleccione un deporte...";

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
            TxtTemporada.TabIndex = 1;
            DtpFechaInicio.TabIndex = 2;
            DtpFechafin.TabIndex = 3;
            CmbDeporte.TabIndex = 4;
            BtnIngresar.TabIndex = 5;
            BtnVer.TabIndex = 6;
            BtnModificar.TabIndex = 7;
            BtnEliminar.TabIndex = 8;
            BtnAyuda.TabIndex = 9;

            DgvTorneo.TabStop = false;

            // Configurar DateTimePicker de fecha de inicio
            DtpFechaInicio.MinDate = DateTime.Today;    
            //DtpFechaInicio.MaxDate = DateTime.Today.AddYears(1);     
            // Configurar DateTimePicker de fecha de fin
            DtpFechafin.MinDate = DateTime.Today;     
            DtpFechafin.MaxDate = DateTime.Today.AddYears(1); 
            // Asociar eventos ValueChanged
            DtpFechaInicio.ValueChanged += DtpFechaInicio_ValueChanged; 
            DtpFechafin.ValueChanged += DtpFechafin_ValueChanged;
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
                    string query = "DELETE FROM torneo WHERE pkidtorneo = @pkidtorneo";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidtorneo", TxtId.Text);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se eliminó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de que si se elimino
                            bitacora.RegistrarEvento("Eliminó un torneo", usuarioId);
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
            int pageNumber = 42;

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

        private void DtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (DtpFechaInicio.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio no puede ser anterior a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning); DtpFechaInicio.Value = DateTime.Today; // Restablecer a la fecha mínima permitida
                                                                                                                                                                                            }     
            // Actualizar la fecha mínima del DateTimePicker de fecha de fin asegurándose que
            //MinDate <= MaxDate
            DateTime nuevaFechaMin = DtpFechaInicio.Value; 
            if (nuevaFechaMin > DtpFechafin.MaxDate) { 
                DtpFechafin.MaxDate = nuevaFechaMin.AddYears(1); 
            } DtpFechafin.MinDate = nuevaFechaMin;

            }

        private void DtpFechafin_ValueChanged(object sender, EventArgs e)
        {


            if (DtpFechafin.Value > DtpFechaInicio.Value.AddYears(1))
            {
                MessageBox.Show("La fecha de fin no puede ser más de un año después de la fecha de inicio.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                DtpFechafin.Value = DtpFechaInicio.Value.AddYears(1); // Restablecer a la fecha máxima permitida }
            }
        }
    }
}
