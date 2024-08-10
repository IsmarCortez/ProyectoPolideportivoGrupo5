using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public partial class FormJugador : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private byte[] fotoBytes;
        private UsuarioValidator usuarioValidator;

        public FormJugador()
        {
            InitializeComponent();
            CargarEquipos();

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);

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
                CmbEquipo.ValueMember = "pkidequipo"; // Eliminar espacio adicional
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
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string posicion = TxtPosicion.Text;
            int numero;
            int.TryParse(TxtNumero.Text, out numero);
            string nacionalidad = TxtNacionalidad.Text;
            string titular = TxtTitular.Text;
            int goles;
            int.TryParse(TxtGoles.Text, out goles);
            int fkidequipo;
            //Solo permite texto
            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (apellido.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de apellido no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (posicion.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de posicion no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (nacionalidad.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de nacionalidad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(CmbEquipo.SelectedValue.ToString(), out fkidequipo))
            {
                DateTime fechaNacimiento = DtpFechaNacimiento.Value;

                Conexion conexion = new Conexion();

                MySqlConnection conn = conexion.getConexion();
                conn.Open();
                string query = "INSERT INTO jugador (nombre, apellido, posicion, numero, nacionalidad, titular, fotografia, fkidequipo, cantanotaciones, fechanacimiento) " +
                               "VALUES (@nombre, @apellido, @posicion, @numero, @nacionalidad, @titular, @fotografia, @fkidequipo, @cantanotaciones, @fechanacimiento)";

                try
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@posicion", posicion);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                    command.Parameters.AddWithValue("@titular", titular);
                    command.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value); // Insertar la imagen o NULL
                    command.Parameters.AddWithValue("@fkidequipo", fkidequipo);
                    command.Parameters.AddWithValue("@cantanotaciones", goles);
                    command.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        bitacora.RegistrarEvento("Ingresó un nuevo jugador", usuarioId);
                        MessageBox.Show("Jugador insertado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el jugador.");
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
            else
            {
                MessageBox.Show("Error al obtener el equipo seleccionado.");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            int idJugador;
            if (!int.TryParse(TxtId.Text, out idJugador))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string posicion = TxtPosicion.Text;
            int numero;
            int.TryParse(TxtNumero.Text, out numero);
            string nacionalidad = TxtNacionalidad.Text;
            string titular = TxtTitular.Text;
            int goles;
            int.TryParse(TxtGoles.Text, out goles);
            int fkidequipo;
            //Solo permite texto
            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de nombre no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (apellido.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de apellido no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (posicion.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de posicion no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Solo permite texto
            if (nacionalidad.Any(char.IsDigit))
            {
                MessageBox.Show("El texto de nacionalidad no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(CmbEquipo.SelectedValue.ToString(), out fkidequipo))
            {
                DateTime fechaNacimiento = DtpFechaNacimiento.Value;

                Conexion conexion = new Conexion();
                MySqlConnection conn = conexion.getConexion();
                conn.Open();

                string query = "UPDATE jugador SET nombre = @nombre, apellido = @apellido, posicion = @posicion, numero = @numero, " +
                               "nacionalidad = @nacionalidad, titular = @titular, fotografia = @fotografia, fkidequipo = @fkidequipo, " +
                               "cantanotaciones = @cantanotaciones, fechanacimiento = @fechanacimiento WHERE pkidjugador = @pkidjugador";

                try
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@posicion", posicion);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                    command.Parameters.AddWithValue("@titular", titular);
                    command.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value); // Insertar la imagen o NULL
                    command.Parameters.AddWithValue("@fkidequipo", fkidequipo);
                    command.Parameters.AddWithValue("@cantanotaciones", goles);
                    command.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);

                    command.Parameters.AddWithValue("@pkidjugador", idJugador);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        bitacora.RegistrarEvento("Modificó un jugador", usuarioId);
                        MessageBox.Show("Jugador modificado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el jugador. Verifique el ID.");
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
            else
            {
                MessageBox.Show("Error al obtener el equipo seleccionado.");
            }
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            int idJugador;
            if (!int.TryParse(TxtId.Text, out idJugador))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            conn.Open();

            string query = "DELETE FROM jugador WHERE pkidjugador = @pkidjugador";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidjugador", idJugador);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    bitacora.RegistrarEvento("Eliminó un jugador", usuarioId);
                    MessageBox.Show("Jugador eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el jugador. Verifique el ID.");
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


        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            conn.Open();

            string query;
            MySqlCommand command = new MySqlCommand();

            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                int idJugador;
                if (!int.TryParse(TxtId.Text, out idJugador))
                {
                    MessageBox.Show("ID inválido.");
                    return;
                }

                query = "SELECT pkidjugador, nombre, apellido, posicion, numero, nacionalidad, titular, cantanotaciones, fechanacimiento, fotografia " +
                        "FROM jugador WHERE pkidjugador = @pkidjugador";
                command.Parameters.AddWithValue("@pkidjugador", idJugador);
            }
            else
            {
                query = "SELECT pkidjugador, nombre, apellido, posicion, numero, nacionalidad, titular, cantanotaciones, fechanacimiento, fotografia " +
                        "FROM jugador";
            }

            try
            {
                command.Connection = conn;
                command.CommandText = query;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(TxtId.Text) && dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];
                        TxtNombre.Text = row["nombre"].ToString();
                        TxtApellido.Text = row["apellido"].ToString();
                        TxtPosicion.Text = row["posicion"].ToString();
                        TxtNumero.Text = row["numero"].ToString();
                        TxtNacionalidad.Text = row["nacionalidad"].ToString();
                        TxtTitular.Text = row["titular"].ToString();
                        TxtGoles.Text = row["cantanotaciones"].ToString();
                        DtpFechaNacimiento.Value = Convert.ToDateTime(row["fechanacimiento"]);

                        if (row["fotografia"] != DBNull.Value)
                        {
                            byte[] fotoBytes = (byte[])row["fotografia"];
                            using (MemoryStream ms = new MemoryStream(fotoBytes))
                            {
                                PicFotografia.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            PicFotografia.Image = null;
                        }
                    }
                    DgvFutbolista.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Jugador no encontrado.");
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


        private void BtnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                fotoBytes = File.ReadAllBytes(filePath); // Leer la imagen como bytes
                PicFotografia.Image = new Bitmap(filePath); // Mostrar la imagen en el PictureBox
                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void PicFotografia_Click(object sender, EventArgs e)
        {
            PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void TxtGoles_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPosicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = DgvFutbolista.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgvFutbolista.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = DgvFutbolista.CurrentRow.Cells[2].Value.ToString();
                TxtPosicion.Text = DgvFutbolista.CurrentRow.Cells[3].Value.ToString();
                TxtNumero.Text = DgvFutbolista.CurrentRow.Cells[4].Value.ToString();
                TxtNacionalidad.Text = DgvFutbolista.CurrentRow.Cells[5].Value.ToString();
                TxtTitular.Text = DgvFutbolista.CurrentRow.Cells[6].Value.ToString();
                TxtGoles.Text = DgvFutbolista.CurrentRow.Cells[7].Value.ToString();
                DtpFechaNacimiento.Text = DgvFutbolista.CurrentRow.Cells[8].Value.ToString();
                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
                if (e.RowIndex >= 0 && DgvFutbolista.Columns.Contains("fotografia"))
                {
                    DataGridViewRow row = DgvFutbolista.Rows[e.RowIndex];
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

        private void BtnSeleccionarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                fotoBytes = File.ReadAllBytes(filePath); // Leer la imagen como bytes
                PicFotografia.Image = new Bitmap(filePath); // Mostrar la imagen en el PictureBox
                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

 
        private void FormJugador_Load(object sender, EventArgs e)
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

            CmbEquipo.TabIndex = 0;
            TxtNombre.TabIndex = 1;
            TxtApellido.TabIndex = 2;
            DtpFechaNacimiento.TabIndex = 3;
            TxtPosicion.TabIndex = 4;
            TxtNumero.TabIndex = 5;
            TxtNacionalidad.TabIndex = 6;
            TxtTitular.TabIndex = 7;
            BtnSeleccionarFoto.TabIndex = 8;
            TxtGoles.TabIndex = 9;
            BtnIngresar.TabIndex = 10;
            BtnVer.TabIndex = 11;
            BtnModificar.TabIndex = 12;
            BtnEliminar.TabIndex = 13;
            BtnAyuda.TabIndex = 14;

            DgvFutbolista.TabStop = false;

            // DateTimePicker para la fecha de nacimiento
            DtpFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18); // Máximo 18 años antes de hoy
            DtpFechaNacimiento.MinDate = DateTime.Today.AddYears(-80); // Mínimo 80 años antes de hoy
            DtpFechaNacimiento.ValueChanged += DtpFechaNacimiento_ValueChanged;


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
            int pageNumber = 16;

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

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpFechaNacimiento.Value; DateTime minDate = DateTime.Today.AddYears(-80); DateTime maxDate = DateTime.Today.AddYears(-18); if (selectedDate < minDate || selectedDate > maxDate) { MessageBox.Show("Por favor, seleccione una fecha de nacimiento que esté dentro de los últimos 18 a 80 años.", "Fecha de nacimiento fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
