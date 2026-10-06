using FlexSpace.BLL.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexSpace.BLL.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int PuestoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoReserva Estado { get; set; }
        public decimal CostoTotal { get; set; }
    }
}