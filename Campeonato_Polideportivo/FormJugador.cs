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
        private byte[] fotoBytes;

        public FormJugador()
        {
            InitializeComponent();
            CargarEquipos();
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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
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

                string query = "INSERT INTO jugador (nombre, apellido, posicion, numero, nacionalidad, titular, fotografia, fkidequipo, cantanotaciones, fecha_nacimiento) " +
                               "VALUES (@nombre, @apellido, @posicion, @numero, @nacionalidad, @titular, @fotografia, @fkidequipo, @cantanotaciones, @fecha_nacimiento)";

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
                    command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
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

                string query = "UPDATE jugador SET nombre = @nombre, apellido = @apellido, posicion = @posicion, numero = @numero, " +
                               "nacionalidad = @nacionalidad, titular = @titular, fotografia = @fotografia, fkidequipo = @fkidequipo, " +
                               "cantanotaciones = @cantanotaciones, fecha_nacimiento = @fecha_nacimiento WHERE pkidjugador = @pkidjugador";

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
                    command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@pkidjugador", idJugador);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
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
            int idJugador;
            if (!int.TryParse(TxtId.Text, out idJugador))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "DELETE FROM jugador WHERE pkidjugador = @pkidjugador";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidjugador", idJugador);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
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
            int idJugador;
            if (!int.TryParse(TxtId.Text, out idJugador))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidjugador, nombre, apellido, posicion, numero, nacionalidad, titular, cantanotaciones, fecha_nacimiento, fotografia " +
                           "FROM jugador WHERE pkidjugador = @pkidjugador";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidjugador", idJugador);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    TxtNombre.Text = row["nombre"].ToString();
                    TxtApellido.Text = row["apellido"].ToString();
                    TxtPosicion.Text = row["posicion"].ToString();
                    TxtNumero.Text = row["numero"].ToString();
                    TxtNacionalidad.Text = row["nacionalidad"].ToString();
                    TxtTitular.Text = row["titular"].ToString();
                    TxtGoles.Text = row["cantanotaciones"].ToString();
                    TxtFecha.Value = Convert.ToDateTime(row["fecha_nacimiento"]);

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
    }
}
