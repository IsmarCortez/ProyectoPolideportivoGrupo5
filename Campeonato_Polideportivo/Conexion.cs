using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato_Polideportivo
{
    class Conexion
    {
        private MySqlConnection conexion; //Variable tipo MySql para realizar la funcion

        private string server = "localhost"; //nombre del servidor 
<<<<<<< HEAD
        private string database = "PoliDB2"; //nombre de la base de datos
=======
        private string database = "PoliDB"; //nombre de la base de datos
>>>>>>> 26669623922a90b63fca05cb4e9b00fe55e66803
        private string user = "root"; //nombre del usuario
        private string password = "Kateryn$"; //contraseña del usuario
        private string Conector; //variable para almacenar la conexion

        public Conexion() //Constructor para mandar a llamar los parametros establecidos 
        {
            Conector = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
        }


        public MySqlConnection getConexion()
        {
            if (conexion == null) //en dado caso no se ha creado la conexion se crea
            {
                conexion = new MySqlConnection(Conector); //se crea la conexion a traves de los datos del constructor
                conexion.Open(); //Se abre la conexion, se inicia
            }

            return conexion; //retorna la conexion iniciada
        }

    }
}
