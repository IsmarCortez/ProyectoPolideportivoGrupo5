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
    public partial class Form1 : Form
    {
        private Conexion FormConexion;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            Design(); //Se manda a llamar la función luego de inicializar los componentes
            this.Load += new EventHandler(Form1_Load); //evento para poner el programa en pantalla completa
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Design() //Es una función para ocultar los paneles secundarios en el panel principal
        {
            PanelColectivo.Visible = false;//Se utiliza para ocultar los paneles
            PanelIndividual.Visible = false;
            PanelPartido.Visible = false;
        }

        private void OcultarSubMenu()//Función para ocultar los paneles en caso esten abiertos 
        {

           if (PanelColectivo.Visible == true)
                PanelColectivo.Visible = false;
            if (PanelIndividual.Visible == true)
                PanelIndividual.Visible = false;
            if (PanelPartido.Visible == true)
                PanelPartido.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)//Función que muestra o esconde el subpanel
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public class UsuarioValidator
        {

            public string connectionString;

            public UsuarioValidator(string connectionString)
            {
                this.connectionString = connectionString;
            }
            public int ObtenerNivelDeAcceso(string usuario)
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

                                // Determinar el nivel de acceso basado en fkpermisos y fkprivilegios
                                if (fkpermisos == 1 && fkprivilegios == 1)
                                {
                                    return 1; // Nivel de acceso bajo (ocultar ambos botones)
                                }
                                else if (fkpermisos == 2 && fkprivilegios == 2) 
                                {
                                    return 2; // Nivel de acceso medio/alto (mostrar BtnRegistro, ocultar button3)
                                }
                                else if (fkpermisos == 3 && fkprivilegios == 3)
                                {
                                    return 3; // Nivel de acceso alto (mostrar ambos botones)
                                }
                            }
                        }
                    }
                }

                // Si no se encontró el usuario
                return 0; // Nivel de acceso no determinado
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
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
                // Ocultar ambos botones
                BtnRegistro.Visible = false;
                button3.Visible = false;
            }
            else if (nivelDeAcceso == 2)
            {
                // Mostrar BtnRegistro y ocultar button3
                BtnRegistro.Visible = false;
                button3.Visible = true;
            }
            else if (nivelDeAcceso == 3)
            {
                // Mostrar ambos botones
                BtnRegistro.Visible = true;
                button3.Visible = true;
            }
            else
            {
                // Si el nivel de acceso no está definido (por ejemplo, usuario no encontrado)
                BtnRegistro.Visible = false;
                button3.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MostrarSubMenu(PanelButton1); Se manda a llamar el evento de mostrar con el panel que le pertenece al boton

            if (FormActivo != null) // si existe un formulario activo
                FormActivo.Close(); // se cierra
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
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

        private void button16_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelColectivo);
        }

       
        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormDeporte()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquipos_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeporte_Click(object sender, EventArgs e)
        {
            abrirForm(new FormDeporte()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnDeporte_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormDeporte()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnEquipo_Click(object sender, EventArgs e)
        {
            abrirForm(new FormEquipo()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnDeporte1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquipo2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEquipo_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormEquipo()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new FormJugador()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnEntrenador_Click(object sender, EventArgs e)
        {
            abrirForm(new FormEntrenador()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnArbitro_Click(object sender, EventArgs e)
        {
            abrirForm(new FormArbitro()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnCampeonato_Click(object sender, EventArgs e)
        {
            abrirForm(new FormCampeonato()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            abrirForm(new FormAsistencia()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnAnotaciones_Click(object sender, EventArgs e)
        {
            abrirForm(new FormAnotaciones()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnFaltas_Click(object sender, EventArgs e)
        {
            abrirForm(new FormFaltas()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void BtnEquipos_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelColectivo);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelColectivo);
        }

        private void BtnFutbol_Click(object sender, EventArgs e)
        {
            abrirForm(new FormEquipo());
        }

        private void BtnBasquetbol_Click(object sender, EventArgs e)
        {
            abrirForm(new FormJugador());
        }

        private void BtnVoleibol_Click(object sender, EventArgs e)
        {
            abrirForm(new FormEntrenador());
        }

        private void BtnBeisbol_Click(object sender, EventArgs e)
        {
            abrirForm(new FormArbitro());
        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {
            abrirForm(new FormCampeonato());
        }

        private void BtnFutbol_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormFutbol());
        }



        private void BtnAsistencia_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormAsistencia());
        }

        private void BtnAnotaciones_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormAnotaciones());
        }

        private void BtnFaltas_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormFaltas());
        }

        private void BtnDeportista_Click(object sender, EventArgs e)
        {
            abrirForm(new FormDeportista());
        }

        private void BtnIndividual_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelIndividual);
        }

        private void BtnPartido_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelPartido);
        }

        private void BtnTorneo_Click(object sender, EventArgs e)
        {
            abrirForm(new FormTorneo());
        }

        private void BtnPartidosIndividuales_Click(object sender, EventArgs e)
        {
            abrirForm(new FormPartidosIndividuales());
        }

        private void BtnFutbol_Click_2(object sender, EventArgs e)
        {
            abrirForm(new FormFutbol());
        }

        private void BtnBasquetbol_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormBasquetbol());
        }

        private void BtnVoleibol_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormVoleibol());
        }

        private void BtnBeisbol_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormBeisbol());
        }

        private void BtnOtros_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click_2(object sender, EventArgs e)
        {
            abrirForm(new Empleados());
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelRegistro);
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            abrirForm(new Usuarios());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            abrirForm(new Vistas());
        }

        private void BtnAsistencia_Click_2(object sender, EventArgs e)
        {
            abrirForm(new FormAsistencia());
        }

        private void BtnAnotaciones_Click_2(object sender, EventArgs e)
        {
            abrirForm(new FormAnotaciones());
        }

        private void BtnFaltas_Click_2(object sender, EventArgs e)
        {
            abrirForm(new FormFaltas());
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
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form4login mainForm = new Form4login(); // Crea una instancia del formulario principal
            mainForm.Show(); // Muestra el formulario principal
            this.Hide(); // Oculta el formulario de inicio de sesión
            Bitacora bitacora = new Bitacora(connectionString);
            int usuarioId;
            usuarioId = ObtenerIdUsuario(GlobalVariables.usuario);
            bitacora.RegistrarEvento("Cerró Sesión", usuarioId);
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
       
        }
    }
}
