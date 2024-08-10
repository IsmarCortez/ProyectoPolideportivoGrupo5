﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_Polideportivo
{
    public partial class FormCampeonato : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        private UsuarioValidator usuarioValidator;
        public FormCampeonato()
        {
            InitializeComponent();
            CargarDeportes();//mandamos a llamar la funcion la cual cargara los deportes existentes
            CmbDeporte.Text = "Seleccione un deporte...";
            CmbDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            usuarioValidator = new UsuarioValidator(connectionString);
        }

        private void CargarDeportes()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();

            string query = "SELECT pkiddeporte, nombre FROM deporte";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CmbDeporte.DataSource = dt;
                CmbDeporte.DisplayMember = "nombre";
                CmbDeporte.ValueMember = "pkiddeporte";
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
        private void Limpiar()
        {
            TxtIdCampeonato.Clear();
            TxtNombre.Clear();
            TxtTemporada.Clear();
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechaFin.Value = DateTime.Now;
            CmbDeporte.Text = "Seleccione un deporte...";
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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();

            string Nombre = TxtNombre.Text;
            string Temporada = TxtTemporada.Text;
            DateTime FechaInicio = DtpFechaInicio.Value;
            DateTime FechaFin = DtpFechaFin.Value;
            int Deporte = Convert.ToInt32(CmbDeporte.SelectedValue);

            // Verificar si el TextBox está lleno
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del deporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtTemporada.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del deporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                conn.Open();
                try
                {
                    // SQL insertar datos
                    string query = "INSERT INTO campeonato (nombre, temporada, fechainicio, fechafin, fkiddeporte) VALUES (@nombre, @temporada, @fechainicio, @fechafin, @fkiddeporte)";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@temporada", Temporada);
                        cmd.Parameters.AddWithValue("@fechainicio", FechaInicio);
                        cmd.Parameters.AddWithValue("@fechafin", FechaFin);
                        cmd.Parameters.AddWithValue("@fkiddeporte", Deporte);

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        bitacora.RegistrarEvento("Creó un nuevo Campeonato", usuarioId);
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
            Conexion conexion = new Conexion(); //  conexión mysql
            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    string query = @"
                        SELECT 
                            campeonato.pkidcampeonato AS ID,
                            campeonato.nombre AS Campeonato, 
                            campeonato.temporada AS Temporada, 
                            campeonato.fechainicio AS FechaInicio, 
                            campeonato.fechafin AS FechaFin, 
                            deporte.nombre AS Deporte
                        FROM 
                            campeonato
                        JOIN 
                            deporte ON campeonato.fkiddeporte = deporte.pkiddeporte";

                    // Crear el adaptador
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        // Crear un DataTable para almacenar los datos
                        DataTable dt = new DataTable();

                        // Llenar el DataTable con los datos obtenidos
                        adapter.Fill(dt);

                        // Asignar el DataTable como el origen de datos del DataGridView
                        DgvCampeonato.DataSource = dt;
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
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();
            try
            {
                // Obtener los datos de los TextBoxes
                string Nombre = TxtNombre.Text;
                string Temporada = TxtTemporada.Text;
                DateTime FechaInicio = DtpFechaInicio.Value;
                DateTime FechaFin = DtpFechaFin.Value;
                int Deporte = Convert.ToInt32(CmbDeporte.SelectedValue);

                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del deporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(TxtTemporada.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del deporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para actualizar datos
                    string query = "UPDATE campeonato SET nombre = @nombre, temporada = @temporada, fechainicio = @fechainicio, fechafin = @fechafin, fkiddeporte = @fkiddeporte WHERE pkidcampeonato = @pkidcampeonato";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar los parámetros
                        cmd.Parameters.AddWithValue("@pkidcampeonato", TxtIdCampeonato.Text);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@temporada", Temporada);
                        cmd.Parameters.AddWithValue("@fechainicio", FechaInicio);
                        cmd.Parameters.AddWithValue("@fechafin", FechaFin);
                        cmd.Parameters.AddWithValue("@fkiddeporte", Deporte);

                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                bitacora.RegistrarEvento("Modificó un campeonato", usuarioId);
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

        private void DgwCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdCampeonato.Text = DgvCampeonato.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgvCampeonato.CurrentRow.Cells[1].Value.ToString();
                TxtTemporada.Text = DgvCampeonato.CurrentRow.Cells[2].Value.ToString();
                DtpFechaInicio.Text = DgvCampeonato.CurrentRow.Cells[3].Value.ToString();
                DtpFechaFin.Text = DgvCampeonato.CurrentRow.Cells[4].Value.ToString();
                CmbDeporte.Text = DgvCampeonato.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            Conexion conexion = new Conexion();

            try
            {
                // Obtener el id_entrenador del TextBox
                int pkidcampeonato = int.Parse(TxtIdCampeonato.Text);

                // Crear la conexión
                using (MySqlConnection conn = conexion.getConexion())
                {
                    conn.Open();
                    // Crear la consulta SQL para eliminar datos
                    string query = "DELETE FROM campeonato WHERE pkidcampeonato = @pkidcampeonato";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar el parámetro
                        cmd.Parameters.AddWithValue("@pkidcampeonato", pkidcampeonato);

                        // Mostrar pregunta por si desea eliminar
                        DialogResult result = MessageBox.Show("¿Está seguro de que deseas eliminar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) // El usuario hizo clic en "Sí"
                        {                     
                            // Ejecutar el comando
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                bitacora.RegistrarEvento("Eliminó un campeonato", usuarioId);
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


        

        private void FormCampeonato_Load(object sender, EventArgs e)
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

                BtnIngresar.Visible = false;
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

            TxtNombre.TabIndex = 0;
            TxtTemporada.TabIndex = 1;
            DtpFechaInicio.TabIndex = 2;
            DtpFechaFin.TabIndex = 3;
            CmbDeporte.TabIndex = 4;
            BtnIngresar.TabIndex = 5;
            BtnVer.TabIndex = 6;
            BtnModificar.TabIndex = 7;
            BtnEliminar.TabIndex = 8;
            BtnAyuda.TabIndex = 9;
            DgvCampeonato.TabStop = false;
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            // Obtén la ruta del directorio base del proyecto
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Ruta al archivo PDF en la raíz del proyecto
            string pdfPath = Path.Combine(baseDirectory, "..", "..", "..", "manual.pdf");

            // Verifica la ruta construida
            string fullPath = Path.GetFullPath(pdfPath);
            MessageBox.Show($"Ruta del PDF: {fullPath}");

            // Número de página a la que deseas ir (comienza desde 1)
            int pageNumber = 33;

            // URL para abrir el PDF en una página específica
            string pdfUrl = $"file:///{fullPath.Replace('\\', '/')}#page={pageNumber}";

            // Escapa espacios en la URL
            pdfUrl = pdfUrl.Replace(" ", "%20");

            try
            {
                // Usa ProcessStartInfo para abrir el archivo con el programa asociado
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pdfUrl,
                    UseShellExecute = true  // Asegúrate de que UseShellExecute esté en true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el PDF. Error: {ex.Message}");
            }
        }
    }
}
