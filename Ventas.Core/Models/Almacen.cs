using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Almacen
    {
        public int Idalmacen { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Infoadicional { get; set; }
    }
}
