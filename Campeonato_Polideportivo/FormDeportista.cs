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
        private UsuarioValidator usuarioValidator;
        public FormDeportista()
        {
            InitializeComponent();

            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open();
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

       

        private void FormDeportista_Load(object sender, EventArgs e)
        {
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
    }
}
