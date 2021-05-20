using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Presentacion
    {
        public Presentacion()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int Idpresentacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
