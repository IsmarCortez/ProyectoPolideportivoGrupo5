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
using System.Security.Cryptography;

namespace Campeonato_Polideportivo
{

    public partial class Form4login : Form
    {
        private Bitacora bitacora;
        private string connectionString;
        private Conexion FormConexion; //Variable creada para conectar la base de datos al iniciar
        public Form4login()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            this.Load += new EventHandler(Form4login_Load); //evento para poner el programa en pantalla completa
            // Asociar el evento KeyPress
            TxtContrasenia.KeyPress += TxtContrasenia_KeyPress;
            bitacora = new Bitacora(connectionString);
            this.FormClosing += new FormClosingEventHandler(Form4login_FormClosing);
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            //Aqui iria el login
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormConexion.getConexion() != null)
            {
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void Form4login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //maximiza el programa
            FormConexion = new Conexion();  //Se manda a llamar la conexion
            this.Load += new EventHandler(Form4login_Load);
        }

        private Form FormActivo = null; //Se cierra el formulario activo
        private void abrirForm(Form Form1)
        {
            if (FormActivo != null) // si existe un formulario activo
                FormActivo.Close(); // se cierra
            FormActivo = Form1; // se almacena el formulario activo al cerrar el otro formulario
            Form1.TopLevel = false; // el formulario se comportara como un control
            Form1.FormBorderStyle = FormBorderStyle.None; // se quita el borde del formulario
            Form1.Dock = DockStyle.Fill; // se rellena todo el panel del formulario
            PanelForm.Controls.Add(Form1); // se añade el formulario al panel 
            PanelForm.Tag = Form1; // se asocia el formulario con el panel contenedor
            Form1.BringToFront(); // para añadir logotipo
            Form1.Show(); // se muestra el formulario

        }

  
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llblAdmin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirForm(new Administrador());
        }

        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();
            

            // Recoge los datos de los TextBox
            GlobalVariables.usuario = TxtUsuario.Text;
            string contrasenia = TxtContrasenia.Text;
            string contraseniaHashIngresada = GetSHA256Hash(contrasenia);

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bool tienePermisos = false;
                    bool esValido = false;
                    GlobalVariables.userId = 0;

                    Bitacora bitacora = new Bitacora(connectionString);

                    // Consulta para verificar permisos del usuario
                    string permisosQuery = "SELECT pkidusuario, fkpermisos, fkprivilegios, contrasenia FROM usuario WHERE usuario = @usuario";

                    using (MySqlCommand permisosCmd = new MySqlCommand(permisosQuery, conn))
                    {
                        permisosCmd.Parameters.AddWithValue("@usuario", GlobalVariables.usuario);

                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open(); // Abrir la conexión solo si está cerrada
                        }

                        using (MySqlDataReader reader = permisosCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lee los permisos del usuario
                                int fkPermisos = reader.GetInt32("fkpermisos");
                                int fkPrivilegios = reader.GetInt32("fkprivilegios");

                                // Guarda el pkidusuario
                                GlobalVariables.userId = reader.GetInt32("pkidusuario");

                                // Obtiene el hash de la contraseña almacenada en la base de datos
                                string contraseniaAlmacenada = reader.GetString("contrasenia");


                                // Verifica si los permisos son 1 y 1
                                if (fkPermisos == 1 && fkPrivilegios == 1)
                                {
                                    tienePermisos = true;
                                }

                                // Verifica la contraseña ingresada contra la contraseña almacenada en la base de datos
                                esValido = (contraseniaHashIngresada == contraseniaAlmacenada);
                            }
                        }

                        if (tienePermisos && esValido)
                        {
                            bitacora.RegistrarEvento("Inicio de sesión exitoso.", GlobalVariables.userId);

                            // Actualizar iniciodesesion a true para activar el trigger
                            string actualizarInicioSesionQuery = "UPDATE usuario SET iniciosesion = @iniciosesion, ultimaconexion = @ultimaconexion WHERE pkidusuario = @userId";

                            using (MySqlCommand actualizarCmd = new MySqlCommand(actualizarInicioSesionQuery, conn))
                            {
                                actualizarCmd.Parameters.AddWithValue("@iniciosesion", true);
                                actualizarCmd.Parameters.AddWithValue("@ultimaconexion", DateTime.Now);
                                actualizarCmd.Parameters.AddWithValue("@userId", GlobalVariables.userId);
                                actualizarCmd.ExecuteNonQuery();
                            }

                            // Acción a realizar si el usuario y la contraseña son válidos
                            Form1 obj = new Form1();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Acción a realizar si el usuario y/o la contraseña no son válidos
                            MessageBox.Show("No puedes pasar, contraseña incorrecta ó tu cuenta no existe");
                            bitacora.RegistrarEvento("Intento de inicio de sesión fallido.", GlobalVariables.userId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error: {ex.Message}");
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

        private void llblCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirForm(new CrearCuenta());
        }

        private void TxtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Evita el beep cuando se presiona Enter
                e.Handled = true;
                // Llama al método del botón como si se hubiera hecho clic en él
                BtnIngresar_Click(sender, e);
            }
        }
        public static class GlobalState
        {
            public static bool HasConfirmedExit = false;
        }
        private void Form4login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobalState.HasConfirmedExit)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre del formulario
                }
                else
                {
                    GlobalState.HasConfirmedExit = true; // Marca que el mensaje ha sido mostrado
                    Application.Exit(); // Asegúrate de que toda la aplicación se cierre
                }
            }
        }
    }
    public static class GlobalVariables
    {
        public static string usuario { get; set; }
        public static int fkpermisos { get; set; }
        public static int fkprivilegios { get; set; }
        public static int pkidusuario { get; set; }
        public static int userId { get; set; }
    }
}

