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
    public partial class FormCampeonato : Form
    {
        public FormCampeonato()
        {
            InitializeComponent();
            CargarDeportes();//mandamos a llamar la funcion la cual cargara los deportes existentes
            CmbDeporte.Text = "Seleccione un deporte...";
        }

        private void CargarDeportes()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_deporte, nombre FROM deporte";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbDeporte.DataSource = dt;
                CmbDeporte.DisplayMember = "nombre";
                CmbDeporte.ValueMember = "id_deporte";
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
        private void Limpiar()
        {
            TxtIdCampeonato.Clear();
            TxtNombre.Clear();
            TxtTemporada.Clear();
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechaFin.Value = DateTime.Now;
            CmbDeporte.Text = "Seleccione un deporte...";
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string Nombre = TxtNombre.Text;
            string Temporada = TxtTemporada.Text;
            DateTime FechaInicio = DtpFechaInicio.Value;
            DateTime FechaFin = DtpFechaFin.Value;
            int Deporte = Convert.ToInt32(CmbDeporte.SelectedValue);

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO campeonato (nombre, temporada, fecha_inicio, fecha_fin, id_deporte) VALUES (@nombre, @temporada, @fecha_inicio, @fecha_fin, @id_deporte)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@temporada", Temporada);
                        cmd.Parameters.AddWithValue("@fecha_inicio", FechaInicio);
                        cmd.Parameters.AddWithValue("@fecha_fin", FechaFin);
                        cmd.Parameters.AddWithValue("@id_deporte", Deporte);

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
                            campeonato.id_campeonato AS ID,
                            campeonato.nombre AS Campeonato, 
                            campeonato.temporada AS Temporada, 
                            campeonato.fecha_inicio AS FechaInicio, 
                            campeonato.fecha_fin AS FechaFin, 
                            deporte.nombre AS Deporte
                        FROM 
                            campeonato
                        JOIN 
                            deporte ON campeonato.id_deporte = deporte.id_deporte";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgwCampeonato.DataSource = dt;
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
            try
            {
                // Obtener los datos de los TextBoxes
                string Nombre = TxtNombre.Text;
                string Temporada = TxtTemporada.Text;
                DateTime FechaInicio = DtpFechaInicio.Value;
                DateTime FechaFin = DtpFechaFin.Value;
                int Deporte = Convert.ToInt32(CmbDeporte.SelectedValue);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE campeonato SET nombre = @nombre, temporada = @temporada, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin, id_deporte = @id_deporte WHERE id_campeonato = @id_campeonato";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@id_campeonato", TxtIdCampeonato.Text);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@temporada", Temporada);
                        cmd.Parameters.AddWithValue("@fecha_inicio", FechaInicio);
                        cmd.Parameters.AddWithValue("@fecha_fin", FechaFin);
                        cmd.Parameters.AddWithValue("@id_deporte", Deporte);

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

        private void DgwCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdCampeonato.Text = DgwCampeonato.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgwCampeonato.CurrentRow.Cells[1].Value.ToString();
                TxtTemporada.Text = DgwCampeonato.CurrentRow.Cells[2].Value.ToString();
                DtpFechaInicio.Text = DgwCampeonato.CurrentRow.Cells[3].Value.ToString();
                DtpFechaFin.Text = DgwCampeonato.CurrentRow.Cells[4].Value.ToString();
                CmbDeporte.Text = DgwCampeonato.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                // Obtener el id_entrenador del TextBox
                int id_campeonato = int.Parse(TxtIdCampeonato.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM campeonato WHERE id_campeonato = @id_campeonato";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@id_campeonato", id_campeonato);

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
