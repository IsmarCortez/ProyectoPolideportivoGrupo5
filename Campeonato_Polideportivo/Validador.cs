using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Campeonato_Polideportivo
{
    public class UsuarioValidator
    {
        private readonly string connectionString;

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
}
