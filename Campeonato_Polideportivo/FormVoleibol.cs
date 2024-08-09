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

namespace Campeonato_Polideportivo
{
    public partial class FormVoleibol : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormVoleibol()
        {
            InitializeComponent();

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);

            CargarEquiposVoleibol(); // Cargan los equipos unicamente de VOLEIBOL o los que no tengan asignación en PARTIDOS
            CargarEstadoPartido();
            CargarGanadorEmpate();
            CargarCampeonato();
            CargarFase();
            CargarArbitros();
            CmbEstadoPartido.DropDownStyle = ComboBoxStyle.DropDownList;//para que no cambien el contenido
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGanadorEmpate.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFase.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbArbitro.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoLocal.SelectedIndexChanged += new EventHandler(CmbEquipoLocal_SelectedIndexChanged);
            Limpiar();
        }

        private void FormVoleibol_Load(object sender, EventArgs e)
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

        private DataTable equiposVoleibol;

        private void CargarEquiposVoleibol()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            string query = @"
                SELECT DISTINCT e.pkidequipo, e.nombre 
                FROM equipo e
                LEFT JOIN partido p ON e.pkidequipo = p.fkequipolocalid OR e.pkidequipo = p.fkequipovisid
                LEFT JOIN campeonato c ON p.fkidcampeonato = c.pkidcampeonato
                LEFT JOIN deporte d ON c.fkiddeporte = d.pkiddeporte
                WHERE d.nombre = 'Voleibol' OR d.nombre IS NULL
                ORDER BY e.nombre";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                equiposVoleibol = new DataTable();
                adapter.Fill(equiposVoleibol);

                CargarEquiposLocal();
                CargarEquiposVisitante();
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

        private void CargarEquiposLocal()
        {
            CmbEquipoLocal.DataSource = equiposVoleibol;
            CmbEquipoLocal.DisplayMember = "nombre";
            CmbEquipoLocal.ValueMember = "pkidequipo";
        }

        private void CargarEquiposVisitante()
        {
            if (equiposVoleibol == null) return;

            DataTable dtVisitante = equiposVoleibol.Clone();
            foreach (DataRow row in equiposVoleibol.Rows)
            {
                if (CmbEquipoLocal.SelectedValue == null || row["pkidequipo"].ToString() != CmbEquipoLocal.SelectedValue.ToString())
                {
                    dtVisitante.Rows.Add(row.ItemArray);
                }
            }

            CmbEquipoVisitante.DataSource = dtVisitante;
            CmbEquipoVisitante.DisplayMember = "nombre";
            CmbEquipoVisitante.ValueMember = "pkidequipo";
        }

        private void CmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquiposVisitante(); //Los carga despues de seleccionar los locales para que no se repitan
        }

        private void CargarEstadoPartido() //Coloca los respectivos estados del partido
        {
            CmbEstadoPartido.Items.Add("Pendiente");
            CmbEstadoPartido.Items.Add("En Curso");
            CmbEstadoPartido.Items.Add("Suspendido");
            CmbEstadoPartido.Items.Add("Finalizado");
            CmbEstadoPartido.Items.Add("Cancelado");
        }

        private void CargarGanadorEmpate() //Para verificar que equipo gano o empato
        {
            CmbGanadorEmpate.Items.Add(new { Valor = 'V', Texto = "Ganador Equipo Local" });
            CmbGanadorEmpate.Items.Add(new { Valor = 'V', Texto = "Ganador Equipo Visitante" });
            CmbGanadorEmpate.Items.Add(new { Valor = 'V', Texto = "Empate" });
            CmbGanadorEmpate.DisplayMember = "Texto";
            CmbGanadorEmpate.ValueMember = "Valor";
        }

        private void CargarCampeonato()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            string query = @"
                SELECT c.pkidcampeonato, c.nombre 
                FROM campeonato c
                JOIN deporte d ON c.fkiddeporte = d.pkiddeporte
                WHERE d.nombre = 'Voleibol'
                ORDER BY c.nombre";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CmbCampeonato.DataSource = dt;
                CmbCampeonato.DisplayMember = "nombre";
                CmbCampeonato.ValueMember = "pkidcampeonato";

                // Si no hay campeonatos, mostrar mensaje
                if (dt.Rows.Count == 0) // Solo está la fila "Seleccionar campeonato"
                {
                    MessageBox.Show("No hay campeonatos de voleibol registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los campeonatos de voleibol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CargarFase()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidfase, fase FROM fase";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbFase.DataSource = dt;
                CmbFase.DisplayMember = "fase";
                CmbFase.ValueMember = "pkidfase";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error con fases: " + ex.Message);
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

            string query = "SELECT pkidarbitro, nombre, apellido FROM arbitro";

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
                CmbArbitro.ValueMember = "pkidarbitro";
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

        private void Limpiar()//metodo para limpiar todo el formulario al realizar alguna accion
        {
            TxtIdPartido.Clear();
            TxtIdVolley.Clear();
            DtpFecha.Value = DateTime.Now;
            CmbEstadoPartido.SelectedIndex = -1;
            CmbGanadorEmpate.SelectedIndex = -1;
            CmbCampeonato.SelectedIndex = -1;
            CmbFase.SelectedIndex = -1;
            CmbArbitro.SelectedIndex = -1;
            CmbEquipoLocal.SelectedIndex = -1;
            CmbEquipoVisitante.SelectedIndex = -1;
            NudSetsLocal.Value = 0;
            NudPuntosLocal.Value = 0;
            NudAtaquesLocal.Value = 0;
            NudBloqueosLocal.Value = 0;
            NudServiciosErradosLocal.Value = 0;
            NudRecepcionesLocal.Value = 0;
            NudDefensaLocal.Value = 0;
            NudAcesLocal.Value = 0;
            NudSetsVisitante.Value = 0;
            NudPuntosVisitante.Value = 0;
            NudAtaquesVisitante.Value = 0;
            NudBloqueosVisitante.Value = 0;
            NudServiciosErradosVisitante.Value = 0;
            NudRecepcionesVisitante.Value = 0;
            NudDefensaVisitante.Value = 0;
            NudAcesVisitante.Value = 0;
            /*CmbGanadorEmpate.Enabled = false;
            CmbFase.Enabled = false;
            CmbArbitro.Enabled = false;*/
        }

        private void CamposVacios()
        {
            if (CmbEstadoPartido.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un estado del partido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbGanadorEmpate.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un ganador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbCampeonato.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un campeonato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbFase.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una fase", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbArbitro.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un arbitro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbEquipoLocal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbEquipoVisitante.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            Conexion conexion = new Conexion();

            //Obtenemos los datos del form y declaramos variables
            //Partido
            DateTime Fecha = DtpFecha.Value;
            int FkIdEquipoLocalId = Convert.ToInt32(CmbEquipoLocal.SelectedValue);
            int FkIdEquipoVisId = Convert.ToInt32(CmbEquipoVisitante.SelectedValue);
            string EstadoPartido = CmbEstadoPartido.Text;
            char Ganador = 'V'; // Siempre será 'V'
            int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
            int FkIdFase = Convert.ToInt32(CmbFase.SelectedValue);
            int FkIdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);
            //Volley Local
            int SetsLocal = Convert.ToInt32(NudSetsLocal.Value);
            int PuntosLocal = Convert.ToInt32(NudPuntosLocal.Value);
            int AtaquesLocal = Convert.ToInt32(NudAtaquesLocal.Value);
            int BloqueosLocal = Convert.ToInt32(NudBloqueosLocal.Value);
            int ServiciosErradosLocal = Convert.ToInt32(NudServiciosErradosLocal.Value);
            int RecepcionesLocal = Convert.ToInt32(NudRecepcionesLocal.Value);
            int DefensaLocal = Convert.ToInt32(NudDefensaLocal.Value);
            int AcesLocal = Convert.ToInt32(NudAcesLocal.Value);
            //Basquet Visitante
            int SetsVisitante = Convert.ToInt32(NudSetsVisitante.Value);
            int PuntosVisitante = Convert.ToInt32(NudPuntosVisitante.Value);
            int AtaquesVisitante = Convert.ToInt32(NudAtaquesVisitante.Value);
            int BloqueosVisitante = Convert.ToInt32(NudBloqueosVisitante.Value);
            int ServiciosErradosVisitante = Convert.ToInt32(NudServiciosErradosVisitante.Value);
            int RecepcionesVisitante = Convert.ToInt32(NudRecepcionesVisitante.Value);
            int DefensaVisitante = Convert.ToInt32(NudDefensaVisitante.Value);
            int AcesVisitante = Convert.ToInt32(NudAcesVisitante.Value);

            CamposVacios();

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                
                try
                {
                    if (CmbGanadorEmpate.SelectedIndex == 0)
                    {
                        // SQL insertar datos en partido
                        string query = $@"INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, ganadorlocal, fkidcampeonato, fkidfase, fkidarbitro) 
                              VALUES (@fechahora, @fkequipolocalid, @fkequipovisid, @estadopartido, @ganadorlocal, @fkidcampeonato, @fkidfase, @fkidarbitro);
                              SELECT LAST_INSERT_ID();";
                        int FkIdPartido;
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);

                            // Ejecutar el comando para que se obtenga el ID antes de realizar la otra inserción de datos
                            FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());


                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en volley
                        string querypartido = @"INSERT INTO volleyball (setsganadosequipolocal, setsganadosequipovisitante, puntostotalesequipol, puntostotalesequipovi, ataquesequipolocal, ataquesequipovisitante, bloqueosequipolocal, bloqueosequipovisitante, servicioserradoslocal, servicioserradosvis, recepcionesequipolocal, recepcionesequipovisitante, defensasequipolocal, defensasequipovisitante, acesequipolocal, acesequipovisitante, fkidpartido) 
                                                               VALUES (@setsganadosequipolocal, @setsganadosequipovisitante, @puntostotalesequipol, @puntostotalesequipovi, @ataquesequipolocal, @ataquesequipovisitante, @bloqueosequipolocal, @bloqueosequipovisitante, @servicioserradoslocal, @servicioserradosvis, @recepcionesequipolocal, @recepcionesequipovisitante, @defensasequipolocal, @defensasequipovisitante, @acesequipolocal, @acesequipovisitante, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                            cmd.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                            cmd.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                            cmd.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                            cmd.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                            cmd.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                            cmd.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                            cmd.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                            cmd.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                            cmd.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                            cmd.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                            cmd.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                            cmd.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                            cmd.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                            cmd.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                            cmd.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a voleibol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Limpiar();
                        string callProcedure = "CALL actualizar_clasificacion(@ultimo_partido);";
                        using (MySqlCommand procCmd = new MySqlCommand(callProcedure, conn, transaction))
                        {
                            procCmd.Parameters.AddWithValue("@ultimo_partido", FkIdPartido);
                            procCmd.ExecuteNonQuery();
                        }
                        // Confirmar la transacción
                        transaction.Commit();
                    }

                    if (CmbGanadorEmpate.SelectedIndex == 1)
                    {
                        // SQL insertar datos en partido
                        string query = $@"INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, ganadorvisitante, fkidcampeonato, fkidfase, fkidarbitro) 
                              VALUES (@fechahora, @fkequipolocalid, @fkequipovisid, @estadopartido, @ganadorlocal, @fkidcampeonato, @fkidfase, @fkidarbitro);
                              SELECT LAST_INSERT_ID();";
                        int FkIdPartido;
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);

                            // Ejecutar el comando
                            FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en baseball
                        string querypartido = @"INSERT INTO volleyball (setsganadosequipolocal, setsganadosequipovisitante, puntostotalesequipol, puntostotalesequipovi, ataquesequipolocal, ataquesequipovisitante, bloqueosequipolocal, bloqueosequipovisitante, servicioserradoslocal, servicioserradosvis, recepcionesequipolocal, recepcionesequipovisitante, defensasequipolocal, defensasequipovisitante, acesequipolocal, acesequipovisitante, fkidpartido) 
                                                               VALUES (@setsganadosequipolocal, @setsganadosequipovisitante, @puntostotalesequipol, @puntostotalesequipovi, @ataquesequipolocal, @ataquesequipovisitante, @bloqueosequipolocal, @bloqueosequipovisitante, @servicioserradoslocal, @servicioserradosvis, @recepcionesequipolocal, @recepcionesequipovisitante, @defensasequipolocal, @defensasequipovisitante, @acesequipolocal, @acesequipovisitante, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                            cmd.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                            cmd.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                            cmd.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                            cmd.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                            cmd.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                            cmd.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                            cmd.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                            cmd.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                            cmd.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                            cmd.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                            cmd.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                            cmd.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                            cmd.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                            cmd.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                            cmd.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a voleibol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Limpiar();
                        string callProcedure = "CALL actualizar_clasificacion(@ultimo_partido);";
                        using (MySqlCommand procCmd = new MySqlCommand(callProcedure, conn, transaction))
                        {
                            procCmd.Parameters.AddWithValue("@ultimo_partido", FkIdPartido);
                            procCmd.ExecuteNonQuery();
                        }
                        // Confirmar la transacción
                        transaction.Commit();
                    }

                    if (CmbGanadorEmpate.SelectedIndex == 2)
                    {
                        // SQL insertar datos en partido
                        string query = $@"INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, empate, fkidcampeonato, fkidfase, fkidarbitro) 
                              VALUES (@fechahora, @fkequipolocalid, @fkequipovisid, @estadopartido, @ganadorlocal, @fkidcampeonato, @fkidfase, @fkidarbitro);
                              SELECT LAST_INSERT_ID();";
                        // Crear el comando
                        int FkIdPartido;
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);

                            // Ejecutar el comando
                            FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en baseball
                        string querypartido = @"INSERT INTO volleyball (setsganadosequipolocal, setsganadosequipovisitante, puntostotalesequipol, puntostotalesequipovi, ataquesequipolocal, ataquesequipovisitante, bloqueosequipolocal, bloqueosequipovisitante, servicioserradoslocal, servicioserradosvis, recepcionesequipolocal, recepcionesequipovisitante, defensasequipolocal, defensasequipovisitante, acesequipolocal, acesequipovisitante, fkidpartido) 
                                                               VALUES (@setsganadosequipolocal, @setsganadosequipovisitante, @puntostotalesequipol, @puntostotalesequipovi, @ataquesequipolocal, @ataquesequipovisitante, @bloqueosequipolocal, @bloqueosequipovisitante, @servicioserradoslocal, @servicioserradosvis, @recepcionesequipolocal, @recepcionesequipovisitante, @defensasequipolocal, @defensasequipovisitante, @acesequipolocal, @acesequipovisitante, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                            cmd.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                            cmd.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                            cmd.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                            cmd.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                            cmd.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                            cmd.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                            cmd.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                            cmd.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                            cmd.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                            cmd.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                            cmd.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                            cmd.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                            cmd.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                            cmd.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                            cmd.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de voleyball", usuarioId);
                            MessageBox.Show("Datos ingresados a voleibol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Limpiar();
                        string callProcedure = "CALL actualizar_clasificacion(@ultimo_partido);";
                        using (MySqlCommand procCmd = new MySqlCommand(callProcedure, conn, transaction))
                        {
                            procCmd.Parameters.AddWithValue("@ultimo_partido", FkIdPartido);
                            procCmd.ExecuteNonQuery();
                        }
                        // Confirmar la transacción
                        transaction.Commit();
                    }

                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    // Mostrar mensaje de error
                    MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpiar();
            }

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            //DgvClasificacion.Visible = false;
            DgvVoleibol.Visible = true;
            Conexion conexion = new Conexion(); //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = @"
                      SELECT 
                        partido.pkidpartido AS IDPartido,
                        partido.fechahora AS Fecha,
                        el.nombre AS EquipoLocal,
                        ev.nombre AS EquipoVisitante,
                        c.nombre AS Campeonato,
                        fase.fase AS Fase,
                        CONCAT(a.nombre, ' ', a.apellido) AS Arbitro,
                        partido.estadopartido AS EstadoPartido,
                        partido.ganadorlocal AS GanadorLocal,
                        partido.ganadorvisitante AS GanadorVisitante,
                        partido.empate AS Empate,
                        v.setsganadosequipolocal AS SetsGanadosLocal,
                        v.setsganadosequipovisitante AS SetsGanadosVisitante,
                        v.puntostotalesequipol AS PuntosTotalesLocal,
                        v.puntostotalesequipovi AS PuntosTotalesVisitante,
                        v.ataquesequipolocal AS AtaquesLocal,
                        v.ataquesequipovisitante AS AtaquesVisitante,
                        v.bloqueosequipolocal AS BloqueosLocal,
                        v.bloqueosequipovisitante AS BloqueosVisitante,
                        v.servicioserradoslocal AS ServiciosErradosLocal,
                        v.servicioserradosvis AS ServiciosErradosVisitante,
                        v.recepcionesequipolocal AS RecepcionesLocal,
                        v.recepcionesequipovisitante AS RecepcionesVisitante,
                        v.defensasequipolocal AS DefensasLocal,
                        v.defensasequipovisitante AS DefensasVisitante,
                        v.acesequipolocal AS AsesLocal,
                        v.acesequipovisitante AS AsesVisitante,
                        v.pkidvolleyball AS IDVolleyball
                    FROM 
                        partido
                    JOIN 
                        equipo el ON partido.fkequipolocalid = el.pkidequipo
                    JOIN 
                        equipo ev ON partido.fkequipovisid = ev.pkidequipo
                    JOIN 
                        campeonato c ON partido.fkidcampeonato = c.pkidcampeonato
                    JOIN 
                        fase ON fase.pkidfase = partido.fkidfase
                    JOIN 
                        arbitro a ON partido.fkidarbitro = a.pkidarbitro
                    LEFT JOIN 
                        volleyball v ON partido.pkidpartido = v.fkidpartido
                    JOIN 
                        deporte d ON c.fkiddeporte = d.pkiddeporte
                    WHERE 
                        d.nombre = 'Voleibol'";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        conn.Open();
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvVoleibol.DataSource = dt;
                    }
                }

                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();
            CamposVacios();
            //Obtenemos los datos del form y declaramos variables
            //Partido
            DateTime Fecha = DtpFecha.Value;
            int FkIdEquipoLocalId = Convert.ToInt32(CmbEquipoLocal.SelectedValue);
            int FkIdEquipoVisId = Convert.ToInt32(CmbEquipoVisitante.SelectedValue);
            string EstadoPartido = CmbEstadoPartido.Text;
            char Ganador = 'V'; // Siempre será 'V'
            int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
            int FkIdFase = Convert.ToInt32(CmbFase.SelectedValue);
            int FkIdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);
            //Volley Local
            int SetsLocal = Convert.ToInt32(NudSetsLocal.Value);
            int PuntosLocal = Convert.ToInt32(NudPuntosLocal.Value);
            int AtaquesLocal = Convert.ToInt32(NudAtaquesLocal.Value);
            int BloqueosLocal = Convert.ToInt32(NudBloqueosLocal.Value);
            int ServiciosErradosLocal = Convert.ToInt32(NudServiciosErradosLocal.Value);
            int RecepcionesLocal = Convert.ToInt32(NudRecepcionesLocal.Value);
            int DefensaLocal = Convert.ToInt32(NudDefensaLocal.Value);
            int AcesLocal = Convert.ToInt32(NudAcesLocal.Value);
            //Basquet Visitante
            int SetsVisitante = Convert.ToInt32(NudSetsVisitante.Value);
            int PuntosVisitante = Convert.ToInt32(NudPuntosVisitante.Value);
            int AtaquesVisitante = Convert.ToInt32(NudAtaquesVisitante.Value);
            int BloqueosVisitante = Convert.ToInt32(NudBloqueosVisitante.Value);
            int ServiciosErradosVisitante = Convert.ToInt32(NudServiciosErradosVisitante.Value);
            int RecepcionesVisitante = Convert.ToInt32(NudRecepcionesVisitante.Value);
            int DefensaVisitante = Convert.ToInt32(NudDefensaVisitante.Value);
            int AcesVisitante = Convert.ToInt32(NudAcesVisitante.Value);

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    if (CmbGanadorEmpate.SelectedIndex == 0)
                    {
                        // SQL insertar datos en partido
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, ganadorlocal = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtIdPartido.Text);
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);

                            // Ejecutar el comando para que se obtenga el ID antes de realizar la otra inserción de datos
                            // FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());

                            DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                            {
                                // Ejecutar el comando
                                int rowsAffected = cmd.ExecuteNonQuery();
                                //sql insertar datos en futbol
                                string querypartido = @"UPDATE volleyball SET setsganadosequipolocal = @setsganadosequipolocal, setsganadosequipovisitante = @setsganadosequipovisitante, puntostotalesequipol = @puntostotalesequipol, puntostotalesequipovi = @puntostotalesequipovi, ataquesequipolocal = @ataquesequipolocal, ataquesequipovisitante = @ataquesequipovisitante, bloqueosequipolocal = @bloqueosequipolocal, bloqueosequipovisitante = @bloqueosequipovisitante, servicioserradoslocal = @servicioserradoslocal, servicioserradosvis = @servicioserradosvis, recepcionesequipolocal = @recepcionesequipolocal, recepcionesequipovisitante = @recepcionesequipovisitante, defensasequipolocal = @defensasequipolocal, defensasequipovisitante = @defensasequipovisitante, acesequipolocal = @acesequipolocal, acesequipovisitante = @acesequipovisitante WHERE pkidvolleyball = @pkidvolleyball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidvolleyball", TxtIdVolley.Text);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                                    cmd2.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                                    cmd2.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                                    cmd2.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                                    cmd2.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                                    cmd2.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                                    cmd2.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                                    cmd2.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                                    cmd2.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a voleibol correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a partido correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    if (CmbGanadorEmpate.SelectedIndex == 1)
                    {
                        // SQL insertar datos en partido
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, ganadorvisitante = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtIdPartido.Text);
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);


                            // Ejecutar el comando para que se obtenga el ID antes de realizar la otra inserción de datos
                            // FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());

                            DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                            {
                                // Ejecutar el comando
                                int rowsAffected = cmd.ExecuteNonQuery();
                                //sql insertar datos en futbol
                                string querypartido = @"UPDATE volleyball SET setsganadosequipolocal = @setsganadosequipolocal, setsganadosequipovisitante = @setsganadosequipovisitante, puntostotalesequipol = @puntostotalesequipol, puntostotalesequipovi = @puntostotalesequipovi, ataquesequipolocal = @ataquesequipolocal, ataquesequipovisitante = @ataquesequipovisitante, bloqueosequipolocal = @bloqueosequipolocal, bloqueosequipovisitante = @bloqueosequipovisitante, servicioserradoslocal = @servicioserradoslocal, servicioserradosvis = @servicioserradosvis, recepcionesequipolocal = @recepcionesequipolocal, recepcionesequipovisitante = @recepcionesequipovisitante, defensasequipolocal = @defensasequipolocal, defensasequipovisitante = @defensasequipovisitante, acesequipolocal = @acesequipolocal, acesequipovisitante = @acesequipovisitante WHERE pkidvolleyball = @pkidvolleyball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidvolleyball", TxtIdVolley.Text);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                                    cmd2.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                                    cmd2.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                                    cmd2.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                                    cmd2.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                                    cmd2.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                                    cmd2.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                                    cmd2.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                                    cmd2.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a voleibol correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a partido correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    if (CmbGanadorEmpate.SelectedIndex == 2)
                    {
                        // SQL insertar datos en partido
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, empate = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtIdPartido.Text);
                            cmd.Parameters.AddWithValue("@fechahora", Fecha);
                            cmd.Parameters.AddWithValue("@fkequipolocalid", FkIdEquipoLocalId);
                            cmd.Parameters.AddWithValue("@fkequipovisid", FkIdEquipoVisId);
                            cmd.Parameters.AddWithValue("@estadopartido", EstadoPartido);
                            cmd.Parameters.AddWithValue("@ganadorlocal", Ganador);
                            cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                            cmd.Parameters.AddWithValue("@fkidfase", FkIdFase);
                            cmd.Parameters.AddWithValue("@fkidarbitro", FkIdArbitro);


                            // Ejecutar el comando para que se obtenga el ID antes de realizar la otra inserción de datos
                            // FkIdPartido = Convert.ToInt32(cmd.ExecuteScalar());

                            DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                            {
                                // Ejecutar el comando
                                int rowsAffected = cmd.ExecuteNonQuery();
                                //sql insertar datos en futbol
                                string querypartido = @"UPDATE volleyball SET setsganadosequipolocal = @setsganadosequipolocal, setsganadosequipovisitante = @setsganadosequipovisitante, puntostotalesequipol = @puntostotalesequipol, puntostotalesequipovi = @puntostotalesequipovi, ataquesequipolocal = @ataquesequipolocal, ataquesequipovisitante = @ataquesequipovisitante, bloqueosequipolocal = @bloqueosequipolocal, bloqueosequipovisitante = @bloqueosequipovisitante, servicioserradoslocal = @servicioserradoslocal, servicioserradosvis = @servicioserradosvis, recepcionesequipolocal = @recepcionesequipolocal, recepcionesequipovisitante = @recepcionesequipovisitante, defensasequipolocal = @defensasequipolocal, defensasequipovisitante = @defensasequipovisitante, acesequipolocal = @acesequipolocal, acesequipovisitante = @acesequipovisitante WHERE pkidvolleyball = @pkidvolleyball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidvolleyball", TxtIdVolley.Text);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipolocal", SetsLocal);
                                    cmd2.Parameters.AddWithValue("@setsganadosequipovisitante", SetsVisitante);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipol", PuntosLocal);
                                    cmd2.Parameters.AddWithValue("@puntostotalesequipovi", PuntosVisitante);
                                    cmd2.Parameters.AddWithValue("@ataquesequipolocal", AtaquesLocal);
                                    cmd2.Parameters.AddWithValue("@ataquesequipovisitante", AtaquesVisitante);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipolocal", BloqueosLocal);
                                    cmd2.Parameters.AddWithValue("@bloqueosequipovisitante", BloqueosVisitante);
                                    cmd2.Parameters.AddWithValue("@servicioserradoslocal", ServiciosErradosLocal);
                                    cmd2.Parameters.AddWithValue("@servicioserradosvis", ServiciosErradosVisitante);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipolocal", RecepcionesLocal);
                                    cmd2.Parameters.AddWithValue("@recepcionesequipovisitante", RecepcionesVisitante);
                                    cmd2.Parameters.AddWithValue("@defensasequipolocal", DefensaLocal);
                                    cmd2.Parameters.AddWithValue("@defensasequipovisitante", DefensaVisitante);
                                    cmd2.Parameters.AddWithValue("@acesequipolocal", AcesLocal);
                                    cmd2.Parameters.AddWithValue("@acesequipovisitante", AcesVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a voleibol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de voleyball", usuarioId);
                                    MessageBox.Show("Datos modificados a partido correctamente.", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Limpiar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            // Verificar que el campo TxtIdPartido no esté vacío y contenga un número válido
            if (string.IsNullOrWhiteSpace(TxtIdPartido.Text) || !int.TryParse(TxtIdPartido.Text, out int IdPartido))
            {
                MessageBox.Show("Por favor seleccione un partido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexion conexion = new Conexion();

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    // Iniciar una transacción para asegurar la integridad de los datos
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Eliminar registros en la tabla baseball relacionados con el partido
                        string queryDeleteFutbol = @"DELETE FROM volleyball WHERE fkidpartido = @fkidpartido";
                        using (MySqlCommand cmd = new MySqlCommand(queryDeleteFutbol, conn, transaction))
                        {
                            // Agregar el parámetro
                            cmd.Parameters.AddWithValue("@fkidpartido", IdPartido);
                            // Mostrar pregunta por si desea eliminar
                            DialogResult result = MessageBox.Show("¿Está seguro de que deseas eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                            {
                                // Ejecutar el comando
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Eliminar el partido
                                string queryDeletePartido = @"DELETE FROM partido WHERE pkidpartido = @pkidpartido";
                                using (MySqlCommand cmd2 = new MySqlCommand(queryDeletePartido, conn, transaction))
                                {
                                    // Agregar el parámetro
                                    cmd2.Parameters.AddWithValue("@pkidpartido", IdPartido);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();
                                }
                                // Confirmar la transacción
                                transaction.Commit();

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Ingresó un nuevo deporte", usuarioId);
                                    MessageBox.Show("Datos eliminados correctamente.", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                else
                                {
                                    // mensaje si no se encontró el registro
                                    MessageBox.Show("No se encontró el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Limpiar();
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
                    // Revertir la transacción en caso de error
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (MySqlTransaction transaction = conn.BeginTransaction())
                        {
                            transaction.Rollback();
                        }
                    }

                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DgvVoleibol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdPartido.Text = DgvVoleibol.CurrentRow.Cells[0].Value.ToString();
                DtpFecha.Text = DgvVoleibol.CurrentRow.Cells[1].Value.ToString();
                CmbEquipoLocal.Text = DgvVoleibol.CurrentRow.Cells[2].Value.ToString();
                CmbEquipoVisitante.Text = DgvVoleibol.CurrentRow.Cells[3].Value.ToString();
                CmbCampeonato.Text = DgvVoleibol.CurrentRow.Cells[4].Value.ToString();
                CmbFase.Text = DgvVoleibol.CurrentRow.Cells[5].Value.ToString();
                CmbArbitro.Text = DgvVoleibol.CurrentRow.Cells[6].Value.ToString();
                CmbEstadoPartido.Text = DgvVoleibol.CurrentRow.Cells[7].Value.ToString();
                CmbGanadorEmpate.Text = DgvVoleibol.CurrentRow.Cells[8].Value.ToString();
                NudSetsLocal.Text = DgvVoleibol.CurrentRow.Cells[11].Value.ToString();
                NudSetsVisitante.Text = DgvVoleibol.CurrentRow.Cells[12].Value.ToString();
                NudPuntosLocal.Text = DgvVoleibol.CurrentRow.Cells[13].Value.ToString();
                NudPuntosVisitante.Text = DgvVoleibol.CurrentRow.Cells[14].Value.ToString();
                NudAtaquesLocal.Text = DgvVoleibol.CurrentRow.Cells[15].Value.ToString();
                NudAtaquesVisitante.Text = DgvVoleibol.CurrentRow.Cells[16].Value.ToString();
                NudBloqueosLocal.Text = DgvVoleibol.CurrentRow.Cells[17].Value.ToString();
                NudBloqueosVisitante.Text = DgvVoleibol.CurrentRow.Cells[18].Value.ToString();
                NudServiciosErradosLocal.Text = DgvVoleibol.CurrentRow.Cells[19].Value.ToString();
                NudServiciosErradosVisitante.Text = DgvVoleibol.CurrentRow.Cells[20].Value.ToString();
                NudRecepcionesLocal.Text = DgvVoleibol.CurrentRow.Cells[21].Value.ToString();
                NudRecepcionesVisitante.Text = DgvVoleibol.CurrentRow.Cells[22].Value.ToString();
                NudDefensaLocal.Text = DgvVoleibol.CurrentRow.Cells[23].Value.ToString();
                NudDefensaVisitante.Text = DgvVoleibol.CurrentRow.Cells[24].Value.ToString();
                NudAcesLocal.Text = DgvVoleibol.CurrentRow.Cells[25].Value.ToString();
                NudAcesVisitante.Text = DgvVoleibol.CurrentRow.Cells[26].Value.ToString();
                TxtIdVolley.Text = DgvVoleibol.CurrentRow.Cells[27].Value.ToString();
            }
            catch
            {
            }
        }
    }
}
