using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Ingreso
    {
        public Ingreso()
        {
            DetalleIngreso = new HashSet<DetalleIngreso>();
        }

        public int Idingreso { get; set; }
        public int Idtrabajador { get; set; }
        public int Idproveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public decimal Igv { get; set; }
        public string Estado { get; set; }
        public int? Idalmacen { get; set; }

        public virtual Proveedor IdproveedorNavigation { get; set; }
        public virtual Trabajador IdtrabajadorNavigation { get; set; }
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
    }
}
