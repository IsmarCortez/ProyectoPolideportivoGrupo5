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
    public partial class Form4login : Form
    {
        public Form4login()
        {
            InitializeComponent();
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

        }
    }
}
