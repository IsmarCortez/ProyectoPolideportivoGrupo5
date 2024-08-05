using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public partial class FormAsistencia : Form
    {
        private Conexion FormConexion;
        private string connectionString;

        public FormAsistencia()
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

                CmbEquipo.SelectedIndexChanged += new EventHandler(CmbEquipo_SelectedIndexChanged);
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
            int jugadorId;
            if (!int.TryParse(TxtIdAsistencia.Text, out jugadorId))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            //string query = "SELECT pkidasistencia, minuto FROM asistencia WHERE fkidjugador = @fkidjugador";
            //string query = "SELECT pkidasistencia, minuto, fkidjugador FROM asistencia WHERE pkidasistencia = @pkidasistencia";
            string query = "SELECT a.pkidasistencia, a.minuto, j.apellido " +
                   "FROM asistencia a " +
                   "JOIN jugador j ON a.fkidjugador = j.pkidjugador " +
                   "WHERE a.pkidasistencia = @pkidasistencia";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidasistencia", jugadorId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DgvAsistencia.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros de asistencia.");
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

        public class UsuarioValidator
        {

            public string connectionString;

            public UsuarioValidator(string connectionString)
            {
                this.connectionString = connectionString;
            }
            public bool VerificarPermisosYPrivilegios(string usuario)
            {
                Conexion conexion = new Conexion();
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    string query = "SELECT fkpermisos, fkprivilegios FROM usuario WHERE usuario = @usuario";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int fkpermisos = reader.GetInt32("fkpermisos");
                                int fkprivilegios = reader.GetInt32("fkprivilegios");

                                // Verificar si ambos campos son iguales a 1
                                return fkpermisos == 1 && fkprivilegios == 1;
                            }
                        }
                    }
                }

                // Si no se encontró el usuario, o los valores no son ambos 1
                return false;
            }
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            CmbEquipo.Text = "Seleccione un equipo...";

            Conexion conexion = new Conexion();
            UsuarioValidator usuarioValidator = new UsuarioValidator(connectionString);

            string usuario = GlobalVariables.usuario; // Aquí debes obtener el ID del usuario que deseas verificar
            bool tienePermisosYPrivilegios = usuarioValidator.VerificarPermisosYPrivilegios(usuario);

            if (tienePermisosYPrivilegios)
            {
                // Permisos y privilegios son ambos igual a 1
                // Bloquear el botón BtnModificar
                BtnModificar.Visible = false;
                BtnEliminar.Visible = false;
            }
            else
            {
                // Permisos o privilegios no son ambos igual a 1
                BtnModificar.Visible = true;
                BtnEliminar.Visible = true;
            }
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEquipo.SelectedValue != null)
            {
                int equipoId;
                if (int.TryParse(CmbEquipo.SelectedValue.ToString(), out equipoId))
                {
                    CargarJugadores(equipoId);
                }
            }
        }

        private void CargarJugadores(int equipoId)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidjugador, apellido FROM jugador WHERE fkidequipo = @fkidequipo";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fkidequipo", equipoId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbJugador.DataSource = dt;
                CmbJugador.DisplayMember = "apellido";
                CmbJugador.ValueMember = "pkidjugador";
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
            string minuto = TxtMinuto.Text;
            int idJugador;

            if (!int.TryParse(CmbJugador.SelectedValue.ToString(), out idJugador))
            {
                MessageBox.Show("Jugador no seleccionado.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "INSERT INTO asistencia (minuto, fkidjugador) VALUES (@minuto, @fkidjugador)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@minuto", minuto);
                cmd.Parameters.AddWithValue("@fkidjugador", idJugador);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Asistencia registrada exitosamente.");
                    TxtIdAsistencia.Clear();
                    TxtMinuto.Clear();
                    CmbEquipo.Text = "Seleccione un equipo...";
                    CmbJugador.Text = "Seleccione un jugador...";
                }
                else
                {
                    MessageBox.Show("Error al registrar la asistencia.");
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
            string minuto = TxtMinuto.Text;
            int idAsistencia, idJugador;

            if (!int.TryParse(TxtIdAsistencia.Text, out idAsistencia))
            {
                MessageBox.Show("ID de asistencia inválido.");
                return;
            }

            if (!int.TryParse(CmbJugador.SelectedValue.ToString(), out idJugador))
            {
                MessageBox.Show("Jugador no seleccionado.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "UPDATE asistencia SET minuto = @minuto, fkidjugador = @fkidjugador WHERE pkidasistencia = @pkidasistencia";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@minuto", minuto);
                cmd.Parameters.AddWithValue("@fkidjugador", idJugador);
                cmd.Parameters.AddWithValue("@pkidasistencia", idAsistencia);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Asistencia modificada exitosamente.");
                    TxtIdAsistencia.Clear();
                    TxtMinuto.Clear();
                    CmbEquipo.Text = "Seleccione un equipo...";
                    CmbJugador.Text = "Seleccione un jugador...";
                }
                else
                {
                    MessageBox.Show("Error al modificar la asistencia.");
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
            int asistenciaId;
            if (!int.TryParse(TxtIdAsistencia.Text, out asistenciaId))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "DELETE FROM asistencia WHERE pkidasistencia = @pkidasistencia";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@pkidasistencia", asistenciaId);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Asistencia eliminada exitosamente.");
                    TxtIdAsistencia.Clear();
                    TxtMinuto.Clear();
                    CmbEquipo.Text = "Seleccione un equipo...";
                    CmbJugador.Text = "Seleccione un jugador...";
                }
                else
                {
                    MessageBox.Show("Error al eliminar la asistencia. Verifique el ID.");
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

        private void TxtIdAsistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
