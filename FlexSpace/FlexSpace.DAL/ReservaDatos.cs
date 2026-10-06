using MySql.Data.MySqlClient;

namespace FlexSpace.DAL
{
    public class ReservaDatos
    {
        private Conexion conexion = new Conexion();

        public List<(int Id, int ClienteId, int PuestoId, DateTime FechaInicio, DateTime FechaFin, int Estado, decimal CostoTotal)> BuscarPorPuesto(int puestoId)
        {
            List<(int Id, int ClienteId, int PuestoId, DateTime FechaInicio, DateTime FechaFin, int Estado, decimal CostoTotal)> lista = new();

            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT Id, ClienteId, PuestoId, FechaInicio, FechaFin, Estado, CostoTotal
                               FROM Reserva
                               WHERE PuestoId = @PuestoId
                               AND Estado = 0";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@PuestoId", puestoId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add((
                                Convert.ToInt32(reader["Id"]),
                                Convert.ToInt32(reader["ClienteId"]),
                                Convert.ToInt32(reader["PuestoId"]),
                                Convert.ToDateTime(reader["FechaInicio"]),
                                Convert.ToDateTime(reader["FechaFin"]),
                                Convert.ToInt32(reader["Estado"]),
                                Convert.ToDecimal(reader["CostoTotal"])
                            ));
                        }
                    }
                }
            }

            return lista;
        }
    }
}