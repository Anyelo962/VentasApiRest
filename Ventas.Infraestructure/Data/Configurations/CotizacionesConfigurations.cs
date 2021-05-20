using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class CotizacionesConfigurations : IEntityTypeConfiguration<Cotizaciones>
    {
        public void Configure(EntityTypeBuilder<Cotizaciones> builder)
        {

            builder.HasKey(e => e.Idcotizacion);

            builder.ToTable("cotizaciones");

            builder.Property(e => e.Idcotizacion).HasColumnName("IDCOTIZACION");

            builder.Property(e => e.Fecha)
                .HasColumnName("FECHA")
                .HasColumnType("datetime");

            builder.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

            builder.Property(e => e.Idtrabajador).HasColumnName("IDTRABAJADOR");

            builder.Property(e => e.Impuesto)
                .HasColumnName("IMPUESTO")
                .HasColumnType("decimal(4, 2)");
        }
    }
}
