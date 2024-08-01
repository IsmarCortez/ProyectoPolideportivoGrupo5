using MySql.Data.MySqlClient;
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
    public partial class FormFutbol : Form
    {
        public FormFutbol()
        {
            InitializeComponent();
            CargarEquiposLocal();
            CargarEquiposVisitante();
            CargarEstadoPartido();
            CmbEstadoPartido.Text = "Seleccione un estado...";
            CmbArbitro.DropDownStyle = ComboBoxStyle.DropDownList;//para que no cambien el contenido
            CmbCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEstadoPartido.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFase.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGanadorEmpate.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private DataTable todosLosEquipos; // se crea una DataTable la cual tendra todos los equipos para luego aplicar lo requerido

        private void CargarEquiposLocal()
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.getConexion();
            string query = "SELECT id_equipo, nombre FROM equipo";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                todosLosEquipos = new DataTable();
                adapter.Fill(todosLosEquipos); //Se llena la tabla con los datos obtenidos
                CmbEquipoLocal.DataSource = new DataTable(); //Se crea una nueva DataTable vacía y la asigna como fuente de datos para el ComboBox de equipo local.
                ((DataTable)CmbEquipoLocal.DataSource).Columns.Add("id_equipo", typeof(int));//Se crean dos columnas una con id_equipo y otra con nombre
                ((DataTable)CmbEquipoLocal.DataSource).Columns.Add("nombre", typeof(string));
                foreach (DataRow row in todosLosEquipos.Rows)
                {
                    ((DataTable)CmbEquipoLocal.DataSource).Rows.Add(row.ItemArray);
                }
                CmbEquipoLocal.DisplayMember = "nombre";
                CmbEquipoLocal.ValueMember = "id_equipo";
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

        private void CargarEquiposVisitante()
        {
            if (todosLosEquipos == null) return;

            DataTable dtVisitante = todosLosEquipos.Clone();//Se clona la datatable anterior
            foreach (DataRow row in todosLosEquipos.Rows)
            {
                if (CmbEquipoLocal.SelectedValue == null || row["id_equipo"].ToString() != CmbEquipoLocal.SelectedValue.ToString())
                {//se crea un foreach para que recorra la tabla y busque que si el otro combobox tiene un dato, no lo muestre en este
                    dtVisitante.Rows.Add(row.ItemArray);
                }
            }

            CmbEquipoVisitante.DataSource = dtVisitante;
            CmbEquipoVisitante.DisplayMember = "nombre";
            CmbEquipoVisitante.ValueMember = "id_equipo";
        }

        private void CmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquiposVisitante();
        }

        private void CmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarEstadoPartido()
        {

            CmbEstadoPartido.Text = "Seleccione";
            CmbEstadoPartido.Items.Add("Roja");
            CmbEstadoPartido.Items.Add("Amarilla");
        }

        private void CargarTipoFalta()
        {
            /*CmbFalta.Items.Add("Mano");
            CmbFalta.Items.Add("Fuera de Juego");
            CmbFalta.Items.Add("Empujon");
            CmbFalta.Items.Add("Entrada Peligrosa");
            CmbFalta.Items.Add("Agresion");
            CmbFalta.Items.Add("Simulacion");
            CmbFalta.Items.Add("Protesta");
            CmbFalta.Items.Add("Falta Personal");
            CmbFalta.Items.Add("Falta Tecnica");
            CmbFalta.Items.Add("Saque fuera de la linea");*/
        }

        private void Limpiar()
        {
            CmbEstadoPartido.SelectedIndex = -1;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
