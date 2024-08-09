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
    public partial class Empleados : Form
    {
        private Bitacora bitacora;
        Conexion conexion = new Conexion();
        private string connectionString;
        public Empleados()
        {
            InitializeComponent();
            txtUsuario.Text = GlobalVariables.usuario;

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //GlobalVariables.userId = 0;
            string nom = txtNombre.Text;
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            if (!string.IsNullOrEmpty(nom))
            {
                ;
                
                // Obtener el ID del usuario
                InsertarEmpleado(nom, usuarioId);
                bitacora.RegistrarEvento("Ingreso un nuevo Empleado", usuarioId);
                MessageBox.Show("Empleado guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre del empleado.");
            }


            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbPuesto.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAvenida.Text = string.Empty;
            txtZona.Text = string.Empty;
            cmbDepartamento.Text = string.Empty;
            txtCodPostal.Text = string.Empty;
            txtNumCasa.Text = string.Empty;

        }

        private void InsertarEmpleado(string nombre, int usuarioID)
        {
            Conexion conexion = new Conexion();

            string nom = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = cmbPuesto.Text;
            string telefono = txtTelefono.Text;
            string calle = txtCalle.Text;
            string avenida = txtAvenida.Text;
            string zona = txtZona.Text;
            string departamento = cmbDepartamento.Text;
            string codpostal = txtCodPostal.Text;
            string numcasa = txtNumCasa.Text;

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {

                    long direccionId;
                    long telefonoId;
                    long empleadoId;
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();


                    // Inserción en Empleado
                    string insertQuery = "INSERT INTO Empleado (nombre, apellido, puesto, fkidusuario) " +
                                         "VALUES (@nombre, @apellido, @puesto, @idusuario)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn, transaction))
                    {
                        //cmd.Parameters.AddWithValue("@idempleado", idempleado);
                        cmd.Parameters.AddWithValue("@nombre", nom);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@puesto", puesto);
                        cmd.Parameters.AddWithValue("@idusuario", usuarioID);
                        cmd.ExecuteNonQuery();
                        empleadoId = cmd.LastInsertedId;
                    }

                    // Inserción en Direccionempleado
                    string insertQuery2 = "INSERT INTO Direccionempleado (Calle, Avenida, Zona, Departamento, CodigoPostal, NumeroCasa) " +
                                          "VALUES (@calle, @avenida, @zona, @departamento, @codpostal, @numcasa)";
                    using (MySqlCommand cmd2 = new MySqlCommand(insertQuery2, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@calle", calle);
                        cmd2.Parameters.AddWithValue("@avenida", avenida);
                        cmd2.Parameters.AddWithValue("@zona", zona);
                        cmd2.Parameters.AddWithValue("@departamento", departamento);
                        cmd2.Parameters.AddWithValue("@codpostal", codpostal);
                        cmd2.Parameters.AddWithValue("@numcasa", numcasa);
                        cmd2.ExecuteNonQuery();
                        direccionId = cmd2.LastInsertedId;
                    }

                    // Inserción en Telefonoempleado
                    string insertQuery3 = "INSERT INTO Telefonoempleado (telefono) " +
                                          "VALUES (@telefono)";
                    using (MySqlCommand cmd3 = new MySqlCommand(insertQuery3, conn, transaction))
                    {
                        cmd3.Parameters.AddWithValue("@telefono", telefono);
                        cmd3.ExecuteNonQuery();
                        telefonoId = cmd3.LastInsertedId;
                    }

                    // Inserción en Empleado_Direccion
                    string insertQuery4 = "INSERT INTO Direccion_Empleado (fkiddireccion, fkidempleado) " +
                                          "VALUES (@fkiddireccion, @fkidusuario)";
                    using (MySqlCommand cmd4 = new MySqlCommand(insertQuery4, conn, transaction))
                    {
                        cmd4.Parameters.AddWithValue("@fkiddireccion", direccionId);
                        cmd4.Parameters.AddWithValue("@fkidusuario", empleadoId);
                        cmd4.ExecuteNonQuery();
                    }

                    // Inserción en Empleado_Telefono
                    string insertQuery5 = "INSERT INTO Telefono_Empleado (fkidtelefono, fkidempleado) " +
                                          "VALUES (@fkidtelefono, @fkidusuario)";
                    using (MySqlCommand cmd5 = new MySqlCommand(insertQuery5, conn, transaction))
                    {
                        cmd5.Parameters.AddWithValue("@fkidtelefono", telefonoId);
                        cmd5.Parameters.AddWithValue("@fkidusuario", empleadoId);
                        cmd5.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Asegurarse de que la conexión se cierra
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private int ObtenerIdUsuario(string nombreUsuario)
        {
            int usuarioId = 0;
            string query = "SELECT pkidusuario FROM usuario WHERE usuario = @nombreUsuario";

            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                using (var command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    usuarioId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return usuarioId;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaEmpleado";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dgvEmpleados.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvEmpleados.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

