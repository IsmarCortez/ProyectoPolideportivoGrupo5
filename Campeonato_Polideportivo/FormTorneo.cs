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
    public partial class FormTorneo : Form
    {
        public FormTorneo()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var selectedDeporte = (KeyValuePair<int, string>)CmbDeporte.SelectedItem;
            int fkiddeporte = selectedDeporte.Key;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "INSERT INTO torneo (nombre, temporada, fechainicio, fechafin, fkiddeporte) " +
                                   "VALUES (@nombre, @temporada, @fechainicio, @fechafin, @fkiddeporte)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                        command.Parameters.AddWithValue("@fechainicio", dateTimePickerFechaInicio.Value);
                        command.Parameters.AddWithValue("@fechafin", dateTimePickerFechafin.Value);
                        command.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    limpiar();
                }
            }
        }

        private void CargarComboBox()
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "SELECT pkiddeporte, nombre FROM deporte";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        Dictionary<int, string> deportes = new Dictionary<int, string>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("pkiddeporte");
                            string nombre = reader.GetString("nombre");
                            deportes.Add(id, nombre);
                        }
                        CmbDeporte.DataSource = new BindingSource(deportes, null);
                        CmbDeporte.DisplayMember = "Value";
                        CmbDeporte.ValueMember = "Key";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void limpiar()
        {
            TxtId.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTemporada.Text = string.Empty;
            dateTimePickerFechaInicio.Value = DateTime.Now;
            dateTimePickerFechafin.Text = string.Empty;
            CmbDeporte.Text = "";
            // TxtSexo.Text = string.Empty;
            //PicFotografia.Image = null;
            //fotoBytes = null;
        }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "SELECT * FROM torneo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        GridVer.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = GridVer.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = GridVer.CurrentRow.Cells[1].Value.ToString();
            TxtTemporada.Text = GridVer.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerFechaInicio.Text = GridVer.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerFechafin.Text = GridVer.CurrentRow.Cells[4].Value.ToString();
            // TxtFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           // CmbDeporte.Text = GridVer.CurrentRow.Cells[5].Value.ToString();

            //PicFotografia.Text = GridVer.CurrentRow.Cells[6].Value.ToString();




        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var selectedDeporte = (KeyValuePair<int, string>)CmbDeporte.SelectedItem;
            int fkiddeporte = selectedDeporte.Key;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "UPDATE torneo SET nombre = @nombre, temporada = @temporada, fechainicio = @fechainicio, fechafin = @fechafin, fkiddeporte = @fkiddeporte WHERE pkidtorneo = @pkidtorneo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@pkidtorneo", TxtId.Text);
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                        command.Parameters.AddWithValue("@fechainicio", dateTimePickerFechaInicio.Value);
                        command.Parameters.AddWithValue("@fechafin", dateTimePickerFechafin.Value);
                        command.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    limpiar();
                }
            }
        }

        private void FormTorneo_Load(object sender, EventArgs e)
        {
            CmbDeporte.Text = "Seleccione un deporte...";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();

            try
            {

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM torneo WHERE pkidtorneo = @pkidtorneo";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidtorneo", TxtId.Text);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se eliminó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de que si se elimino
                            MessageBox.Show("Datos eliminados correctamente.");
                        }
                        else
                        {
                            //  mensaje si no se encontró el registro
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
            limpiar();
        }
    }
}
