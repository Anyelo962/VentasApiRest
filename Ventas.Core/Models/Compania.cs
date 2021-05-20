using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Compania
    {
        public int Idcompania { get; set; }
        public string Razonsocial { get; set; }
        public string Descripcion { get; set; }
        public string Rnc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Otrainfo { get; set; }
    }
}
