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
    public partial class FormDeporte : Form
    {
        public FormDeporte()
        {
            InitializeComponent();
            CargarComboBox();
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "INSERT INTO deporte (nombre, tipo, id_regla) VALUES (@nombre, @tipo, @id_regla)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", textBox1IngresoDepo.Text);
                        command.Parameters.AddWithValue("@tipo", textBox2IngresoTipo.Text);
                        command.Parameters.AddWithValue("@id_regla", Convert.ToInt32(textBox3Regla.Text));

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void CargarComboBox()
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                string query = "SELECT nombre FROM deporte";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    try
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        CmbDeporte.Items.Clear(); // Limpiar los elementos existentes
                        while (reader.Read())
                        {
                            CmbDeporte.Items.Add(reader.GetString("nombre"));
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                string query = "SELECT * FROM deporte";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                string query = "SELECT * FROM deporte";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                string query = "UPDATE deporte SET tipo = @tipo, id_regla = @idRegla WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombre", CmbDeporte.SelectedItem);
                    command.Parameters.AddWithValue("@tipo", textBox2IngresoTipo.Text);
                    command.Parameters.AddWithValue("@idRegla", int.Parse(textBox3Regla.Text));

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                string query = "DELETE FROM deporte WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombre", CmbDeporte.SelectedItem);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarComboBox(); // Recarga el ComboBox después de eliminar
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            

        }
        }

        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
