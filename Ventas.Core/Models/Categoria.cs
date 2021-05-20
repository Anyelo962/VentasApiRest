using System;
using System.Collections.Generic;
using Ventas.Core.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int Idcategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
