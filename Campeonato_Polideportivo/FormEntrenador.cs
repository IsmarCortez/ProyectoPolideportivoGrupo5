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
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormEntrenador()
        {
            InitializeComponent();
            CargarEquipos();
            CmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

       

        private void FormEntrenador_Load(object sender, EventArgs e)
        {
            CmbEquipo.Text = "Seleccione un equipo...";

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

        private void CargarEquipos()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkidequipo, nombre FROM equipo";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbEquipo.DataSource = dt;
                CmbEquipo.DisplayMember = "nombre";
                CmbEquipo.ValueMember = "pkidequipo";
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
            DateTime FechaNacimiento = DtpEntrenador.Value;
            string Nacionalidad = TxtNacionalidad.Text;
            int Equipo = Convert.ToInt32(CmbEquipo.SelectedValue);

            if (string.IsNullOrWhiteSpace(TxtNombre.Text)) //Para obligar a llenar los campos
            {
                MessageBox.Show("Por favor ingrese el nombre del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNacionalidad.Text))
            {
                MessageBox.Show("Por favor ingrese la nacionalidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                MessageBox.Show("Por favor ingrese el apellido del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO entrenador (nombre, apellido, fechanacimiento, nacionalidad, fkidequipo) VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad, @equipo)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fechanacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

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
                            entrenador.pkidentrenador AS IDEntrenador,
                            entrenador.Nombre AS Nombre, 
                            entrenador.Apellido AS Apellido, 
                            entrenador.fechanacimiento AS FechaDeNacimiento, 
                            entrenador.Nacionalidad AS Nacionalidad, 
                            equipo.Nombre AS EquipoNombre
                        FROM 
                            entrenador
                        JOIN 
                            equipo ON entrenador.fkidequipo = equipo.pkidequipo";

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
                if (string.IsNullOrWhiteSpace(TxtNombre.Text)) //Para obligar a llenar los campos
                {
                    MessageBox.Show("Por favor ingrese el nombre del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtNacionalidad.Text))
                {
                    MessageBox.Show("Por favor ingrese la nacionalidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtApellido.Text))
                {
                    MessageBox.Show("Por favor ingrese el apellido del entrenador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE Entrenador SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, nacionalidad = @nacionalidad, fkidequipo = @equipo WHERE pkidentrenador = @pkidentrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidentrenador", TxtID.Text);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fechanacimiento", FechaNacimiento);
                        cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                        cmd.Parameters.AddWithValue("@equipo", Equipo);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DtpEntrenador.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
                int identrenador = int.Parse(TxtID.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM Entrenador WHERE pkidentrenador = @pkidentrenador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidentrenador", identrenador);

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

        private void Limpiar(){
            TxtID.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            DtpEntrenador.Value = DateTime.Now;
            CmbEquipo.Text = "Seleccione un equipo...";
            TxtNacionalidad.Clear();
       }

        private void CmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
