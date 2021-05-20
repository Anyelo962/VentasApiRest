using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Trabajador
    {
        public Trabajador()
        {
            Ingreso = new HashSet<Ingreso>();
            IngresoNcf = new HashSet<IngresoNcf>();
            Venta = new HashSet<Venta>();
        }

        public int Idtrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Acceso { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Ingreso> Ingreso { get; set; }
        public virtual ICollection<IngresoNcf> IngresoNcf { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
