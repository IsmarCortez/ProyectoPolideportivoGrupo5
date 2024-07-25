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
        }
        private void Design() //Es una función para ocultar los paneles secundarios en el panel principal
        {
            PanelEquipos.Visible = false; //Se utiliza para ocultar los paneles
            PanelConsultar.Visible = false;
        }

        private void OcultarSubMenu()//Función para ocultar los paneles en caso esten abiertos 
        {
            if (PanelEquipos.Visible == true)
                PanelEquipos.Visible = false;
            if (PanelConsultar.Visible == true)
                PanelConsultar.Visible = false;
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

        private void button6_Click(object sender, EventArgs e)
        {
            abrirForm(new Form3());
            MostrarSubMenu(PanelEquipos);
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
            MostrarSubMenu(PanelConsultar);
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
            abrirForm(new Form3()); //para abrir el segundo formulario
            OcultarSubMenu(); //Función para que se esconda todo el submenu cuando se utilice alguno de esos botones
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
