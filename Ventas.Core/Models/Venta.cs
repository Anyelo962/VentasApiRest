using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Idventa { get; set; }
        public int Idcliente { get; set; }
        public int Idtrabajador { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public decimal Igv { get; set; }
        public string Formacobro { get; set; }
        public int? Idncf { get; set; }
        public int? Idvendedor { get; set; }
        public int? Total { get; set; }
        public int? Pagado { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; }
        public virtual Trabajador IdtrabajadorNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
