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
        public FormArbitro()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            DateTime fechaNacimiento = TxtFechaNacimiento.Value; // Asumimos que el DateTimePicker se llama TxtFechaNacimiento
            string nacionalidad = TxtNacionalidad.Text;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "INSERT INTO arbitro (nombre, apellido, fechanacimiento, nacionalidad) " +
                           "VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad)";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@nacionalidad", nacionalidad);

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
            finally
            {
                conn.Close();
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

            string query = "DELETE FROM arbitro WHERE pkidarbitro = @id_arbitro";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_arbitro", idArbitro);

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
            int pkidarbitro;
            if (!int.TryParse(TxtId.Text, out pkidarbitro))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            DateTime fechaNacimiento = TxtFechaNacimiento.Value; // Asumimos que el DateTimePicker se llama TxtFechaNacimiento
            string nacionalidad = TxtNacionalidad.Text;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "UPDATE arbitro SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, " +
                           "nacionalidad = @nacionalidad WHERE pkidarbitro = @pkidarbitro";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                command.Parameters.AddWithValue("@pkidarbitro", pkidarbitro);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Árbitro modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al modificar el árbitro. Verifique el ID.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            int pkidarbitro;
            if (!int.TryParse(TxtId.Text, out pkidarbitro))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidarbitro, nombre, apellido, fechanacimiento, nacionalidad " +
                           "FROM arbitro WHERE pkidarbitro = @pkidarbitro";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidarbitro", pkidarbitro);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Árbitro no encontrado.");
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

    }
}
