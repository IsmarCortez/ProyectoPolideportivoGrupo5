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
        private Conexion FormConexion;
        private string connectionString;
        public FormPartidosIndividuales()
        {
            InitializeComponent();
            CargarComboBoxLocal();
            CargarComboBoxVis();
            CargarComboBoxTorneo();

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

        private void FormPartidosIndividuales_Load(object sender, EventArgs e)
        {
            CmbLocal.Text = "Seleccione un deportista local..";
            CmbVis.Text = "Seleccione un deportista visitante..";
            CmbTorneo.Text = "Seleccione un Torneo";

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

        private void CargarComboBox(ComboBox comboBox, string query)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = command.ExecuteReader();
                        Dictionary<int, string> items = new Dictionary<int, string>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            items.Add(id, nombre);
                        }
                        comboBox.DataSource = new BindingSource(items, null);
                        comboBox.DisplayMember = "Value";
                        comboBox.ValueMember = "Key";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarComboBoxLocal()
        {
            CargarComboBox(CmbLocal, "SELECT pkidjugador, nombre FROM deportista");
        }

        private void CargarComboBoxVis()
        {
            CargarComboBox(CmbVis, "SELECT pkidjugador, nombre FROM deportista");
        }

        private void CargarComboBoxTorneo()
        {
            CargarComboBox(CmbTorneo, "SELECT pkidtorneo, nombre FROM torneo");
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO partidosindividuales (fkdeportistalocal, fkdeportistavisitante, fkidtorneo) VALUES (@fkdeportistalocal, @fkdeportistavisitante, @fkidtorneo)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@fkdeportistalocal", selectedLocal.Key);
                        command.Parameters.AddWithValue("@fkdeportistavisitante", selectedVis.Key);
                        command.Parameters.AddWithValue("@fkidtorneo", selectedTorneo.Key);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
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
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM partidosindividuales";
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
            CmbLocal.Text = GridVer.CurrentRow.Cells[1].Value.ToString();
            CmbVis.Text = GridVer.CurrentRow.Cells[2].Value.ToString();
            CmbTorneo.Text = GridVer.CurrentRow.Cells[3].Value.ToString();


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var selectedLocal = (KeyValuePair<int, string>)CmbLocal.SelectedItem;
            var selectedVis = (KeyValuePair<int, string>)CmbVis.SelectedItem;
            var selectedTorneo = (KeyValuePair<int, string>)CmbTorneo.SelectedItem;

            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE partidosindividuales SET fkdeportistalocal = @fkdeportistalocal, fkdeportistavisitante = @fkdeportistavisitante, fkidtorneo = @fkidtorneo WHERE pkidsesion = @pkidsesion";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@pkidsesion", TxtId.Text);
                        command.Parameters.AddWithValue("@fkdeportistalocal", selectedLocal.Key);
                        command.Parameters.AddWithValue("@fkdeportistavisitante", selectedVis.Key);
                        command.Parameters.AddWithValue("@fkidtorneo", selectedTorneo.Key);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
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
                    conn.Open();
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


