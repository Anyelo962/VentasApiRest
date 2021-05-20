using System;
using System.Collections.Generic;
using Ventas.Infraestructure.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class IngresoNcf
    {
        public IngresoNcf()
        {
            DtIngresoNcf = new HashSet<DtIngresoNcf>();
        }

        public int Idingresoncf { get; set; }
        public int Idtrabajador { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public string Estado { get; set; }

        public virtual Trabajador IdtrabajadorNavigation { get; set; }
        public virtual ICollection<DtIngresoNcf> DtIngresoNcf { get; set; }
    }
}
