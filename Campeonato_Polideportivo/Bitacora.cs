using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Campeonato_Polideportivo
    {
        public class Bitacora
        {
            private readonly string connectionString;

            public Bitacora(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public void RegistrarEvento(string accion, int fkidusuario)
            {
                Conexion conexion = new Conexion();
                using (MySqlConnection conn = conexion.getConexion()) {
                    conn.Open();
                    string query = "INSERT INTO bitacora (fecha, accion, fkidusuario) VALUES (@fecha, @accion, @fkidusuario)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@accion", accion);
                        cmd.Parameters.AddWithValue("@fkidusuario", fkidusuario);

                        try
                        {
                            if (conn.State != System.Data.ConnectionState.Open)
                            {
                                conn.Open();
                            }

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones (log, rethrow, etc.)
                            throw new Exception("Error al registrar el evento en la bitácora: " + ex.Message);
                        }
                        finally
                        {
                            // Asegurarse de cerrar la conexión si está abierta
                            if (conn.State == System.Data.ConnectionState.Open)
                            {
                                conn.Close();
                            }
                        }
                    }
                }
            }
        }
    }


