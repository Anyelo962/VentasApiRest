using System;
using System.Collections.Generic;
using Ventas.Core.Models;


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
