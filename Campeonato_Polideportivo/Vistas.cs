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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
// Código hecho por Brandon Boch 0901-21-13093
namespace Campeonato_Polideportivo
{
    public partial class Vistas : Form
    {
        private string connectionString;
        public Vistas()
        {
            InitializeComponent();
        }
        private int ObtenerIdUsuario(string nombreUsuario)
        {
            Conexion conexion = new Conexion();
            int usuarioId = 0;
            Bitacora bitacora = new Bitacora(connectionString);
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

        private void BtnEquipos_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaEquiposPorCampeonato";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de equipos por campeonatos", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnJugador_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaJugadoresPorEquipo";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de jugador por equipo", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            }

        private void BtnFutbol_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosFutbol";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de partidos de futball", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnBasket_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosBasketball";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de partidos de basketball", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnBaseball_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosBaseball";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de partidos de baseball", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnVoleybol_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosVolleyball";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de partidos de voleyball", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnSuspendido_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaJugadoresSuspendidos";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de jugadores suspendidos", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnPerJugador_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaDatosPersonalesJugadores";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de datos del jugador", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

 

public void ExportarDataGridViewAPdf(DataGridView dataGridView, string nombreArchivo)
    {
        // Crear un documento PDF
        Document documento = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

        // Configurar el escritor de PDF
        PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));

        // Abrir el documento para escribir
        documento.Open();

        // Crear una tabla en el PDF con el mismo número de columnas que el DataGridView
        PdfPTable tabla = new PdfPTable(dataGridView.ColumnCount);
        tabla.WidthPercentage = 100;

        // Agregar los encabezados de columna al PDF
        foreach (DataGridViewColumn columna in dataGridView.Columns)
        {
            PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText));
            celda.BackgroundColor = BaseColor.LIGHT_GRAY;
            tabla.AddCell(celda);
        }

        // Agregar las filas de datos al PDF
        foreach (DataGridViewRow fila in dataGridView.Rows)
        {
            foreach (DataGridViewCell celda in fila.Cells)
            {
                tabla.AddCell(celda.Value?.ToString() ?? "");
            }
        }

        // Agregar la tabla al documento PDF
        documento.Add(tabla);

        // Cerrar el documento
        documento.Close();
    }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "DatosExportados.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitacora.RegistrarEvento("Generó un PDF de una vista", usuarioId);
                ExportarDataGridViewAPdf(DgvVistas, saveFileDialog.FileName);
                MessageBox.Show("Datos exportados correctamente a PDF.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaBitacora";

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bitacora.RegistrarEvento("Generó una vista de bitacora", usuarioId);
                    conn.Open(); // Abrir la conexión

                    // Crear un adaptador de datos para ejecutar la consulta
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    DgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    DgvVistas.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Vistas_Load(object sender, EventArgs e)
        {
            //Maximizar la ventana
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

                BtnEquipos.Visible = false;
                BtnJugador.Visible = false;
                BtnFutbol.Visible = false;
                BtnSuspendido.Visible = false;
                BtnBitacora.Visible = false;
                BtnBasket.Visible = false;
                BtnVoleybol.Visible = false;
                BtnPdf.Visible = false;
                BtnSuspendido.Visible = false;
                BtnPerJugador.Visible = false;
            }
            else if (nivelDeAcceso == 2)
            {

                BtnEquipos.Visible = true;
                BtnJugador.Visible = true;
                BtnFutbol.Visible = true;
                BtnSuspendido.Visible = true;
                BtnBitacora.Visible = false;
                BtnBasket.Visible = true;
                BtnVoleybol.Visible = true;
                BtnPdf.Visible = true;
                BtnSuspendido.Visible = true;
                BtnPerJugador.Visible = true;
            }
            else if (nivelDeAcceso == 3)
            {
                BtnEquipos.Visible = true;
                BtnJugador.Visible = true;
                BtnFutbol.Visible = true;
                BtnSuspendido.Visible = true;
                BtnBitacora.Visible = true;
                BtnBasket.Visible = true;
                BtnVoleybol.Visible = true;
                BtnPdf.Visible = true;
                BtnSuspendido.Visible = true;
                BtnPerJugador.Visible = true;
            }
            else
            {
                // Si el nivel de acceso no está definido (por ejemplo, usuario no encontrado)
                BtnEquipos.Visible = false;
                BtnJugador.Visible = false;
                BtnFutbol.Visible = false;
                BtnSuspendido.Visible = false;
                BtnBitacora.Visible = false;
                BtnBasket.Visible = false;
                BtnVoleybol.Visible = false;
                BtnPdf.Visible = false;
                BtnSuspendido.Visible = false;
                BtnPerJugador.Visible = false;
            }
            BtnEquipos.TabIndex = 0;
            BtnJugador.TabIndex = 1;
            BtnSuspendido.TabIndex = 2;
            BtnBitacora.TabIndex = 3;
            BtnPerJugador.TabIndex = 4;
            BtnPdf.TabIndex = 5;
            BtnFutbol.TabIndex = 6;
            BtnBasket.TabIndex = 7;
            BtnBaseball.TabIndex = 8;
            BtnVoleybol.TabIndex = 9;
            DgvVistas.TabStop = false;
        }
    }
}
