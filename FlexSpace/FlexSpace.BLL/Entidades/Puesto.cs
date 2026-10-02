using FlexSpace.BLL.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexSpace.BLL.Entidades
{
    public class Puesto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public TipoPuesto TipoPuesto { get; set; }
        public decimal TarifaBasePorHora { get; set; }
    }
}