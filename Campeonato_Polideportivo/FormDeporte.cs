using MySqlConnector;
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
    public partial class FormDeporte : Form
    {
        public FormDeporte()
        {
            InitializeComponent();
            CargarComboBox();
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "INSERT INTO deporte (nombre, tipo, id_regla) VALUES (@nombre, @tipo, @id_regla)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", textBox1IngresoDepo.Text);
                    command.Parameters.AddWithValue("@tipo", textBox2IngresoTipo.Text);
                    command.Parameters.AddWithValue("@id_regla", Convert.ToInt32(textBox3Regla.Text));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Datos insertados exitosamente.");
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
            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "SELECT nombre FROM deporte";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CmbDeporte.Items.Add(reader.GetString("nombre"));
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "SELECT * FROM deporte";

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
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "SELECT * FROM deporte";

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
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "UPDATE deporte SET tipo = @tipo, id_regla = @idRegla WHERE nombre = @nombre";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", CmbDeporte.SelectedItem);
                    command.Parameters.AddWithValue("@tipo", textBox2IngresoTipo.Text);
                    command.Parameters.AddWithValue("@idRegla", int.Parse(textBox3Regla.Text));
                    command.Parameters.AddWithValue("@idDeporte", Convert.ToInt32(textBox3Regla.Text));

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro actualizado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=CampeonatoPolideportivo;uid=root;pwd=;";
            string query = "DELETE FROM deporte WHERE nombre = @nombre";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", CmbDeporte.SelectedItem);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado exitosamente.");
                            CargarComboBox(); // Recarga el ComboBox después de eliminar
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para eliminar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }
    }
}
