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
    public partial class FormPartidosIndividuales : Form
    {
        public FormPartidosIndividuales()
        {
            InitializeComponent();
            CargarComboBoxLocal();
            CargarComboBoxVis();
            CargarComboBoxTorneo();

        }

        private void FormPartidosIndividuales_Load(object sender, EventArgs e)
        {
            CmbLocal.Text = "Seleccione un deportista local..";
            CmbVis.Text = "Seleccione un deportista visitante..";
            CmbTorneo.Text = "Seleccione un Torneo";
        }

        private void CargarComboBoxLocal()
        {
            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT pkidjugador, nombre FROM deportista";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        Dictionary<int, string> deportista = new Dictionary<int, string>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("pkidjugador");
                            string nombre = reader.GetString("nombre");
                            deportista.Add(id, nombre);
                        }

                        CmbLocal.DataSource = new BindingSource(deportista, null);
                        CmbLocal.DisplayMember = "Value";
                        CmbLocal.ValueMember = "Key";

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void CargarComboBoxVis()
        {
            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT pkidjugador, nombre FROM deportista";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        Dictionary<int, string> deportista = new Dictionary<int, string>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("pkidjugador");
                            string nombre = reader.GetString("nombre");
                            deportista.Add(id, nombre);
                        }

                        CmbVis.DataSource = new BindingSource(deportista, null);
                        CmbVis.DisplayMember = "Value";
                        CmbVis.ValueMember = "Key";

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void CargarComboBoxTorneo()
        {
            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT pkidtorneo, nombre FROM torneo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        Dictionary<int, string> deportista = new Dictionary<int, string>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32("pkidtorneo");
                            string nombre = reader.GetString("nombre");
                            deportista.Add(id, nombre);
                        }

                        CmbTorneo.DataSource = new BindingSource(deportista, null);
                        CmbTorneo.DisplayMember = "Value";
                        CmbTorneo.ValueMember = "Key";

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener el id del deportista local seleccionado
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            int fklocal = selectedLocal.Key;

            // Obtener el id del deportista visitante seleccionado
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            int fkVis = selectedVis.Key;

            // Obtener el id del torneo seleccionado
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;
            int fkTorneo = selectedTorneo.Key;

            string connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "INSERT INTO partidosindividuales (fkdeportistalocal, fkdeportistavisitante, fkidtorneo) " +
                           "VALUES (@fkdeportistalocal, @fkdeportistavisitante, @fkidtorneo)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fkdeportistalocal", fklocal);
                    command.Parameters.AddWithValue("@fkdeportistavisitante", fkVis);
                    command.Parameters.AddWithValue("@fkidtorneo", fkTorneo);

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


        private void limpiar()
        {
            TxtId.Text = string.Empty;
            CmbLocal.Text = "Seleccione un deportista local..";
            CmbVis.Text = "Seleccione un deportista visitante..";
            CmbTorneo.Text = "Seleccione un Torneo";
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=PoliDB;uid=root;pwd=1970;";
            string query = "SELECT * FROM partidosindividuales";

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
            CmbLocal.Text = GridVer.CurrentRow.Cells[1].Value.ToString();
            CmbVis.Text = GridVer.CurrentRow.Cells[2].Value.ToString();
            CmbTorneo.Text = GridVer.CurrentRow.Cells[3].Value.ToString();


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el id del deportista local seleccionado
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            int fklocal = selectedLocal.Key;

            // Obtener el id del deportista visitante seleccionado
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            int fkVis = selectedVis.Key;

            // Obtener el id del torneo seleccionado
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;
            int fkTorneo = selectedTorneo.Key;

            Conexion conexion = new Conexion();
            try
            {
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE partidosindividuales SET fkdeportistalocal = @fkdeportistalocal, fkdeportistavisitante = @fkdeportistavisitante, fkidtorneo= @fkidtorneo WHERE pkidsesion = @pkidsesion";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidsesion", TxtId.Text);
                        cmd.Parameters.AddWithValue("@fkdeportistalocal", fklocal);
                        cmd.Parameters.AddWithValue("@fkdeportistavisitante", fkVis);
                        cmd.Parameters.AddWithValue("@fkidtorneo", fkTorneo);



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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            Conexion conexion = new Conexion();

            try
            {

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM partidosindividuales WHERE pkidsesion = @pkidsesion";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidsesion", TxtId.Text);

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


