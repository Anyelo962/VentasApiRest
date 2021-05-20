using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class DtIngresoNcf
    {
        public int Iddtingresoncf { get; set; }
        public int Idingresoncf { get; set; }
        public int Idncf { get; set; }
        public int Secinicial { get; set; }
        public int Secvariable { get; set; }
        public int Secfinal { get; set; }
        public int Totalingreso { get; set; }
        public int Totaldisponible { get; set; }
        public string Secactual { get; set; }

        public virtual IngresoNcf IdingresoncfNavigation { get; set; }
        public virtual Ncf IdncfNavigation { get; set; }
    }
}
