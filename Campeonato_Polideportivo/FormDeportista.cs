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
// Código hecho por Ismar Cortéz 0901-21-506 Marco Monroy 0901-21-843
namespace Campeonato_Polideportivo
{

    public partial class FormDeportista : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private byte[] fotoBytes;
        private UsuarioValidator usuarioValidator;
        public FormDeportista()
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
            // Verificar si contiene dígitos
            if (TxtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El apellido no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtNacionalidad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La nacionalidad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtSexo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El sexo no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO deportista (nombre, apellido, fechanacimiento, nacionalidad, sexo, fotografia) " +
                                   "VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad, @sexo, @fotografia)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                        command.Parameters.AddWithValue("@fechanacimiento", DtpFechaNacimiento.Value);
                        command.Parameters.AddWithValue("@nacionalidad", TxtNacionalidad.Text);
                        command.Parameters.AddWithValue("@sexo", TxtSexo.Text);
                        command.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            bitacora.RegistrarEvento("Ingresó un nuevo deportista", usuarioId);
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

        private void PicFotografia_Click(object sender, EventArgs e)
        {

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filepath = openFileDialog.FileName;
                fotoBytes = File.ReadAllBytes(filepath);
                PicFotografia.Image = new Bitmap(filepath);
            
            }




        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "SELECT * FROM deportista";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        DgvDeportista.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            // Verificar si contiene dígitos
            if (TxtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El apellido no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtNacionalidad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La nacionalidad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtSexo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El sexo no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Conexion conexion = new Conexion();
            try
            {
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE deportista SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, nacionalidad = @nacionalidad, sexo= @sexo, fotografia=@fotografia WHERE pkidjugador = @pkidjugador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidjugador", textID.Text);
                        cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                        cmd.Parameters.AddWithValue("@fechanacimiento", DtpFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@nacionalidad", TxtNacionalidad.Text);
                        cmd.Parameters.AddWithValue("@sexo", TxtSexo.Text);
                        cmd.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se modificó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Modificó un deportista", usuarioId);
                            MessageBox.Show("Datos modificados correctamente.");
                        }
                        else
                        {
                            // Mostrar mensaje si no se encontró el registro
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
                        }
                    }
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }









        private void limpiar()
        {
            textID.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            DtpFechaNacimiento.Value = DateTime.Now;
            TxtNacionalidad.Text = string.Empty;
            TxtSexo.Text = string.Empty;
            PicFotografia.Image = null;
            fotoBytes = null;
        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = DgvDeportista.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgvDeportista.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = DgvDeportista.CurrentRow.Cells[2].Value.ToString();
                DtpFechaNacimiento.Text = DgvDeportista.CurrentRow.Cells[3].Value.ToString();
                // TxtFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtNacionalidad.Text = DgvDeportista.CurrentRow.Cells[4].Value.ToString();
                TxtSexo.Text = DgvDeportista.CurrentRow.Cells[5].Value.ToString();
                //PicFotografia.Text = GridVer.CurrentRow.Cells[6].Value.ToString();

                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
                if (e.RowIndex >= 0 && DgvDeportista.Columns.Contains("fotografia"))
                {
                    DataGridViewRow row = DgvDeportista.Rows[e.RowIndex];
                    if (row.Cells["fotografia"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row.Cells["fotografia"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {

                            PicFotografia.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        PicFotografia.Image = null;
                    }
                }



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

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM deportista WHERE pkidjugador = @pkidjugador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidjugador", textID.Text);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se eliminó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de que si se elimino
                            bitacora.RegistrarEvento("Eliminó un deportista", usuarioId);
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

       

        private void FormDeportista_Load(object sender, EventArgs e)
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

                BtnIngresar.Visible = false;
                BtnVer.Visible = true;
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
                TxtNombre.Enabled = false;
                TxtApellido.Enabled = false;
                DtpFechaNacimiento.Enabled = false;
                TxtNacionalidad.Enabled = false;
                TxtSexo.Enabled = false;
                BtnFoto.Enabled = false;
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
            DtpFechaNacimiento.TabIndex = 2;
            TxtNacionalidad.TabIndex = 3;
            TxtSexo.TabIndex = 4;
            BtnFoto.TabIndex = 5;
            BtnIngresar.TabIndex = 6;
            BtnVer.TabIndex = 7;
            BtnModificar.TabIndex = 8;
            BtnEliminar.TabIndex = 9;
            BtnAyuda.TabIndex = 10;
            DgvDeportista.TabStop = false;

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
            int pageNumber = 37;

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
