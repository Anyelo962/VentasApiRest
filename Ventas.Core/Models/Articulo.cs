using System;
using System.Collections.Generic;
using Ventas.Infraestructure.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Core.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            DetalleIngreso = new HashSet<DetalleIngreso>();
        }

        public int Idarticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public int Idcategoria { get; set; }
        public int Idpresentacion { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int? Stockminimo { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; }
        public virtual Presentacion IdpresentacionNavigation { get; set; }
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
    }
}
