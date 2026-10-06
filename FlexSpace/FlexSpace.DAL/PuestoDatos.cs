using MySql.Data.MySqlClient;

namespace FlexSpace.DAL
{
    public class PuestoDatos
    {
        private Conexion conexion = new Conexion();

        public (int Id, string Codigo, int TipoPuesto, decimal TarifaBasePorHora)? BuscarPorId(int id)
        {
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT Id, Codigo, TipoPuesto, TarifaBasePorHora
                               FROM Puesto
                               WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                Convert.ToInt32(reader["Id"]),
                                Convert.ToString(reader["Codigo"]) ?? "",
                                Convert.ToInt32(reader["TipoPuesto"]),
                                Convert.ToDecimal(reader["TarifaBasePorHora"])
                            );
                        }
                    }
                }
            }

            return null;
        }
    }
}