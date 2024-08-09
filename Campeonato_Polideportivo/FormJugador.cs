using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (int.TryParse(CmbEquipo.SelectedValue.ToString(), out fkidequipo))
            {
                DateTime fechaNacimiento = TxtFecha.Value;

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
            if (int.TryParse(CmbEquipo.SelectedValue.ToString(), out fkidequipo))
            {
                DateTime fechaNacimiento = TxtFecha.Value;

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
                        TxtFecha.Value = Convert.ToDateTime(row["fechanacimiento"]);

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
                    GridVer.DataSource = dt;
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
                TxtId.Text = GridVer.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = GridVer.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = GridVer.CurrentRow.Cells[2].Value.ToString();
                TxtPosicion.Text = GridVer.CurrentRow.Cells[3].Value.ToString();
                TxtNumero.Text = GridVer.CurrentRow.Cells[4].Value.ToString();
                TxtNacionalidad.Text = GridVer.CurrentRow.Cells[5].Value.ToString();
                TxtTitular.Text = GridVer.CurrentRow.Cells[6].Value.ToString();
                TxtGoles.Text = GridVer.CurrentRow.Cells[7].Value.ToString();
                TxtFecha.Text = GridVer.CurrentRow.Cells[8].Value.ToString();
                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
                if (e.RowIndex >= 0 && GridVer.Columns.Contains("fotografia"))
                {
                    DataGridViewRow row = GridVer.Rows[e.RowIndex];
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
        }
    }
}
