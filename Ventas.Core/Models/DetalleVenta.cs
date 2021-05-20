using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class DetalleVenta
    {
        public int IddetalleVenta { get; set; }
        public int Idventa { get; set; }
        public int IddetalleIngreso { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? Descuento { get; set; }

        public virtual DetalleIngreso IddetalleIngresoNavigation { get; set; }
        public virtual Venta IdventaNavigation { get; set; }
    }
}
