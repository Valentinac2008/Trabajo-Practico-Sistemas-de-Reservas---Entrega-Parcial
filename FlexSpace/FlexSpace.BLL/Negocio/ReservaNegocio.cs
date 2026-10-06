using FlexSpace.BLL.Entidades;
using FlexSpace.BLL.Excepciones;

namespace FlexSpace.BLL.Negocio
{
    public class ReservaNegocio
    {
        public void VerificarCliente(Cliente cliente)
        {
            if (cliente.SancionesActivas >= 3)
            {
                throw new ClienteSancionadoException(
                    "El cliente tiene 3 o más sanciones activas."
                );
            }
        }
    }
}