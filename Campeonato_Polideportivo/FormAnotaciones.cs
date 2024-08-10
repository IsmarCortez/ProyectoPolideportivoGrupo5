using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Diagnostics; // Para Process y ProcessStartInfo
using System.IO; // Para Path
// Código hecho por Kateryn De León 0901-21-4866
namespace Campeonato_Polideportivo
{
    public partial class FormAnotaciones : Form
    {
        private UsuarioValidator usuarioValidator;
        private Conexion FormConexion;
        private string connectionString;
        public FormAnotaciones()
        {
            InitializeComponent();
            // Desactivar manejadores de eventos
            CmbCampeonato.SelectedIndexChanged -= CmbCampeonato_SelectedIndexChanged;
            CmbPartido.SelectedIndexChanged -= CmbPartido_SelectedIndexChanged;
            CmbEquipo.SelectedIndexChanged -= CmbEquipo_SelectedIndexChanged;
            CargarCampeonatos();
            //CargarPartidos();
            CargarTipoAnotacion();
            CmbTipoAnotacion.DropDownStyle = ComboBoxStyle.DropDownList;//para que no cambien el contenido
            CmbAsistencia.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipoAnotacion.SelectedIndex = -1;
            CmbAsistencia.SelectedIndex = -1;
            CmbEquipo.SelectedIndex = -1;
            CmbPartido.SelectedIndex = -1;
            CmbJugador.SelectedIndex = -1;
            CmbCampeonato.SelectedIndex = -1;
            DgvJugs.Visible = false;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);

            // Reactivar manejadores de eventos
            CmbCampeonato.SelectedIndexChanged += CmbCampeonato_SelectedIndexChanged;
            CmbPartido.SelectedIndexChanged += CmbPartido_SelectedIndexChanged;
            CmbEquipo.SelectedIndexChanged += CmbEquipo_SelectedIndexChanged;
        }

        private void CargarTipoAnotacion()
        {
            //Basquet
            CmbTipoAnotacion.Items.Add("Punto");
            CmbTipoAnotacion.Items.Add("Bloqueo");
            CmbTipoAnotacion.Items.Add("Servicio");

            //Baseball
            CmbTipoAnotacion.Items.Add("Carrera");
            CmbTipoAnotacion.Items.Add("Home Run");
            CmbTipoAnotacion.Items.Add("Hit");

            //Futbol
            CmbTipoAnotacion.Items.Add("Gol");
            CmbTipoAnotacion.Items.Add("Asistencia");
            CmbTipoAnotacion.Items.Add("Penalti");

            //Basquetbal
            CmbTipoAnotacion.Items.Add("Canasta");
            CmbTipoAnotacion.Items.Add("Asistencia");
            CmbTipoAnotacion.Items.Add("Rebote");
        }

        private void CargarCampeonatos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidcampeonato, nombre FROM campeonato";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbCampeonato.DataSource = dt;
                CmbCampeonato.DisplayMember = "nombre";
                CmbCampeonato.ValueMember = "pkidcampeonato";

