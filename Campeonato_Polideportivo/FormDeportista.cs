using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_Polideportivo
{

    public partial class FormDeportista : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private byte[] fotoBytes;
        public FormDeportista()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "INSERT INTO deportista (nombre, apellido, fechanacimiento, nacionalidad, sexo, fotografia) " +
                                   "VALUES (@nombre, @apellido, @fechanacimiento, @nacionalidad, @sexo, @fotografia)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                        command.Parameters.AddWithValue("@fechanacimiento", dateTimePickerDepor.Value);
                        command.Parameters.AddWithValue("@nacionalidad", TxtNacionalidad.Text);
                        command.Parameters.AddWithValue("@sexo", TxtSexo.Text);
                        command.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value);

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

        private void PicFotografia_Click(object sender, EventArgs e)
        {

        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filepath = openFileDialog.FileName;
                fotoBytes = File.ReadAllBytes(filepath);
                PicFotografia.Image = new Bitmap(filepath);
            
            }




        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = "SELECT * FROM deportista";
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


        private void BtnModificar_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            try
            {
                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE deportista SET nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, nacionalidad = @nacionalidad, sexo= @sexo, fotografia=@fotografia WHERE pkidjugador = @pkidjugador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidjugador", textID.Text);
                        cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", TxtApellido.Text);
                        cmd.Parameters.AddWithValue("@fechanacimiento", dateTimePickerDepor.Value);
                        cmd.Parameters.AddWithValue("@nacionalidad", TxtNacionalidad.Text);
                        cmd.Parameters.AddWithValue("@sexo", TxtSexo.Text);
                        cmd.Parameters.AddWithValue("@fotografia", (object)fotoBytes ?? DBNull.Value);

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

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }









        private void limpiar()
        {
            textID.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            dateTimePickerDepor.Value = DateTime.Now;
            TxtNacionalidad.Text = string.Empty;
            TxtSexo.Text = string.Empty;
            PicFotografia.Image = null;
            fotoBytes = null;
        }

        private void GridVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = GridVer.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = GridVer.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = GridVer.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerDepor.Text = GridVer.CurrentRow.Cells[3].Value.ToString();
                // TxtFechaNacimiento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtNacionalidad.Text = GridVer.CurrentRow.Cells[4].Value.ToString();
                TxtSexo.Text = GridVer.CurrentRow.Cells[5].Value.ToString();
                //PicFotografia.Text = GridVer.CurrentRow.Cells[6].Value.ToString();

                PicFotografia.SizeMode = PictureBoxSizeMode.Zoom;
                if (e.RowIndex >= 0 && GridVer.Columns.Contains("fotografia"))
                {
                    DataGridViewRow row = GridVer.Rows[e.RowIndex];
                    if (row.Cells["fotografia"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row.Cells["fotografia"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {

                            PicFotografia.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        PicFotografia.Image = null;
                    }
                }



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

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM deportista WHERE pkidjugador = @pkidjugador";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidjugador", textID.Text);

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

        private void FormDeportista_Load(object sender, EventArgs e)
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
