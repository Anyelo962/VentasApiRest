using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Vendedores
    {
        public int Idvendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string Tipodocumento { get; set; }
        public string Numerodocumento { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Infoadicional { get; set; }
        public byte[] Imagen { get; set; }
    }
}
