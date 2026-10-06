using MySql.Data.MySqlClient;

namespace FlexSpace.DAL
{
    public class ClienteDatos
    {
        private Conexion conexion = new Conexion();

        public (int Id, string Nombre, string Email, int TipoCliente, int SancionesActivas)? BuscarPorId(int id)
        {
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT Id, Nombre, Email, TipoCliente, SancionesActivas
                               FROM Cliente
                               WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.Read())
                            {
                                return (
                                    Convert.ToInt32(reader["Id"]),
                                    Convert.ToString(reader["Nombre"]) ?? "",
                                    Convert.ToString(reader["Email"]) ?? "",
                                    Convert.ToInt32(reader["TipoCliente"]),
                                    Convert.ToInt32(reader["SancionesActivas"])
                                );
                            }
                        }
                    }
                }
            }

            return null;
        }

        public List<(int Id, string Nombre, string Email, int TipoCliente, int SancionesActivas)> ListarSancionados()
        {
            List<(int Id, string Nombre, string Email, int TipoCliente, int SancionesActivas)> lista = new();

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT Id, Nombre, Email, TipoCliente, SancionesActivas
                               FROM Cliente
                               WHERE SancionesActivas > 0";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add((
                   Convert.ToInt32(reader["Id"]),
                   Convert.ToString(reader["Nombre"]) ?? "",
                   Convert.ToString(reader["Email"]) ?? "",
                   Convert.ToInt32(reader["TipoCliente"]),
                   Convert.ToInt32(reader["SancionesActivas"])
                             ));
                        }
                    }
                }
            }

            return lista;
        }
    }
}