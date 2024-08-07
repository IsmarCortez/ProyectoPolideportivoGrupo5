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
    public partial class FormFutbol : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormFutbol()
        {
            InitializeComponent();
            CargarEquiposLocal();
            CargarEquiposVisitante();
            CargarEstadoPartido();
            CargarGanadorEmpate();
            CargarCampeonato();
            CargarFase();
            CargarArbitros();
            CmbArbitro.DropDownStyle = ComboBoxStyle.DropDownList;//para que no cambien el contenido
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEstadoPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFase.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGanadorEmpate.DropDownStyle = ComboBoxStyle.DropDownList;
            Limpiar();

            NudPosesionLocal.Minimum = 0; //Establecemos el valor de los NUD para que esten parejos
            NudPosesionLocal.Maximum = 100;
            NudPosesionLocal.Value = 50;
            NudPosesionVisitante.Minimum = 0;
            NudPosesionVisitante.Maximum = 100;
            NudPosesionVisitante.Value = 50;
            NudPosesionLocal.ValueChanged += NudPosesionLocal_ValueChanged; //Se crean los eventos cuando uno sube el otro baja
            NudPosesionVisitante.ValueChanged += NudPosesionVisitante_ValueChanged;


            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

        private DataTable todosLosEquipos; // se crea una DataTable la cual tendra todos los equipos para luego aplicar lo requerido

        private void CargarEquiposLocal()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            string query = @"
                SELECT DISTINCT e.pkidequipo, e.nombre 
                FROM equipo e
                LEFT JOIN partido p ON e.pkidequipo = p.fkequipolocalid OR e.pkidequipo = p.fkequipovisid
                LEFT JOIN campeonato c ON p.fkidcampeonato = c.pkidcampeonato
                LEFT JOIN deporte d ON c.fkiddeporte = d.pkiddeporte
                WHERE d.nombre = 'Futbol' OR d.nombre IS NULL
                ORDER BY e.nombre";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                todosLosEquipos = new DataTable();
                adapter.Fill(todosLosEquipos); //Se llena la tabla con los datos obtenidos
                CmbEquipoLocal.DataSource = new DataTable(); //Se crea una nueva DataTable vacía y la asigna como fuente de datos para el ComboBox de equipo local.
                ((DataTable)CmbEquipoLocal.DataSource).Columns.Add("pkidequipo", typeof(int));//Se crean dos columnas una con id_equipo y otra con nombre
                ((DataTable)CmbEquipoLocal.DataSource).Columns.Add("nombre", typeof(string));
                foreach (DataRow row in todosLosEquipos.Rows)
                {
                    ((DataTable)CmbEquipoLocal.DataSource).Rows.Add(row.ItemArray);
                }
                CmbEquipoLocal.DisplayMember = "nombre";
                CmbEquipoLocal.ValueMember = "pkidequipo";
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

        private void CargarEquiposVisitante()
        {
            if (todosLosEquipos == null) return;

            DataTable dtVisitante = todosLosEquipos.Clone();//Se clona la datatable anterior
            foreach (DataRow row in todosLosEquipos.Rows)
            {
                if (CmbEquipoLocal.SelectedValue == null || row["pkidequipo"].ToString() != CmbEquipoLocal.SelectedValue.ToString())
                {//se crea un foreach para que recorra la tabla y busque que si el otro combobox tiene un dato, no lo muestre en este
                    dtVisitante.Rows.Add(row.ItemArray);
                }
            }

            CmbEquipoVisitante.DataSource = dtVisitante;
            CmbEquipoVisitante.DisplayMember = "nombre";
            CmbEquipoVisitante.ValueMember = "pkidequipo";
        }

        private void CmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquiposVisitante();
        }

        private void CmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarEstadoPartido()
        {
            CmbEstadoPartido.Items.Add("Pendiente");
            CmbEstadoPartido.Items.Add("En Curso");
            CmbEstadoPartido.Items.Add("Suspendido");
            CmbEstadoPartido.Items.Add("Finalizado");
            CmbEstadoPartido.Items.Add("Cancelado");
        }

        private void CargarGanadorEmpate()
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
                WHERE d.nombre = 'Futbol'
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
                    MessageBox.Show("No hay campeonatos de futbol registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error con campeonatos: " + ex.Message);
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
            TxtId.Clear();
            DtpFecha.Value = DateTime.Now;
            CmbEstadoPartido.SelectedIndex = -1;
            CmbGanadorEmpate.SelectedIndex = -1;
            CmbCampeonato.SelectedIndex = -1;
            CmbFase.SelectedIndex = -1;
            CmbArbitro.SelectedIndex = -1;
            CmbEquipoLocal.SelectedIndex = -1;
            CmbEquipoVisitante.SelectedIndex = -1;
            NudGolesLocal.Value = 0;
            NudTirosLocal.Value = 0;
            NudPosesionLocal.Value = 0;
            NudGolesVisitante.Value = 0;
            NudTirosVisitante.Value = 0;
            NudPosesionVisitante.Value = 0;
            CmbGanadorEmpate.Enabled = false;
           // CmbCampeonato.Enabled = false;
            CmbFase.Enabled = false;
            CmbArbitro.Enabled = false;

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            //Partido
            DateTime Fecha = DtpFecha.Value;
            int FkIdEquipoLocalId = Convert.ToInt32(CmbEquipoLocal.SelectedValue);
            int FkIdEquipoVisId = Convert.ToInt32(CmbEquipoVisitante.SelectedValue);
            string EstadoPartido = CmbEstadoPartido.Text;
            string Ganador = ((dynamic)CmbGanadorEmpate.SelectedItem).Valor.ToString();
            int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
            int FkIdFase = Convert.ToInt32(CmbFase.SelectedValue);
            int FkIdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);
            //Futbol
            int GolesEquipoLocal = Convert.ToInt32(NudGolesLocal.Value);
            int GolesEquipoVisitante = Convert.ToInt32(NudGolesVisitante.Value);
            int TirosEquipoLocal = Convert.ToInt32(NudTirosLocal.Value);
            int TirosEquipoVisitante = Convert.ToInt32(NudTirosVisitante.Value);
            int PosesionEquipoLocal = Convert.ToInt32(NudPosesionLocal.Value);
            int PosesionEquipoVisitante = Convert.ToInt32(NudPosesionVisitante.Value);
            //string FkIdPartido = TxtId.Text; 
            CamposVacios();

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
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
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en futbol
                        string querypartido = @"INSERT INTO futbol (golesequipolocal, golesequipovisitante, tirosequipolocal, tirosequipovisitante, posesionequipolocal, posesionequipovisitante, fkidpartido) VALUES (@golesequipolocal, @golesequipovisitante, @tirosequipolocal, @tirosequipovisitante, @posesionequipolocal, @posesionequipovisitante, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                            cmd.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                            cmd.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                            cmd.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                            cmd.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                            cmd.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Datos ingresados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en futbol
                        string querypartido = @"INSERT INTO futbol (golesequipolocal, golesequipovisitante, tirosequipolocal, tirosequipovisitante, posesionequipolocal, posesionequipovisitante, fkidpartido) VALUES (@golesequipolocal, @golesequipovisitante, @tirosequipolocal, @tirosequipovisitante, @posesionequipolocal, @posesionequipovisitante, @fkidpartido)";
                        // Crear el comando

                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                            cmd.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                            cmd.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                            cmd.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                            cmd.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                            cmd.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Datos ingresados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Datos ingresados a partido correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //sql insertar datos en futbol
                        string querypartido = @"INSERT INTO futbol (golesequipolocal, golesequipovisitante, tirosequipolocal, tirosequipovisitante, posesionequipolocal, posesionequipovisitante, fkidpartido) VALUES (@golesequipolocal, @golesequipovisitante, @tirosequipolocal, @tirosequipovisitante, @posesionequipolocal, @posesionequipovisitante, @fkidpartido)";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(querypartido, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                            cmd.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                            cmd.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                            cmd.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                            cmd.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                            cmd.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);
                            cmd.Parameters.AddWithValue("@fkidpartido", FkIdPartido);

                            // Ejecutar el comando
                            cmd.ExecuteNonQuery();

                            // Mostrar mensaje de éxito
                            MessageBox.Show("Datos ingresados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error: {ex.Message}");
                }

                Limpiar();
            }
        }

        private void CmbEstadoPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEstadoPartido.SelectedIndex != -1)
            {
                CmbGanadorEmpate.Enabled = true;
            }
        }

        private void CmbGanadorEmpate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGanadorEmpate.SelectedIndex != -1)
            {
                CmbCampeonato.Enabled = true;
            }
        }

        private void CmbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCampeonato.SelectedIndex != -1)
            {
                CmbFase.Enabled = true;
            }
        }

        private void CmbFase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFase.SelectedIndex != -1)
            {
                CmbArbitro.Enabled = true;
            }
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

        private void BtnVer_Click(object sender, EventArgs e)
        {
            DgvClasificacion.Visible = false;
            DgvFutbol.Visible = true;
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
                        f.golesequipolocal AS GolesLocal,
                        f.golesequipovisitante AS GolesVisitante,
                        f.tirosequipolocal AS TirosLocal,
                        f.tirosequipovisitante AS TirosVisitante,
                        f.posesionequipolocal AS PosesionLocal,
                        f.posesionequipovisitante AS PosesionVisitante,
                        f.pkidfutbol AS IDFutbol
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
                        futbol f ON partido.pkidpartido = f.fkidpartido";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvFutbol.DataSource = dt;
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
            Conexion conexion = new Conexion();
            CamposVacios();
            //Partido
            DateTime Fecha = DtpFecha.Value;
            int FkIdEquipoLocalId = Convert.ToInt32(CmbEquipoLocal.SelectedValue);
            int FkIdEquipoVisId = Convert.ToInt32(CmbEquipoVisitante.SelectedValue);
            string EstadoPartido = CmbEstadoPartido.Text;
            string Ganador = ((dynamic)CmbGanadorEmpate.SelectedItem).Valor.ToString();
            int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
            int FkIdFase = Convert.ToInt32(CmbFase.SelectedValue);
            int FkIdArbitro = Convert.ToInt32(CmbArbitro.SelectedValue);
            //Futbol
            int GolesEquipoLocal = Convert.ToInt32(NudGolesLocal.Value);
            int GolesEquipoVisitante = Convert.ToInt32(NudGolesVisitante.Value);
            int TirosEquipoLocal = Convert.ToInt32(NudTirosLocal.Value);
            int TirosEquipoVisitante = Convert.ToInt32(NudTirosVisitante.Value);
            int PosesionEquipoLocal = Convert.ToInt32(NudPosesionLocal.Value);
            int PosesionEquipoVisitante = Convert.ToInt32(NudPosesionVisitante.Value);
            //string FkIdPartido = TxtId.Text; 


            using (MySqlConnection conn = conexion.getConexion())
            {
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
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtId.Text);
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
                                string querypartido = @"UPDATE futbol SET golesequipolocal = @golesequipolocal, golesequipovisitante = @golesequipovisitante, tirosequipolocal = @tirosequipolocal, tirosequipovisitante = @tirosequipovisitante, posesionequipolocal = @posesionequipolocal, posesionequipovisitante = @posesionequipovisitante  WHERE pkidfutbol = @pkidfutbol";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidfutbol", TxtIdFutbol.Text);
                                    cmd2.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    MessageBox.Show("Datos modificados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
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
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, ganador = @ganadorlocal, ganadorlocal = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtId.Text);
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
                                string querypartido = @"UPDATE futbol SET golesequipolocal = @golesequipolocal, golesequipovisitante = @golesequipovisitante, tirosequipolocal = @tirosequipolocal, tirosequipovisitante = @tirosequipovisitante, posesionequipolocal = @posesionequipolocal, posesionequipovisitante = @posesionequipovisitante  WHERE pkidfutbol = @pkidfutbol";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidfutbol", TxtIdFutbol.Text);
                                    cmd2.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    MessageBox.Show("Datos modificados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
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
                        string query = $@"UPDATE partido SET fechahora = @fechahora, fkequipolocalid = @fkequipolocalid, fkequipovisid = @fkequipovisid, estadopartido = @estadopartido, empate = @ganadorlocal, ganadorlocal = @ganadorlocal, fkidcampeonato = @fkidcampeonato, fkidfase = @fkidfase, fkidarbitro = @fkidarbitro WHERE pkidpartido = @pkidpartido";
                        // Crear el comando
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Agregar los parámetros
                            cmd.Parameters.AddWithValue("@pkidpartido", TxtId.Text);
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
                                string querypartido = @"UPDATE futbol SET golesequipolocal = @golesequipolocal, golesequipovisitante = @golesequipovisitante, tirosequipolocal = @tirosequipolocal, tirosequipovisitante = @tirosequipovisitante, posesionequipolocal = @posesionequipolocal, posesionequipovisitante = @posesionequipovisitante  WHERE pkidfutbol = @pkidfutbol";
                                // Crear el comando
                                using (MySqlCommand cmd2 = new MySqlCommand(querypartido, conn))
                                {
                                    // Agregar los parámetros
                                    cmd2.Parameters.AddWithValue("@pkidfutbol", TxtIdFutbol.Text);
                                    cmd2.Parameters.AddWithValue("@golesequipolocal", GolesEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@golesequipovisitante", GolesEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@tirosequipolocal", TirosEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@tirosequipovisitante", TirosEquipoVisitante);
                                    cmd2.Parameters.AddWithValue("@posesionequipolocal", PosesionEquipoLocal);
                                    cmd2.Parameters.AddWithValue("@posesionequipovisitante", PosesionEquipoVisitante);

                                    // Ejecutar el comando
                                    cmd2.ExecuteNonQuery();

                                    // Mostrar mensaje de éxito
                                    MessageBox.Show("Datos modificados a futbol correctamente.", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                if (rowsAffected > 0)
                                {
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

        private void DgvFutbol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = DgvFutbol.CurrentRow.Cells[0].Value.ToString();
                DtpFecha.Text = DgvFutbol.CurrentRow.Cells[1].Value.ToString();
                CmbEquipoLocal.Text = DgvFutbol.CurrentRow.Cells[2].Value.ToString();
                CmbEquipoVisitante.Text = DgvFutbol.CurrentRow.Cells[3].Value.ToString();
                CmbCampeonato.Text = DgvFutbol.CurrentRow.Cells[4].Value.ToString();
                CmbFase.Text = DgvFutbol.CurrentRow.Cells[5].Value.ToString();
                CmbArbitro.Text = DgvFutbol.CurrentRow.Cells[6].Value.ToString();
                CmbEstadoPartido.Text = DgvFutbol.CurrentRow.Cells[7].Value.ToString();
                CmbGanadorEmpate.Text = DgvFutbol.CurrentRow.Cells[8].Value.ToString();
                NudGolesLocal.Text = DgvFutbol.CurrentRow.Cells[11].Value.ToString();
                NudGolesVisitante.Text = DgvFutbol.CurrentRow.Cells[12].Value.ToString();
                NudTirosLocal.Text = DgvFutbol.CurrentRow.Cells[13].Value.ToString();
                NudTirosVisitante.Text = DgvFutbol.CurrentRow.Cells[14].Value.ToString();
                NudPosesionLocal.Text = DgvFutbol.CurrentRow.Cells[15].Value.ToString();
                NudPosesionVisitante.Text = DgvFutbol.CurrentRow.Cells[16].Value.ToString();
                TxtIdFutbol.Text = DgvFutbol.CurrentRow.Cells[17].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            // Obtener el ID del partido que se desea eliminar
            int IdPartido = Convert.ToInt32(TxtId.Text);

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // Iniciar una transacción para asegurar la integridad de los datos
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Eliminar registros en la tabla futbol relacionados con el partido
                        string queryDeleteFutbol = @"DELETE FROM futbol WHERE fkidpartido = @fkidpartido";
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
                                    MessageBox.Show("Datos eliminados correctamente.", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                else
                                {
                                    //  mensaje si no se encontró el registro
                                    MessageBox.Show("No se encontro el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnClasificacion_Click(object sender, EventArgs e)
        {
            if (CmbCampeonato.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un campeonato.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DgvFutbol.Visible = false;
            DgvClasificacion.Visible = true;

            Conexion conexion = new Conexion();

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    /// string query = "SELECT * FROM vista_clasificacion ORDER BY puntos DESC, victorias DESC WHERE fkidcampeonato = @fkidcampeonato";
                    string query = "SELECT * FROM vista_clasificacion WHERE fkidcampeonato = @fkidcampeonato";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int FkIdCampeonato = Convert.ToInt32(CmbCampeonato.SelectedValue);
                        cmd.Parameters.AddWithValue("@fkidcampeonato", FkIdCampeonato);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DgvClasificacion.DataSource = dataTable;
                        }
                    }

                    // Opcional: Ajustar el ancho de las columnas
                    DgvClasificacion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la clasificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void NudPosesionLocal_ValueChanged(object sender, EventArgs e)
        {
            NudPosesionVisitante.ValueChanged -= NudPosesionVisitante_ValueChanged;
            NudPosesionVisitante.Value = 100 - NudPosesionLocal.Value;
            NudPosesionVisitante.ValueChanged += NudPosesionVisitante_ValueChanged;
        }

        private void NudPosesionVisitante_ValueChanged(object sender, EventArgs e)
        {
            NudPosesionLocal.ValueChanged -= NudPosesionLocal_ValueChanged;
            NudPosesionLocal.Value = 100 - NudPosesionVisitante.Value;
            NudPosesionLocal.ValueChanged += NudPosesionLocal_ValueChanged;
        }

        private void FormFutbol_Load(object sender, EventArgs e)
        {
            DgvClasificacion.Visible = false;


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

                BtnIngresar.Visible = true;
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
