using FlexSpace.BLL.Entidades;
using FlexSpace.BLL.Enumeraciones;
using FlexSpace.DAL;

namespace FlexSpace.BLL.Negocio
{
    public class PuestoNegocio
    {
        private PuestoDatos datos = new PuestoDatos();

        public Puesto BuscarPorId(int id)
        {
            var puesto = datos.BuscarPorId(id);

            if (puesto == null)
            {
                return null;
            }

            return new Puesto
            {
                Id = puesto.Value.Id,
                Codigo = puesto.Value.Codigo,
                TipoPuesto = (TipoPuesto)puesto.Value.TipoPuesto,
                TarifaBasePorHora = puesto.Value.TarifaBasePorHora
            };
        }
    }
}