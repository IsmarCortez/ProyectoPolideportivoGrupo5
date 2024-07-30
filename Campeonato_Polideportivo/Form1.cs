using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato_Polideportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Design(); //Se manda a llamar la función luego de inicializar los componentes
            this.Load += new EventHandler(Form1_Load); //evento para poner el programa en pantalla completa
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //  LblTitulo.BackColor = Color.Transparent; //Para que los label no tengan un fondo de color
            // LblTitulo2.BackColor = Color.Transparent;

            this.WindowState = FormWindowState.Maximized; //maximiza el programa
            //this.FormBorderStyle = FormBorderStyle.None; //esto es para quitar los bordes al maximizar
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

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
         // MostrarSubMenu(PanelButton1); Se manda a llamar el evento de mostrar con el panel que le pertenece al boton
            abrirForm(new Form2());
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
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
            abrirForm(new FormOtrosPartidos());

        }
    }
}
