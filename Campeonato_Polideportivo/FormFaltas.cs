using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_Polideportivo
{
    public partial class FormFaltas : Form
    {
        public FormFaltas()
        {
            InitializeComponent();
            CargarPartidos();
            CargarArbitros();
            CargarTarjetas();
            CargarTipoFalta();
            CmbPartido.SelectedIndexChanged += CmbPartido_SelectedIndexChanged; //Para que salgan los dos equipos
            CmbEquipo.SelectedIndexChanged += CmbEquipo_SelectedIndexChanged; //Para que salgan los jugadores
            CmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;//para que no cambien el contenido
            CmbFalta.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbArbitro.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbJugador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarPartidos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_partido FROM partido";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbPartido.DataSource = dt;
                CmbPartido.DisplayMember = "id_partido";
                CmbPartido.ValueMember = "id_partido";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //CmbPartido.Text = "Selecciona un partido...";
        }

        private void CargarEquipos(string id_partido)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = @"
               SELECT 
                equipo_local.nombre AS NombreLocal,
                equipo_visitante.nombre AS NombreVisitante,

                equipo_local.id_equipo AS IdLocal,
   
                equipo_visitante.id_equipo AS IdVisitante
  
            FROM 
                partido
            JOIN 
                equipo AS equipo_local ON partido.equipo_local_id = equipo_local.id_equipo
            JOIN 
                equipo AS equipo_visitante ON partido.equipo_vis_id = equipo_visitante.id_equipo
            WHERE 
                partido.id_partido = @id_partido";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_partido", id_partido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configurar DataTable para equipos
                    DataTable equipos = new DataTable();
                    equipos.Columns.Add("id_equipo", typeof(int));
                    equipos.Columns.Add("nombre");

                    if (dt.Rows.Count > 0)
                    {
                        equipos.Rows.Add(dt.Rows[0]["IdLocal"], dt.Rows[0]["NombreLocal"].ToString());
                        equipos.Rows.Add(dt.Rows[0]["IdVisitante"], dt.Rows[0]["NombreVisitante"].ToString());
                    }

                    CmbEquipo.DataSource = equipos;
                    CmbEquipo.DisplayMember = "nombre";
                    CmbEquipo.ValueMember = "id_equipo"; // Puedes ajustar esto según tus necesidades
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
        private void CargarJugadores(string id_equipo)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_jugador, nombre, apellido FROM jugador WHERE id_equipo = @id_equipo";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_equipo", id_equipo);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron jugadores para el equipo seleccionado.");
                    }
                    dt.Columns.Add("nombreCompleto", typeof(string), "nombre + ' ' + apellido");

                    // Configurar ComboBox
                    CmbJugador.DataSource = dt;
                    CmbJugador.DisplayMember = "nombreCompleto";
                    CmbJugador.ValueMember = "id_jugador";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los jugadores: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CargarArbitros()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_arbitro, nombre, apellido FROM arbitro";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron arbitros.");
                }
                dt.Columns.Add("nombreCompleto", typeof(string), "nombre + ' ' + apellido");

                CmbArbitro.DataSource = dt;
                CmbArbitro.DisplayMember = "nombreCompleto";
                CmbArbitro.ValueMember = "id_arbitro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            CmbArbitro.Text = "Selecciona un arbitro...";
        }

        private void CmbPartido_SelectedIndexChanged(object sender, EventArgs e) //metodo para que al seleccionar un dato se muestre en el otro combobox
        {
            if (CmbPartido.SelectedValue != null) 
            {
                string id_partido = CmbPartido.SelectedValue.ToString();
                CargarEquipos(id_partido);
            }
            CmbEquipo.Enabled = true;
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEquipo.SelectedValue != null)
            {
                string id_equipo = CmbEquipo.SelectedValue.ToString();
                CargarJugadores(id_equipo);
            }
            CmbJugador.Enabled = true;
        }

        private void Limpiar()//metodo para limpiar todo el formulario al realizar alguna accion
        {
            TxtIdFaltas.Clear();
            TxtMinuto.Clear();
            CmbTarjeta.SelectedIndex = 0;
            CmbTarjeta.Text = "Seleccione una tarjeta...";
            CmbFalta.Text = "Seleccione un tipo de falta...";
            TxtDescripcion.Clear();
            DtpFecha.Value = DateTime.Now;
            CmbPartido.Text = "Seleccione un partido...";
            CmbEquipo.Text = "Seleccione un equipo...";
            CmbJugador.Text = "Seleccione un jugador...";
            CmbArbitro.Text = "Seleccione un arbitro...";
        }

        private void CargarTarjetas()
        {
            CmbTarjeta.Items.Add("Roja");
            CmbTarjeta.Items.Add("Amarilla");
        }

        private void CargarTipoFalta()
        {
            CmbFalta.Items.Add("Mano");
            CmbFalta.Items.Add("Fuera de Juego");
            CmbFalta.Items.Add("Empujon");
            CmbFalta.Items.Add("Entrada Peligrosa");
            CmbFalta.Items.Add("Agresion");
            CmbFalta.Items.Add("Simulacion");
            CmbFalta.Items.Add("Protesta");
            CmbFalta.Items.Add("Falta Personal");
            CmbFalta.Items.Add("Falta Tecnica");
            CmbFalta.Items.Add("Saque fuera de la linea");
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string Minuto = TxtMinuto.Text;
            string Tarjeta = CmbTarjeta.Text;
            string TipoFalta = CmbFalta.Text;
            string Descripcion = TxtDescripcion.Text;
            DateTime Fecha = DtpFecha.Value;
            int IdPartido = Convert.ToInt32(CmbPartido.SelectedValue);
            int IdJugador = Convert.ToInt32(CmbJugador.SelectedValue);
            int IdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO faltas (minuto, tarjeta, tipo_falta, descripcion, fecha, id_partido, id_jugador, id_arbitro) VALUES (@minuto, @tarjeta, @tipo_falta, @descripcion, @fecha, @id_partido, @id_jugador, @id_arbitro)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tarjeta", Tarjeta);
                        cmd.Parameters.AddWithValue("@tipo_falta", TipoFalta);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fecha", Fecha);
                        cmd.Parameters.AddWithValue("@id_partido", IdPartido);
                        cmd.Parameters.AddWithValue("@id_jugador", IdJugador);
                        cmd.Parameters.AddWithValue("@id_arbitro", IdArbitro);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
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
            Conexion conexion = new Conexion(); //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = @"
                       SELECT 
                        faltas.id_faltas AS ID,
                        faltas.minuto AS Minuto,
                        faltas.tarjeta AS Tarjeta,
                        faltas.tipo_falta AS Tipo,
                        faltas.descripcion AS Descripcion,
                        faltas.fecha AS Fecha,
                        faltas.id_partido AS Partido,
                        equipo.nombre AS Equipo,
                        CONCAT(jugador.nombre, ' ', jugador.apellido) AS Jugador,
                        CONCAT(arbitro.nombre, ' ', arbitro.apellido) AS Arbitro
                    FROM 
                        faltas
                    JOIN 
                        jugador ON faltas.id_jugador = jugador.id_jugador
                    JOIN 
                        arbitro ON faltas.id_arbitro = arbitro.id_arbitro
                    JOIN 
                        equipo ON jugador.id_equipo = equipo.id_equipo;";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvFaltas.DataSource = dt;
                    }
                }

                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DgvFaltas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdFaltas.Text = DgvFaltas.CurrentRow.Cells[0].Value.ToString();
                TxtMinuto.Text = DgvFaltas.CurrentRow.Cells[1].Value.ToString();
                CmbTarjeta.Text = DgvFaltas.CurrentRow.Cells[2].Value.ToString();
                CmbFalta.Text = DgvFaltas.CurrentRow.Cells[3].Value.ToString();
                TxtDescripcion.Text = DgvFaltas.CurrentRow.Cells[4].Value.ToString();
                DtpFecha.Text = DgvFaltas.CurrentRow.Cells[5].Value.ToString();
                CmbPartido.Text = DgvFaltas.CurrentRow.Cells[6].Value.ToString();
                CmbEquipo.Text = DgvFaltas.CurrentRow.Cells[7].Value.ToString();
                CmbJugador.Text = DgvFaltas.CurrentRow.Cells[8].Value.ToString();
                CmbArbitro.Text = DgvFaltas.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            try
            {
                // Obtener los datos de los TextBoxes
                string Minuto = TxtMinuto.Text;
                string Tarjeta = CmbTarjeta.Text;
                string TipoFalta = CmbFalta.Text;
                string Descripcion = TxtDescripcion.Text;
                DateTime Fecha = DtpFecha.Value;
                int IdPartido = Convert.ToInt32(CmbPartido.SelectedValue);
                int IdJugador = Convert.ToInt32(CmbJugador.SelectedValue);
                int IdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE faltas SET minuto = @minuto, tarjeta = @tarjeta, tipo_falta = @tipo_falta, descripcion = @descripcion, fecha = @fecha, id_partido = @id_partido, id_jugador = @id_jugador, id_arbitro = @id_arbitro WHERE id_faltas = @id_faltas";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@id_faltas", TxtIdFaltas.Text);
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tarjeta", Tarjeta);
                        cmd.Parameters.AddWithValue("@tipo_falta", TipoFalta);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fecha", Fecha);
                        cmd.Parameters.AddWithValue("@id_partido", IdPartido);
                        cmd.Parameters.AddWithValue("@id_jugador", IdJugador);
                        cmd.Parameters.AddWithValue("@id_arbitro", IdArbitro);

                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                // Obtener el id_entrenador del TextBox
                int id_faltas = int.Parse(TxtIdFaltas.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM faltas WHERE id_faltas = @id_faltas";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@id_faltas", id_faltas);

                        // Mostrar pregunta por si desea eliminar
                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
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
    }
}
