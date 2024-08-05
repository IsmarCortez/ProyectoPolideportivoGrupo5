using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Campeonato_Polideportivo
{
    public partial class FormAnotaciones : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        public FormAnotaciones()
        {
            InitializeComponent();
          
        }

    
       private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                // Datos de entrada del usuario
                string minuto = TxtMinuto.Text; // Ejemplo: "45"
                string tipoAnotacion = TxtTipodeAnotacion.Text;
                int idPartido = int.Parse(TxtIdPartido.Text);
                int idJugador = int.Parse(TxtIdJugador.Text);
                int idAsistencia = int.Parse(TxtAsistencia.Text);
                string descripcion = TxtDescripcion.Text;

                // Conexión a la base de datos
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Consulta SQL para insertar datos
                    string query = "INSERT INTO anotaciones (minuto, tipoanotacion, fkidpartido, fkidjugador, fkidasistencia, descripcion) " +
                                   "VALUES (@minuto, @tipoanotacion, @fkidpartido, @fkidjugador, @fkidasistencia, @descripcion)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros con sus respectivos valores
                        cmd.Parameters.AddWithValue("@minuto", minuto);
                        cmd.Parameters.AddWithValue("@tipoanotacion", tipoAnotacion);
                        cmd.Parameters.AddWithValue("@fkidpartido", idPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", idJugador);
                        cmd.Parameters.AddWithValue("@fkidasistencia", idAsistencia);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Datos ingresados correctamente.");
                    }
                }
                // Habilitar el TextBox del ID de anotaciones para permitir futuras modificaciones
                TxtIdAnotaciones.Enabled = true;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {

        }

     
            private void BtnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();  // Conexión a la base de datos

            try
            {
                // Variables
                int idAnotaciones = int.Parse(TxtIdAnotaciones.Text);
                string minuto = TxtMinuto.Text;
                string tipoAnotacion = TxtTipodeAnotacion.Text;
                string descripcion = TxtDescripcion.Text;
                int idPartido = int.Parse(TxtIdPartido.Text);
                int idJugador = int.Parse(TxtIdJugador.Text);
                int idAsistencia = int.Parse(TxtAsistencia.Text);

                // Conexión a la base de datos
                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Consulta para modificar datos o actualizar
                    string query = "UPDATE anotaciones SET minuto = @minuto, tipoanotacion = @tipoanotacion, descripcion = @descripcion, " +
                                   "fkidpartido = @fkidpartido, fkidjugador = @fkidjugador, fkidasistencia = @fkidasistencia " +
                                   "WHERE pkidanotaciones = @pkidanotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@pkidanotaciones", idAnotaciones);
                        cmd.Parameters.AddWithValue("@minuto", minuto);
                        cmd.Parameters.AddWithValue("@tipoanotacion", tipoAnotacion);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@fkidpartido", idPartido);
                        cmd.Parameters.AddWithValue("@fkidjugador", idJugador);
                        cmd.Parameters.AddWithValue("@fkidasistencia", idAsistencia);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mensaje de datos modificados correctamente
                            MessageBox.Show("Datos modificados correctamente.");
                        }
                        else
                        {
                            // Mensaje si no se encontró el ID
                            MessageBox.Show("No se encontró la anotación con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

      private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            Conexion conexion = new Conexion();

            try
            {
                // Obtener el ID de la anotación a eliminar
                int pkidAnotaciones = int.Parse(TxtIdAnotaciones.Text);

                using (MySqlConnection conn = conexion.getConexion())
                {
                    // Consulta SQL para eliminar la anotación
                    string query = "DELETE FROM anotaciones WHERE pkidanotaciones = @pkidanotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro con su valor
                        cmd.Parameters.AddWithValue("@pkidanotaciones", pkidAnotaciones);

                        // Ejecutar el comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mensaje de datos eliminados correctamente
                            MessageBox.Show("Datos eliminados correctamente.");
                        }
                        else
                        {
                            // Mensaje si no se encontró el ID
                            MessageBox.Show("No se encontró la anotación con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mensaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {   // conexion BD
            Conexion conexion = new Conexion();

            try
            {
                using (MySqlConnection conn = conexion.getConexion())
                {
                    string query = "SELECT * FROM anotaciones";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            { // mesnaje de error
                MessageBox.Show($"Error: {ex.Message}");
            }
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

        private void FormAnotaciones_Load(object sender, EventArgs e)
        {
            // Deshabilitar el TextBox del ID de anotaciones al cargar el formulario
            TxtIdAnotaciones.Enabled = true;

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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            TxtIdAnotaciones.Text = string.Empty;
            TxtMinuto.Text = string.Empty;
            TxtTipodeAnotacion.Text = string.Empty;
            TxtIdPartido.Text = string.Empty;
            TxtIdJugador.Text = string.Empty;
            TxtAsistencia.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;


        }
    }
    }



  


