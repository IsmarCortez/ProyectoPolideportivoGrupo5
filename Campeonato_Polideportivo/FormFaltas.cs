﻿using MySql.Data.MySqlClient;
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
        private Conexion FormConexion;
        private string connectionString;
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
            CmbTarjeta.SelectedIndex = -1;
            CmbFalta.SelectedIndex = -1;
            CmbPartido.SelectedIndex = -1;
            CmbArbitro.SelectedIndex = -1;
            CmbEquipo.SelectedIndex = -1;
            CmbEquipo.Enabled = false;
            CmbArbitro.Enabled = false;
        }

        private void CargarPartidos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidpartido FROM partido";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbPartido.DataSource = dt;
                CmbPartido.DisplayMember = "pkidpartido";
                CmbPartido.ValueMember = "pkidpartido";
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
                        MessageBox.Show("No se encontraron jugadores para el equipo seleccionado.");
                    }
                    dt.Columns.Add("nombreCompleto", typeof(string), "nombre + ' ' + apellido");

                    // Configurar ComboBox
                    CmbJugador.DataSource = dt;
                    CmbJugador.DisplayMember = "nombreCompleto";
                    CmbJugador.ValueMember = "pkidjugador";
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

        private void CmbPartido_SelectedIndexChanged(object sender, EventArgs e) //metodo para que al seleccionar un dato se muestre en el otro combobox
        {
            if (CmbPartido.SelectedValue != null) 
            {
                string id_partido = CmbPartido.SelectedValue.ToString();
                CargarEquipos(id_partido);
            }
            if (CmbPartido.SelectedIndex != -1)
            {
                CmbEquipo.Enabled = true;
            }

        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEquipo.SelectedValue != null)
            {
                string id_equipo = CmbEquipo.SelectedValue.ToString();
                CargarJugadores(id_equipo);
            }
            if (CmbPartido.SelectedIndex != -1)
            {
                CmbJugador.Enabled = true;
            }
        }

        private void Limpiar()//metodo para limpiar todo el formulario al realizar alguna accion
        {
            TxtIdFaltas.Clear();
            TxtMinuto.Clear();
            CmbTarjeta.SelectedIndex = -1;
            CmbFalta.SelectedIndex = -1;
            CmbPartido.SelectedIndex = -1;
            CmbArbitro.SelectedIndex = -1;
            CmbEquipo.SelectedIndex = -1;
            CmbJugador.SelectedIndex = -1;
            CmbEquipo.Enabled = false;
            CmbJugador.Enabled = false;
            CmbArbitro.Enabled = false;
            TxtDescripcion.Clear();
            DtpFecha.Value = DateTime.Now;
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
            CamposVacios();

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO faltas (minuto, tarjeta, tipofalta, descripcion, fecha, fkidpartido, fkidjugador, fkidarbitro) VALUES (@minuto, @tarjeta, @tipofalta, @descripcion, @fecha, @fkidpartido, @fkidjugador, @fkidarbitro)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tarjeta", Tarjeta);
                        cmd.Parameters.AddWithValue("@tipofalta", TipoFalta);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fecha", Fecha);
                        cmd.Parameters.AddWithValue("@fkidpartido", IdPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", IdJugador);
                        cmd.Parameters.AddWithValue("@fkidarbitro", IdArbitro);

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
                        faltas.pkidfaltas AS ID,
                        faltas.minuto AS Minuto,
                        faltas.tarjeta AS Tarjeta,
                        faltas.tipofalta AS Tipo,
                        faltas.descripcion AS Descripcion,
                        faltas.fecha AS Fecha,
                        faltas.fkidpartido AS Partido,
                        equipo.nombre AS Equipo,
                        CONCAT(jugador.nombre, ' ', jugador.apellido) AS Jugador,
                        CONCAT(arbitro.nombre, ' ', arbitro.apellido) AS Arbitro
                    FROM 
                        faltas
                    JOIN 
                        jugador ON faltas.fkidjugador = jugador.pkidjugador
                    JOIN 
                        arbitro ON faltas.fkidarbitro = arbitro.pkidarbitro
                    JOIN 
                        equipo ON jugador.fkidequipo = equipo.pkidequipo;";

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
                CamposVacios();

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE faltas SET minuto = @minuto, tarjeta = @tarjeta, tipofalta = @tipofalta, descripcion = @descripcion, fecha = @fecha, fkidpartido = @fkidpartido, fkidjugador = @fkidjugador, fkidarbitro = @fkidarbitro WHERE pkidfaltas = @pkidfaltas";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidfaltas", TxtIdFaltas.Text);
                        cmd.Parameters.AddWithValue("@minuto", Minuto);
                        cmd.Parameters.AddWithValue("@tarjeta", Tarjeta);
                        cmd.Parameters.AddWithValue("@tipofalta", TipoFalta);
                        cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fecha", Fecha);
                        cmd.Parameters.AddWithValue("@fkidpartido", IdPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", IdJugador);
                        cmd.Parameters.AddWithValue("@fkidarbitro", IdArbitro);

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
                int pkidfaltas = int.Parse(TxtIdFaltas.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM faltas WHERE pkidfaltas = @pkidfaltas";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidfaltas", pkidfaltas);

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

        private void CamposVacios()
        {
            if (string.IsNullOrWhiteSpace(TxtMinuto.Text))//Para obligar a llenar los campos
            {
                MessageBox.Show("Por favor ingrese el minuto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbTarjeta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una tarjeta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbFalta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una falta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Por favor ingrese la descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbPartido.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un partido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbEquipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbJugador.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un jugador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbArbitro.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un arbitro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void CmbJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbJugador.SelectedIndex != -1)
            {
                CmbArbitro.Enabled = true;
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

        private void FormFaltas_Load(object sender, EventArgs e)
        {
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
    }
}
