using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Cotizaciones
    {
        public int Idcotizacion { get; set; }
        public int Idcliente { get; set; }
        public int Idtrabajador { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Impuesto { get; set; }
    }
}
