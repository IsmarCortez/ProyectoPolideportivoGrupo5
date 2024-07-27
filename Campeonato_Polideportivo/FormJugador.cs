using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public partial class FormJugador : Form
    {
        public FormJugador()
        {
            InitializeComponent();
            CargarEquipos(); // Llamar al método para cargar los equipos
        }

        private void CargarEquipos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_equipo, nombre FROM equipo";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbEquipo.DataSource = dt;
                CmbEquipo.DisplayMember = "nombre";
                CmbEquipo.ValueMember = "id_equipo";
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
            int equipoId = Convert.ToInt32(CmbEquipo.SelectedValue);

            DateTime fechaNacimiento;
            DateTime.TryParse(TxtFecha.Text, out fechaNacimiento); // Intentar convertir la fecha desde el texto

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "INSERT INTO jugador (nombre, apellido, posicion, numero, nacionalidad, titular, fotografia, id_equipo, cant_goles, fecha_nacimiento) " +
                           "VALUES (@nombre, @apellido, @posicion, @numero, @nacionalidad, @titular, @fotografia, @id_equipo, @cant_goles, @fecha_nacimiento)";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@posicion", posicion);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                command.Parameters.AddWithValue("@titular", titular);
                command.Parameters.AddWithValue("@fotografia", DBNull.Value); // Fotografía se deja en NULL por ahora
                command.Parameters.AddWithValue("@id_equipo", equipoId);
                command.Parameters.AddWithValue("@cant_goles", goles);
                command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento == DateTime.MinValue ? (object)DBNull.Value : fechaNacimiento);

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
            int equipoId = Convert.ToInt32(CmbEquipo.SelectedValue);

            DateTime fechaNacimiento;
            DateTime.TryParse(TxtFecha.Text, out fechaNacimiento); // Intentar convertir la fecha desde el texto

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "UPDATE jugador SET nombre = @nombre, apellido = @apellido, posicion = @posicion, numero = @numero, " +
                           "nacionalidad = @nacionalidad, titular = @titular, fotografia = @fotografia, id_equipo = @id_equipo, " +
                           "cant_goles = @cant_goles, fecha_nacimiento = @fecha_nacimiento WHERE id_jugador = @id_jugador";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@posicion", posicion);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                command.Parameters.AddWithValue("@titular", titular);
                command.Parameters.AddWithValue("@fotografia", DBNull.Value); // Fotografía se deja en NULL por ahora
                command.Parameters.AddWithValue("@id_equipo", equipoId);
                command.Parameters.AddWithValue("@cant_goles", goles);
                command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento == DateTime.MinValue ? (object)DBNull.Value : fechaNacimiento);
                command.Parameters.AddWithValue("@id_jugador", idJugador);

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

            string query = "DELETE FROM jugador WHERE id_jugador = @id_jugador";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_jugador", idJugador);

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

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            string query = "SELECT id_jugador, nombre, apellido, posicion, numero, nacionalidad, titular, cant_goles, fecha_nacimiento " +
                           "FROM jugador WHERE id_jugador = @id_jugador";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@id_jugador", idJugador);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridVer.DataSource = dt;
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
