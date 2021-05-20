using System;
using System.Collections.Generic;
using Ventas.Infraestructure.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Rnc { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
