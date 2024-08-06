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

    public partial class Form4login : Form
    {

        private Conexion FormConexion; //Variable creada para conectar la base de datos al iniciar
        public Form4login()
        {
            InitializeComponent();
            FormConexion = new Conexion();  //Se manda a llamar la conexion
            this.Load += new EventHandler(Form4login_Load); //evento para poner el programa en pantalla completa
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
                                                          //this.FormBorderStyle = FormBorderStyle.None; //esto es para quitar los bordes al maximizar
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

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            //Crea una nueva instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Recoge los datos de los TextBox

            //pruebas pendisntes
            GlobalVariables.usuario = TxtUsuario.Text;
            FormCampeonato formCampeonato = new FormCampeonato();


            string contrasenia = TxtContrasenia.Text;

            using (MySqlConnection conn = conexion.getConexion())
            {
                try
                {
                    bool tienePermisos = false;
                    bool esValido = false;
                    int userId = 0;

                    // Consulta para verificar permisos del usuario
                    string permisosQuery = "SELECT pkidusuario, fkpermisos, fkprivilegios FROM usuario WHERE usuario = @usuario";

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
                                userId = reader.GetInt32("pkidusuario");

                                // Verifica si los permisos son 1 y 1
                                if (fkPermisos == 1 && fkPrivilegios == 1)
                                {
                                    tienePermisos = true;
                                }

                            }
                        }

                        if (tienePermisos)
                        {
                            // Consulta para verificar usuario y contraseña
                            string credencialesQuery = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contrasenia = @contrasenia";

                            using (MySqlCommand credencialesCmd = new MySqlCommand(credencialesQuery, conn))
                            {
                                credencialesCmd.Parameters.AddWithValue("@usuario", GlobalVariables.usuario);
                                credencialesCmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                                int count = Convert.ToInt32(credencialesCmd.ExecuteScalar());
                                if (count > 0)
                                {
                                    esValido = true;
                                }
                            }

                            if (esValido)
                            {
                                // Actualizar iniciodesesion a true para activar el trigger
                                string actualizarInicioSesionQuery = "UPDATE usuario SET iniciosesion = @iniciosesion, ultimaconexion = @ultimaconexion WHERE pkidusuario = @userId";

                                using (MySqlCommand actualizarCmd = new MySqlCommand(actualizarInicioSesionQuery, conn))
                                {
                                    actualizarCmd.Parameters.AddWithValue("@iniciosesion", true);
                                    actualizarCmd.Parameters.AddWithValue("@ultimaconexion", DateTime.Now);
                                    actualizarCmd.Parameters.AddWithValue("@userId", userId);
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
                                MessageBox.Show("No puedes pasar, tu cuenta no existe!");
                            }
                        }
                        else
                        {
                            // Mensaje si el usuario no tiene permisos suficientes
                            MessageBox.Show("No tienes permisos suficientes para acceder a esta función.");
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
    }
    public static class GlobalVariables
    {
        public static string usuario { get; set; }
        public static int fkpermisos { get; set; }
        public static int fkprivilegios { get; set; }
        public static int pkidusuario { get; set; }

    }
}

