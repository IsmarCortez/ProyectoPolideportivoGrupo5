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
            // Obtener el id del deporte seleccionado
            var selectedDeporte = (KeyValuePair<int, string>)CmbDeporte.SelectedItem;
            int fkiddeporte = selectedDeporte.Key;

            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "INSERT INTO torneo (nombre, temporada, fechainicio, fechafin, fkiddeporte) " +
                "VALUES (@nombre, @temporada, @fechainicio, @fechafin, @fkiddeporte)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                    command.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                    command.Parameters.AddWithValue("@fechainicio", dateTimePickerFechaInicio.Value);
                    command.Parameters.AddWithValue("@fechafin", dateTimePickerFechafin.Value);
                    command.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);
                    // command.Parameters.AddWithValue("@fotografia", TxtSexo.Text);
                    //command.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value);


                    //  command.Parameters.AddWithValue("@id_regla", Convert.ToInt32(textBox3Regla.Text));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Datos insertados exitosamente.");
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void CargarComboBox()
        {
            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT pkiddeporte, nombre FROM deporte";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
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

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
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

            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT * FROM torneo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        /*dataTable.Columns.Add("Fotografia", Type.GetType("System.Byte[]"));
                        foreach (DataRow drow in dataTable.Rows) {

                            drow["fotografia"] = File.ReadAllBytes(drow["ImageFile"].ToString());
                        
                        
                        }*/






                        GridVer.DataSource = dataTable;





                        /*------------------------------*/





                        /*-------------------------------*/


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
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
            try
            {
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE torneo SET nombre = @nombre, temporada = @temporada, fechainicio = @fechainicio, fechafin = @fechafin, fkiddeporte= @fkiddeporte WHERE pkidtorneo = @pkidtorneo";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidtorneo", TxtId.Text);
                        cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@temporada", TxtTemporada.Text);
                        cmd.Parameters.AddWithValue("@fechainicio", dateTimePickerFechaInicio.Value);
                        cmd.Parameters.AddWithValue("@fechafin", dateTimePickerFechafin.Value);
                        cmd.Parameters.AddWithValue("@fkiddeporte", fkiddeporte);


                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se modificó algún registro
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de éxito
                            MessageBox.Show("Datos modificados correctamente.");
                        }
                        else
                        {
                            // Mostrar mensaje si no se encontró el registro
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
                        }
                    }
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
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
