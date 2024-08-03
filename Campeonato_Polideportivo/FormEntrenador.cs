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
    public partial class FormEntrenador : Form
    {
        public FormEntrenador()
        {
            InitializeComponent();
            CargarEquipos();
        }

        private void FormEntrenador_Load(object sender, EventArgs e)
        {
            CmbEquipo.Text = "Seleccione un equipo...";
        }

        private void CargarEquipos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT id_equipo, nombre FROM equipo";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbEquipo.DataSource = dt;
                CmbEquipo.DisplayMember = "nombre";
                CmbEquipo.ValueMember = "id_equipo";
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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string Nombre = TxtNombre.Text;
            string Apellido = TxtApellido.Text;
            //DateTime.TryParse(TxtFechaNacimiento.Text, out FechaNacimiento);
            DateTime FechaNacimiento = DtpEntrenador.Value;

            string Nacionalidad = TxtNacionalidad.Text;
            int Equipo = Convert.ToInt32(CmbEquipo.SelectedValue);


            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO entrenador (nombre, apellido, fecha_nacimiento, nacionalidad, id_equipo) VALUES (@nombre, @apellido, @fecha_nacimiento, @nacionalidad, @equipo)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Datos ingresados correctamente.");
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
            Conexion conexion = new Conexion();


            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    //  string query = "SELECT * FROM entrenador";

                    string query = @"
                        SELECT 
                            entrenador.id_entrenador,
                            entrenador.Nombre, 
                            entrenador.Apellido, 
                            entrenador.Fecha_Nacimiento, 
                            entrenador.Nacionalidad, 
                            equipo.Nombre AS EquipoNombre
                        FROM 
                            entrenador
                        JOIN 
                            equipo ON entrenador.id_equipo = equipo.id_equipo";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        dataGridView1.DataSource = dt;
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
                string Apellido = TxtApellido.Text;
               // DateTime.TryParse(TxtFechaNacimiento.Text, out FechaNacimiento);
                DateTime FechaNacimiento = DtpEntrenador.Value;
                string Nacionalidad = TxtNacionalidad.Text;
                int Equipo = Convert.ToInt32(CmbEquipo.SelectedValue);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE Entrenador SET nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento, nacionalidad = @nacionalidad, id_equipo = @equipo WHERE id_entrenador = @id_entrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@id_entrenador", TxtID.Text);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

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
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DtpEntrenador.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               // TxtFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtNacionalidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                CmbEquipo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

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
                int id_entrenador = int.Parse(TxtID.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM Entrenador WHERE id_entrenador = @id_entrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@id_entrenador", id_entrenador);

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
            Limpiar();
        }

        private void Limpiar(){
            TxtID.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            DtpEntrenador.Value = DateTime.Now;
            CmbEquipo.Text = "";
            TxtNacionalidad.Clear();
       }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
