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
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public partial class FormBeisbol : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormBeisbol()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);

            CargarEquiposBeisbol(); // Cargan los equipos unicamente de BEISBOL o los que no tengan asignación en PARTIDOS
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

        private DataTable EquiposBeis;

        private void CargarEquiposBeisbol()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            string query = @"
                SELECT DISTINCT e.pkidequipo, e.nombre 
                FROM equipo e
                LEFT JOIN partido p ON e.pkidequipo = p.fkequipolocalid OR e.pkidequipo = p.fkequipovisid
                LEFT JOIN campeonato c ON p.fkidcampeonato = c.pkidcampeonato
                LEFT JOIN deporte d ON c.fkiddeporte = d.pkiddeporte
                WHERE d.nombre = 'Béisbol' OR d.nombre IS NULL
                ORDER BY e.nombre";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                EquiposBeis = new DataTable();
                adapter.Fill(EquiposBeis);

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
            CmbEquipoLocal.DataSource = EquiposBeis;
            CmbEquipoLocal.DisplayMember = "nombre";
            CmbEquipoLocal.ValueMember = "pkidequipo";
        }

        private void CargarEquiposVisitante()
        {
            if (EquiposBeis == null) return;

            DataTable dtVisitante = EquiposBeis.Clone();
            foreach (DataRow row in EquiposBeis.Rows)
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
                WHERE d.nombre = 'Beisbol'
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
                    MessageBox.Show("No hay campeonatos de beisbol registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los campeonatos de beisbol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtIdBeisbol.Clear();
            DtpFecha.Value = DateTime.Now;
            CmbEstadoPartido.SelectedIndex = -1;
            CmbGanadorEmpate.SelectedIndex = -1;
            CmbCampeonato.SelectedIndex = -1;
            CmbFase.SelectedIndex = -1;
            CmbArbitro.SelectedIndex = -1;
            CmbEquipoLocal.SelectedIndex = -1;
            CmbEquipoVisitante.SelectedIndex = -1;
            NudCarrerasLocal.Value = 0;
            NudHitsLocal.Value = 0;
            NudErroresLocal.Value = 0;
            NudHomerunsLocal.Value = 0;
            NudPonchesLocal.Value = 0;
            NudBasesRobadasLocal.Value = 0;
            NudLanzamientosLocal.Value = 0;
            NudCarrerasVisitante.Value = 0;
            NudHitsVisitante.Value = 0;
            NudErroresVisitante.Value = 0;
            NudHomerunsVisitante.Value = 0;
            NudPonchesVisitante.Value = 0;
            NudBasesRobadasVisitante.Value = 0;
            NudLanzamientosVisitante.Value = 0;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormBeisbol_Load(object sender, EventArgs e)
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

            DtpFecha.MinDate = DateTime.Today;

            DtpFecha.TabIndex = 0;
            CmbEstadoPartido.TabIndex = 1;
            CmbGanadorEmpate.TabIndex = 2;
            CmbCampeonato.TabIndex = 3;
            CmbFase.TabIndex = 4;
            CmbArbitro.TabIndex = 5;
            CmbEquipoLocal.TabIndex = 6;
            NudCarrerasLocal.TabIndex = 7;
            NudHitsLocal.TabIndex = 8;
            NudErroresLocal.TabIndex = 9;
            NudHomerunsLocal.TabIndex = 10;
            NudPonchesLocal.TabIndex = 11;
            NudBasesRobadasLocal.TabIndex = 12;
            NudLanzamientosLocal.TabIndex = 13;
            CmbEquipoVisitante.TabIndex = 14;
            NudCarrerasVisitante.TabIndex = 15;
            NudHitsVisitante.TabIndex = 16;
            NudErroresVisitante.TabIndex = 17;
            NudHomerunsVisitante.TabIndex = 18;
            NudPonchesVisitante.TabIndex = 19;
            NudBasesRobadasVisitante.TabIndex = 20;
            NudLanzamientosVisitante.TabIndex = 21;
            BtnIngresar.TabIndex = 22;
            BtnVer.TabIndex = 23;
            BtnModificar.TabIndex = 24;
            BtnEliminar.TabIndex = 25;
            BtnAyuda.TabIndex = 26;
            DgvBeisbol.TabStop = false;


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
            //Beisbol Local
            int CarrerasLocal = Convert.ToInt32(NudCarrerasLocal.Value);
            int HitsLocal = Convert.ToInt32(NudHitsLocal.Value);
            int ErroresLocal = Convert.ToInt32(NudErroresLocal.Value);
            int HomerunsLocal = Convert.ToInt32(NudHomerunsLocal.Value);
            int PonchesLocal = Convert.ToInt32(NudPonchesLocal.Value);
            int BasesRobadasLocal = Convert.ToInt32(NudBasesRobadasLocal.Value);
            int LanzamientosLocal = Convert.ToInt32(NudLanzamientosLocal.Value);
            //Beisbol Visitante
            int CarrerasVisitante = Convert.ToInt32(NudCarrerasVisitante.Value);
            int HitsVisitante = Convert.ToInt32(NudHitsVisitante.Value);
            int ErroresVisitante = Convert.ToInt32(NudErroresVisitante.Value);
            int HomerunsVisitante = Convert.ToInt32(NudHomerunsVisitante.Value);
            int PonchesVisitante = Convert.ToInt32(NudPonchesVisitante.Value);
            int BasesRobadasVisitante = Convert.ToInt32(NudBasesRobadasVisitante.Value);
            int LanzamientosVisitante = Convert.ToInt32(NudLanzamientosVisitante.Value);

            CamposVacios();

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
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
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en baseball
                        string querypartido = @"INSERT INTO baseball (carrerasequipolocal, carrerasequipovisitante, hitsequipolocal, hitsequipovisitante, erroresequipolocal, erroresequipovisitante, homerunsequipolocal, homerunsequipovisitante, ponchesequipolocal, ponchesequipovisitante, basesrobadasequipolocal, basesrobadasequipovi, lanzamientosstrikelocal, lanzamientosstrikevis, fkidpartido) 
                                                                VALUES (@carrerasequipolocal, @carrerasequipovisitante, @hitsequipolocal, @hitsequipovisitante, @erroresequipolocal, @erroresequipovisitante, @homerunsequipolocal, @homerunsequipovisitante, @ponchesequipolocal, @ponchesequipovisitante, @basesrobadasequipolocal, @basesrobadasequipovi, @lanzamientosstrikelocal, @lanzamientosstrikevis, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                            cmd.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                            cmd.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                            cmd.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                            cmd.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                            cmd.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                            cmd.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                            cmd.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                            cmd.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                            cmd.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                            cmd.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                            cmd.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en baseball
                        string querypartido = @"INSERT INTO baseball (carrerasequipolocal, carrerasequipovisitante, hitsequipolocal, hitsequipovisitante, erroresequipolocal, erroresequipovisitante, homerunsequipolocal, homerunsequipovisitante, ponchesequipolocal, ponchesequipovisitante, basesrobadasequipolocal, basesrobadasequipovi, lanzamientosstrikelocal, lanzamientosstrikevis, fkidpartido) 
                                                                VALUES (@carrerasequipolocal, @carrerasequipovisitante, @hitsequipolocal, @hitsequipovisitante, @erroresequipolocal, @erroresequipovisitante, @homerunsequipolocal, @homerunsequipovisitante, @ponchesequipolocal, @ponchesequipovisitante, @basesrobadasequipolocal, @basesrobadasequipovi, @lanzamientosstrikelocal, @lanzamientosstrikevis, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                            cmd.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                            cmd.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                            cmd.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                            cmd.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                            cmd.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                            cmd.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                            cmd.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                            cmd.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                            cmd.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                            cmd.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                            cmd.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en baseball
                        string querypartido = @"INSERT INTO baseball (carrerasequipolocal, carrerasequipovisitante, hitsequipolocal, hitsequipovisitante, erroresequipolocal, erroresequipovisitante, homerunsequipolocal, homerunsequipovisitante, ponchesequipolocal, ponchesequipovisitante, basesrobadasequipolocal, basesrobadasequipovi, lanzamientosstrikelocal, lanzamientosstrikevis, fkidpartido) 
                                                                VALUES (@carrerasequipolocal, @carrerasequipovisitante, @hitsequipolocal, @hitsequipovisitante, @erroresequipolocal, @erroresequipovisitante, @homerunsequipolocal, @homerunsequipovisitante, @ponchesequipolocal, @ponchesequipovisitante, @basesrobadasequipolocal, @basesrobadasequipovi, @lanzamientosstrikelocal, @lanzamientosstrikevis, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                            cmd.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                            cmd.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                            cmd.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                            cmd.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                            cmd.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                            cmd.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                            cmd.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                            cmd.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                            cmd.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                            cmd.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                            cmd.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                            cmd.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            bitacora.RegistrarEvento("Ingresó un nuevo partido de baseball", usuarioId);
                            MessageBox.Show("Datos ingresados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DgvBeisbol.Visible = true;
            Conexion conexion = new Conexion(); //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
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
                        b.carrerasequipolocal AS CarrerasLocal,
                        b.carrerasequipovisitante AS CarrerasVisitante,
                        b.hitsequipolocal AS HitsLocal,
                        b.hitsequipovisitante AS HitsVisitante,
                        b.erroresequipolocal AS ErroresLocal,
                        b.erroresequipovisitante AS ErroresVisitante,
                        b.homerunsequipolocal AS HomeRunsLocal,
                        b.homerunsequipovisitante AS HomeRunsVisitante,
                        b.ponchesequipolocal AS PonchesLocal,
                        b.ponchesequipovisitante AS PonchesVisitante,
                        b.basesrobadasequipolocal AS BasesRobadasLocal,
                        b.basesrobadasequipovi AS BasesRobadasVisitante,
                        b.lanzamientosstrikelocal AS LanzamientosStrikeLocal,
                        b.lanzamientosstrikevis AS LanzamientosStrikeVisitante,
                        b.pkidbaseball AS IDBaseball
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
                        baseball b ON partido.pkidpartido = b.fkidpartido
                    JOIN 
                        deporte d ON c.fkiddeporte = d.pkiddeporte
                    WHERE 
                        d.nombre = 'Beisbol'";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvBeisbol.DataSource = dt;
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
            //Beisbol Local
            int CarrerasLocal = Convert.ToInt32(NudCarrerasLocal.Value);
            int HitsLocal = Convert.ToInt32(NudHitsLocal.Value);
            int ErroresLocal = Convert.ToInt32(NudErroresLocal.Value);
            int HomerunsLocal = Convert.ToInt32(NudHomerunsLocal.Value);
            int PonchesLocal = Convert.ToInt32(NudPonchesLocal.Value);
            int BasesRobadasLocal = Convert.ToInt32(NudBasesRobadasLocal.Value);
            int LanzamientosLocal = Convert.ToInt32(NudLanzamientosLocal.Value);
            //Beisbol Visitante
            int CarrerasVisitante = Convert.ToInt32(NudCarrerasVisitante.Value);
            int HitsVisitante = Convert.ToInt32(NudHitsVisitante.Value);
            int ErroresVisitante = Convert.ToInt32(NudErroresVisitante.Value);
            int HomerunsVisitante = Convert.ToInt32(NudHomerunsVisitante.Value);
            int PonchesVisitante = Convert.ToInt32(NudPonchesVisitante.Value);
            int BasesRobadasVisitante = Convert.ToInt32(NudBasesRobadasVisitante.Value);
            int LanzamientosVisitante = Convert.ToInt32(NudLanzamientosVisitante.Value);


            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    if (CmbGanadorEmpate.SelectedIndex == 0)
                    {
                        // SQL insertar datos en partido
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, ganadorlocal = @ganadorlocal, ganadorlocal = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
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
                                string querypartido = @"UPDATE baseball SET carrerasequipolocal = @carrerasequipolocal, carrerasequipovisitante = @carrerasequipovisitante, hitsequipolocal = @hitsequipolocal, hitsequipovisitante = @hitsequipovisitante, erroresequipolocal = @erroresequipolocal, erroresequipovisitante = @erroresequipovisitante, homerunsequipolocal = @homerunsequipolocal, homerunsequipovisitante = @homerunsequipovisitante, ponchesequipolocal = @ponchesequipolocal, ponchesequipovisitante = @ponchesequipovisitante, basesrobadasequipolocal = @basesrobadasequipolocal, basesrobadasequipovi = @basesrobadasequipovi, lanzamientosstrikelocal = @lanzamientosstrikelocal, lanzamientosstrikevis = @lanzamientosstrikevis WHERE pkidbaseball = @pkidbaseball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidbaseball", TxtIdBeisbol.Text);
                                    cmd2.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                                    cmd2.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                                    cmd2.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                                    cmd2.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                                    cmd2.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                                    cmd2.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                                    cmd2.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                                    cmd2.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                                    cmd2.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                                    cmd2.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de baseball", usuarioId);
                                    MessageBox.Show("Datos modificados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de baseball", usuarioId);
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
                                string querypartido = @"UPDATE baseball SET carrerasequipolocal = @carrerasequipolocal, carrerasequipovisitante = @carrerasequipovisitante, hitsequipolocal = @hitsequipolocal, hitsequipovisitante = @hitsequipovisitante, erroresequipolocal = @erroresequipolocal, erroresequipovisitante = @erroresequipovisitante, homerunsequipolocal = @homerunsequipolocal, homerunsequipovisitante = @homerunsequipovisitante, ponchesequipolocal = @ponchesequipolocal, ponchesequipovisitante = @ponchesequipovisitante, basesrobadasequipolocal = @basesrobadasequipolocal, basesrobadasequipovi = @basesrobadasequipovi, lanzamientosstrikelocal = @lanzamientosstrikelocal, lanzamientosstrikevis = @lanzamientosstrikevis WHERE pkidbaseball = @pkidbaseball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidbaseball", TxtIdBeisbol.Text);
                                    cmd2.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                                    cmd2.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                                    cmd2.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                                    cmd2.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                                    cmd2.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                                    cmd2.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                                    cmd2.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                                    cmd2.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                                    cmd2.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                                    cmd2.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de basseball", usuarioId);
                                    MessageBox.Show("Datos modificados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de baseball", usuarioId);
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
                                string querypartido = @"UPDATE baseball SET carrerasequipolocal = @carrerasequipolocal, carrerasequipovisitante = @carrerasequipovisitante, hitsequipolocal = @hitsequipolocal, hitsequipovisitante = @hitsequipovisitante, erroresequipolocal = @erroresequipolocal, erroresequipovisitante = @erroresequipovisitante, homerunsequipolocal = @homerunsequipolocal, homerunsequipovisitante = @homerunsequipovisitante, ponchesequipolocal = @ponchesequipolocal, ponchesequipovisitante = @ponchesequipovisitante, basesrobadasequipolocal = @basesrobadasequipolocal, basesrobadasequipovi = @basesrobadasequipovi, lanzamientosstrikelocal = @lanzamientosstrikelocal, lanzamientosstrikevis = @lanzamientosstrikevis WHERE pkidbaseball = @pkidbaseball";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidbaseball", TxtIdBeisbol.Text);
                                    cmd2.Parameters.AddWithValue("@carrerasequipolocal", CarrerasLocal);
                                    cmd2.Parameters.AddWithValue("@carrerasequipovisitante", CarrerasVisitante);
                                    cmd2.Parameters.AddWithValue("@hitsequipolocal", HitsLocal);
                                    cmd2.Parameters.AddWithValue("@hitsequipovisitante", HitsVisitante);
                                    cmd2.Parameters.AddWithValue("@erroresequipolocal", ErroresLocal);
                                    cmd2.Parameters.AddWithValue("@erroresequipovisitante", ErroresVisitante);
                                    cmd2.Parameters.AddWithValue("@homerunsequipolocal", HomerunsLocal);
                                    cmd2.Parameters.AddWithValue("@homerunsequipovisitante", HomerunsVisitante);
                                    cmd2.Parameters.AddWithValue("@ponchesequipolocal", PonchesLocal);
                                    cmd2.Parameters.AddWithValue("@ponchesequipovisitante", PonchesVisitante);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipolocal", BasesRobadasLocal);
                                    cmd2.Parameters.AddWithValue("@basesrobadasequipovi", BasesRobadasVisitante);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikelocal", LanzamientosLocal);
                                    cmd2.Parameters.AddWithValue("@lanzamientosstrikevis", LanzamientosVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    bitacora.RegistrarEvento("Modificó un partido de baseball", usuarioId);
                                    MessageBox.Show("Datos modificados a beisbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
                                    bitacora.RegistrarEvento("Modificó un partido de baseball", usuarioId);
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

        private void BtnEliminar_Click_1(object sender, EventArgs e)
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
                        string queryDeleteFutbol = @"DELETE FROM baseball WHERE fkidpartido = @fkidpartido";
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
                                    bitacora.RegistrarEvento("Eliminó un partido de baseball", usuarioId);
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

        private void DgvBeisbol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdPartido.Text = DgvBeisbol.CurrentRow.Cells[0].Value.ToString();
                DtpFecha.Text = DgvBeisbol.CurrentRow.Cells[1].Value.ToString();
                CmbEquipoLocal.Text = DgvBeisbol.CurrentRow.Cells[2].Value.ToString();
                CmbEquipoVisitante.Text = DgvBeisbol.CurrentRow.Cells[3].Value.ToString();
                CmbCampeonato.Text = DgvBeisbol.CurrentRow.Cells[4].Value.ToString();
                CmbFase.Text = DgvBeisbol.CurrentRow.Cells[5].Value.ToString();
                CmbArbitro.Text = DgvBeisbol.CurrentRow.Cells[6].Value.ToString();
                CmbEstadoPartido.Text = DgvBeisbol.CurrentRow.Cells[7].Value.ToString();
                CmbGanadorEmpate.Text = DgvBeisbol.CurrentRow.Cells[8].Value.ToString();
                NudCarrerasLocal.Text = DgvBeisbol.CurrentRow.Cells[11].Value.ToString();
                NudCarrerasVisitante.Text = DgvBeisbol.CurrentRow.Cells[12].Value.ToString();
                NudHitsLocal.Text = DgvBeisbol.CurrentRow.Cells[13].Value.ToString();
                NudHitsVisitante.Text = DgvBeisbol.CurrentRow.Cells[14].Value.ToString();
                NudErroresLocal.Text = DgvBeisbol.CurrentRow.Cells[15].Value.ToString();
                NudErroresVisitante.Text = DgvBeisbol.CurrentRow.Cells[16].Value.ToString();
                NudHomerunsLocal.Text = DgvBeisbol.CurrentRow.Cells[17].Value.ToString();
                NudHomerunsVisitante.Text = DgvBeisbol.CurrentRow.Cells[18].Value.ToString();
                NudPonchesLocal.Text = DgvBeisbol.CurrentRow.Cells[19].Value.ToString();
                NudPonchesLocal.Text = DgvBeisbol.CurrentRow.Cells[20].Value.ToString();
                NudBasesRobadasLocal.Text = DgvBeisbol.CurrentRow.Cells[21].Value.ToString();
                NudBasesRobadasVisitante.Text = DgvBeisbol.CurrentRow.Cells[22].Value.ToString();
                NudLanzamientosLocal.Text = DgvBeisbol.CurrentRow.Cells[23].Value.ToString();
                NudLanzamientosVisitante.Text = DgvBeisbol.CurrentRow.Cells[24].Value.ToString();
                TxtIdBeisbol.Text = DgvBeisbol.CurrentRow.Cells[25].Value.ToString();
            }
            catch
            {
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
            int pageNumber = 72;

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

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
