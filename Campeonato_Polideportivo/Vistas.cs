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

namespace Campeonato_Polideportivo
{
    public partial class Vistas : Form
    {
        public Vistas()
        {
            InitializeComponent();
        }

        private void BtnEquipos_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaEquiposPorCampeonato";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaJugadoresPorEquipo";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosFutbol";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosBasketball";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosBaseball";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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
            // Crear una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaResultadosPartidosVolleyball";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaJugadoresSuspendidos";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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

            // Crear la consulta SQL para seleccionar datos de la vista
            string query = "SELECT * FROM VistaDatosPersonalesJugadores";

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
                    dgvVistas.DataSource = dataTable;

                    // Opcional: Ajustar automáticamente el ancho de las columnas
                    dgvVistas.AutoResizeColumns();
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "DatosExportados.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportarDataGridViewAPdf(dgvVistas, saveFileDialog.FileName);
                MessageBox.Show("Datos exportados correctamente a PDF.", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
