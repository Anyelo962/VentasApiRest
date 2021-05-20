using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Ncf
    {
        public Ncf()
        {
            DtIngresoNcf = new HashSet<DtIngresoNcf>();
        }

        public int Idncf { get; set; }
        public string Serie { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Nota { get; set; }

        public virtual ICollection<DtIngresoNcf> DtIngresoNcf { get; set; }
    }
}
