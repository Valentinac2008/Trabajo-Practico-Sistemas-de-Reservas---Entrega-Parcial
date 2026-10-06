using FlexSpace.BLL.Entidades;
using FlexSpace.BLL.Enumeraciones;
using FlexSpace.DAL;

namespace FlexSpace.BLL.Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos datos = new ClienteDatos();

        public Cliente BuscarPorId(int id)
        {
            var cliente = datos.BuscarPorId(id);

            if (cliente == null)
            {
                return null;
            }

            return new Cliente
            {
                Id = cliente.Value.Id,
                Nombre = cliente.Value.Nombre,
                Email = cliente.Value.Email,
                TipoCliente = (TipoCliente)cliente.Value.TipoCliente,
                SancionesActivas = cliente.Value.SancionesActivas
            };
        }

        public List<Cliente> ListarSancionados()
        {
            var datosClientes = datos.ListarSancionados();

            List<Cliente> clientes = new List<Cliente>();

            foreach (var cliente in datosClientes)
            {
                clientes.Add(new Cliente
                {
                    Id = cliente.Id,
                    Nombre = cliente.Nombre,
                    Email = cliente.Email,
                    TipoCliente = (TipoCliente)cliente.TipoCliente,
                    SancionesActivas = cliente.SancionesActivas
                });
            }

            return clientes;
        }
    }
}