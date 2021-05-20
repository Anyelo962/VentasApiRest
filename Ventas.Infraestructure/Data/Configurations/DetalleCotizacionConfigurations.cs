using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class DetalleCotizacionConfigurations : IEntityTypeConfiguration<DetalleCotizacion>
    {
        public void Configure(EntityTypeBuilder<DetalleCotizacion> builder)
        {
            builder.HasKey(e => e.Iddetallecotizacion);

            builder.ToTable("detalle_cotizacion");

            builder.Property(e => e.Iddetallecotizacion).HasColumnName("iddetallecotizacion");

            builder.Property(e => e.Cantidad).HasColumnName("cantidad");

            builder.Property(e => e.Descuento)
                .HasColumnName("descuento")
                .HasColumnType("money");

            builder.Property(e => e.Idcotizacion).HasColumnName("idcotizacion");

            builder.Property(e => e.Iddetalleingreso).HasColumnName("iddetalleingreso");

            builder.Property(e => e.Precioventa)
                .HasColumnName("precioventa")
                .HasColumnType("money");
        }
    }
}
