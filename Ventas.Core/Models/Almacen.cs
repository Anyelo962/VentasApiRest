﻿using System;
using System.Collections.Generic;


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
