using MySql.Data.MySqlClient;

namespace FlexSpace.DAL
{
    public class Conexion
    {
        private string cadenaConexion =
            "Server=localhost;Database=FlexSpace;Uid=root;Pwd=;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}