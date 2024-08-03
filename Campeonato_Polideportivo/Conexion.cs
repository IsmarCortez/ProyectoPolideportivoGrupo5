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
        private string database = "PoliDB"; //nombre de la base de datos
        private string user = "root"; //nombre del usuario
<<<<<<< HEAD
<<<<<<< HEAD
        private string password = "2110"; //contraseña del usuario
=======
        private string password = "1970"; //contraseña del usuario
>>>>>>> a67a920411537aad14424c7fcf16659e9cde9ac8
=======
        private string password = "2110"; //contraseña del usuario
>>>>>>> 56b3979a5979ed3643806370d81c798f31b05443
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
