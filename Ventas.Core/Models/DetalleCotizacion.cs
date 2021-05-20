using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class DetalleCotizacion
    {
        public int Iddetallecotizacion { get; set; }
        public int Idcotizacion { get; set; }
        public int Iddetalleingreso { get; set; }
        public int Cantidad { get; set; }
        public decimal Precioventa { get; set; }
        public decimal? Descuento { get; set; }
    }
}