                // Configurar el ComboBox para que no tenga ningún elemento seleccionado inicialmente
                CmbCampeonato.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los campeonatos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CargarPartidos(int idCampeonato)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = @"
                SELECT 
                    p.pkidpartido,
                    CONCAT(el.nombre, ' vs ', ev.nombre) AS equipos
                FROM 
                    partido p
                JOIN 
                    equipo el ON p.fkequipolocalid = el.pkidequipo
                JOIN 
                    equipo ev ON p.fkequipovisid = ev.pkidequipo
                WHERE 
                    p.fkidcampeonato = @idCampeonato";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idCampeonato", idCampeonato);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    CmbPartido.DataSource = dt;
                    CmbPartido.DisplayMember = "equipos";
                    CmbPartido.ValueMember = "pkidpartido";

                    // Configurar el ComboBox para que no tenga ningún elemento seleccionado inicialmente
                    CmbPartido.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los partidos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CargarEquipos(string id_partido)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = @"
              SELECT 
                    equipo_local.nombre AS NombreLocal,
                    equipo_visitante.nombre AS NombreVisitante,
                    equipo_local.pkidequipo AS IdLocal,
                    equipo_visitante.pkidequipo AS IdVisitante
                FROM 
                    partido
                JOIN 
                    equipo AS equipo_local ON partido.fkequipolocalid = equipo_local.pkidequipo
                JOIN 
                    equipo AS equipo_visitante ON partido.fkequipovisid = equipo_visitante.pkidequipo
                WHERE 
                    partido.pkidpartido = @pkidpartido";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pkidpartido", id_partido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configurar DataTable para equipos
                    DataTable equipos = new DataTable();
                    equipos.Columns.Add("pkidequipo", typeof(int));
                    equipos.Columns.Add("nombre");

                    if (dt.Rows.Count > 0)
                    {
                        equipos.Rows.Add(dt.Rows[0]["IdLocal"], dt.Rows[0]["NombreLocal"].ToString());
                        equipos.Rows.Add(dt.Rows[0]["IdVisitante"], dt.Rows[0]["NombreVisitante"].ToString());
                    }

                    CmbEquipo.DataSource = equipos;
                    CmbEquipo.DisplayMember = "nombre";
                    CmbEquipo.ValueMember = "pkidequipo";

                    // Resetear ComboBox de jugadores
                    CmbJugador.DataSource = null;
                    CmbJugador.Enabled = false;
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

            string query = "SELECT pkidjugador, nombre, apellido FROM jugador WHERE fkidequipo = @fkidequipo";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fkidequipo", id_equipo);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        CmbJugador.DataSource = null;
                        CmbJugador.Enabled = false;
                        MessageBox.Show("No se encontraron jugadores para el equipo seleccionado.");
                    }
                    else
                    {
                        dt.Columns.Add("nombreCompleto", typeof(string), "nombre + ' ' + apellido");
                        CmbJugador.DataSource = dt;
                        CmbJugador.DisplayMember = "nombreCompleto";
                        CmbJugador.ValueMember = "pkidjugador";
                        CmbJugador.Enabled = true;
                    }

                    // Configurar ComboBox
                    /*CmbJugador.DataSource = dt;
                    CmbJugador.DisplayMember = "nombreCompleto";
                    CmbJugador.ValueMember = "pkidjugador";*/
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

        private void CargarAsistencias(string id_partido)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = @"
                SELECT a.pkidasistencia, CONCAT(j.nombre, ' ', j.apellido) AS asistencia
                FROM asistencia a
                INNER JOIN jugador j ON a.fkidjugador = j.pkidjugador
                INNER JOIN equipo e ON j.fkidequipo = e.pkidequipo
                INNER JOIN partido p ON (p.fkequipolocalid = e.pkidequipo OR p.fkequipovisid = e.pkidequipo)
                WHERE p.pkidpartido = @pkidpartido";

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pkidpartido", id_partido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    CmbAsistencia.DataSource = dt;
                    CmbAsistencia.DisplayMember = "asistencia";
                    CmbAsistencia.ValueMember = "pkidasistencia";

                    // Configurar el ComboBox para que no tenga ningún elemento seleccionado inicialmente
                    CmbAsistencia.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las asistencias: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
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
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            try
            {
                
                // Datos de entrada del usuario
                string Minuto = TxtMinuto.Text;
                string tipoAnotacion = CmbTipoAnotacion.Text;
                int IdPartido = Convert.ToInt32(CmbPartido.SelectedValue);
                int IdJugador = Convert.ToInt32(CmbJugador.SelectedValue);
                int IdAsistencia = Convert.ToInt32(CmbAsistencia.SelectedValue);
                string Descripcion = TxtDescripcion.Text;

                //Solo permitie digitos
                if (!Minuto.All(char.IsDigit))
                {
                    MessageBox.Show("El texto de minutos solo debe contener números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Solo permite texto
                if (Descripcion.Any(char.IsDigit))
                {
                    MessageBox.Show("El texto de descripcion no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conexión a la base de datos
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open(); // Abrimos la conexión
                    // Consulta SQL para insertar datos
                    string query = "INSERT INTO anotaciones (minuto, tipoanotacion, fkidpartido, fkidjugador, fkidasistencia, descripcion) " +
                                   "VALUES (@minuto, @tipoanotacion, @fkidpartido, @fkidjugador, @fkidasistencia, @descripcion)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros con sus respectivos valores
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tipoanotacion", tipoAnotacion);
                        cmd.Parameters.AddWithValue("@fkidpartido", IdPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", IdJugador);
                        cmd.Parameters.AddWithValue("@fkidasistencia", IdAsistencia);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        bitacora.RegistrarEvento("Ingresó una nueva anotación", usuarioId);
                        MessageBox.Show("Datos ingresados correctamente.");

                    }
                }
                // Habilitar el TextBox del ID de anotaciones para permitir futuras modificaciones
                TxtIdAnotaciones.Enabled = true;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {

        }

     
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();  // Conexión a la base de datos
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            try
            {
                usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
                // Variables
                string Minuto = TxtMinuto.Text;
                string tipoAnotacion = CmbTipoAnotacion.Text;
                int IdPartido = Convert.ToInt32(CmbPartido.SelectedValue);
                int IdJugador = Convert.ToInt32(CmbJugador.SelectedValue);
                int IdAsistencia = Convert.ToInt32(CmbAsistencia.SelectedValue);
                string Descripcion = TxtDescripcion.Text;
                if (!Minuto.All(char.IsDigit))
                {
                    MessageBox.Show("El texto solo debe contener números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Descripcion.Any(char.IsDigit))
                {
                    MessageBox.Show("El texto no puede contener números. Por favor, ingrese solo letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conexión a la base de datos
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open(); // Abrimos la conexión
                    // Consulta para modificar datos o actualizar
                    string query = "UPDATE anotaciones SET minuto = @minuto, tipoanotacion = @tipoanotacion, descripcion = @descripcion, " +
                                   "fkidpartido = @fkidpartido, fkidjugador = @fkidjugador, fkidasistencia = @fkidasistencia " +
                                   "WHERE pkidanotaciones = @pkidanotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@pkidanotaciones", TxtIdAnotaciones.Text);
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tipoanotacion", tipoAnotacion);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fkidpartido", IdPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", IdJugador);
                        cmd.Parameters.AddWithValue("@fkidasistencia", IdAsistencia);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mensaje de datos modificados correctamente
                            bitacora.RegistrarEvento("Modificó una anotación", usuarioId);
                            MessageBox.Show("Datos modificados correctamente.");
                        }
                        else
                        {
                            // Mensaje si no se encontró el ID
                            MessageBox.Show("No se encontró la anotación con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

      private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;

            try
            {
                // Obtener el ID de la anotación a eliminar
                int pkidAnotaciones = int.Parse(TxtIdAnotaciones.Text);

                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open(); // Abrimos la conexión
                    // Consulta SQL para eliminar la anotación
                    string query = "DELETE FROM anotaciones WHERE pkidanotaciones = @pkidanotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
                        // Agregar el parámetro con su valor
                        cmd.Parameters.AddWithValue("@pkidanotaciones", pkidAnotaciones);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mensaje de datos eliminados correctamente
                            bitacora.RegistrarEvento("Eliminó una anotación", usuarioId);
                            MessageBox.Show("Datos eliminados correctamente.");
                        }
                        else
                        {
                            // Mensaje si no se encontró el ID
                            MessageBox.Show("No se encontró la anotación con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {   // conexion BD
            Conexion conexion = new Conexion();
            DgvJugs.Visible = false;

            try
            {
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM anotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DgvAnotaciones.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            { // mesnaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

       
        

        private void FormAnotaciones_Load(object sender, EventArgs e)
        {
            TxtIdAnotaciones.TabIndex = 0;
            TxtMinuto.TabIndex = 1;
            CmbTipoAnotacion.TabIndex = 2;
            CmbCampeonato.TabIndex = 3;
            CmbPartido.TabIndex = 4;
            CmbEquipo.TabIndex = 5;
            CmbJugador.TabIndex = 6;
            CmbAsistencia.TabIndex = 7;
            TxtDescripcion.TabIndex = 8;


            BtnIngresar.TabIndex = 9;
            BtnVer.TabIndex = 10;
            BtnLimpiar.TabIndex = 11;
            BtnModificar.TabIndex = 12;
            BtnEliminar.TabIndex = 13;

            BtnTablaMejoresJugs.TabIndex = 14;
            BtnAyuda.TabIndex = 15;

            DgvAnotaciones.TabStop = false;


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
                TxtIdAnotaciones.Enabled = false;
                TxtMinuto.Enabled = false;
                CmbTipoAnotacion.Enabled = false;
                CmbCampeonato.Enabled = false;
                CmbPartido.Enabled = false;
                CmbEquipo.Enabled = false;
                CmbJugador.Enabled = false;
                CmbAsistencia.Enabled = false;
                TxtDescripcion.Enabled = false;
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            TxtIdAnotaciones.Text = string.Empty;
            TxtMinuto.Text = string.Empty;
            TxtTipodeAnotacion.Text = string.Empty;
            TxtIdPartido.Text = string.Empty;
            TxtIdJugador.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            
        }

        private void CmbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCampeonato.SelectedValue != null)
            {
                int idCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
                CargarPartidos(idCampeonato);
                CmbPartido.Enabled = true;

                // Resetear y deshabilitar los ComboBox dependientes
                CmbEquipo.DataSource = null;
                CmbEquipo.Enabled = false;
                CmbJugador.DataSource = null;
                CmbJugador.Enabled = false;
                CmbAsistencia.DataSource = null;
                CmbAsistencia.Enabled = false;
            }
            else
            {
                ResetearComboBoxes();
            }
        }
        private void ResetearComboBoxes()
        {
            CmbPartido.DataSource = null;
            CmbPartido.Enabled = false;
            CmbEquipo.DataSource = null;
            CmbEquipo.Enabled = false;
            CmbJugador.DataSource = null;
            CmbJugador.Enabled = false;
            CmbAsistencia.DataSource = null;
            CmbAsistencia.Enabled = false;
        }

        private void CmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPartido.SelectedValue != null && CmbPartido.SelectedIndex != -1)
            {
                string idPartido = CmbPartido.SelectedValue.ToString();
                CargarEquipos(idPartido);
                CargarAsistencias(idPartido);
                CmbEquipo.Enabled = true;

                // Resetear ComboBox de jugadores y asistencias
                CmbJugador.DataSource = null;
                CmbJugador.Enabled = false;
                /*CmbAsistencia.DataSource = null;
                CmbAsistencia.Enabled = false;*/
            }
            else
            {
                ResetearComboBoxesDependientes();
            }
        }
        private void ResetearComboBoxesDependientes()
        {
            CmbEquipo.DataSource = null;
            CmbEquipo.Enabled = false;
            CmbJugador.DataSource = null;
            CmbJugador.Enabled = false;
            CmbAsistencia.DataSource = null;
            CmbAsistencia.Enabled = false;
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEquipo.SelectedValue != null && CmbEquipo.SelectedIndex != -1)
            {
                string idEquipo = CmbEquipo.SelectedValue.ToString();
                CargarJugadores(idEquipo);
                CmbJugador.Enabled = true;
                CmbAsistencia.Enabled = true;
            }
            else
            {
                CmbJugador.DataSource = null;
                CmbJugador.Enabled = false;
                CmbAsistencia.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdAnotaciones.Text = DgvAnotaciones.CurrentRow.Cells[0].Value.ToString();
                TxtMinuto.Text = DgvAnotaciones.CurrentRow.Cells[1].Value.ToString();
                CmbTipoAnotacion.Text = DgvAnotaciones.CurrentRow.Cells[2].Value.ToString();
                CmbPartido.Text = DgvAnotaciones.CurrentRow.Cells[3].Value.ToString();
                CmbJugador.Text = DgvAnotaciones.CurrentRow.Cells[4].Value.ToString();
                CmbAsistencia.Text = DgvAnotaciones.CurrentRow.Cells[5].Value.ToString();
                TxtDescripcion.Text = DgvAnotaciones.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
            }
        }

        private void CmbJugador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnTablaMejoresJugs_Click(object sender, EventArgs e)
        {
            if (CmbCampeonato.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un campeonato.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DgvAnotaciones.Visible = false;
            DgvJugs.Visible = true;

            Conexion conexion = new Conexion();

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    //string query = "SELECT * FROM vista_clasificacion WHERE fkidcampeonato = @fkidcampeonato";
                    string query = "SELECT* FROM vista_goleadores_campeonato WHERE pkidcampeonato = @pkidcampeonato";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@pkidcampeonato", FkIdCampeonato);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DgvJugs.DataSource = dataTable;
                        }
                    }

                    // Opcional: Ajustar el ancho de las columnas
                    DgvJugs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la clasificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            int pageNumber = 82;

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