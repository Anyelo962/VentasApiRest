using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class DetalleVentaConfigurations : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.HasKey(e => e.IddetalleVenta);

            builder.ToTable("detalle_venta");

            builder.Property(e => e.IddetalleVenta).HasColumnName("iddetalle_venta");

            builder.Property(e => e.Cantidad).HasColumnName("cantidad");

            builder.Property(e => e.Descuento)
                .HasColumnName("descuento")
                .HasColumnType("money");

            builder.Property(e => e.IddetalleIngreso).HasColumnName("iddetalle_ingreso");

            builder.Property(e => e.Idventa).HasColumnName("idventa");

            builder.Property(e => e.PrecioVenta)
                .HasColumnName("precio_venta")
                .HasColumnType("money");

            builder.HasOne(d => d.IddetalleIngresoNavigation)
                .WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IddetalleIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_venta_detalle_ingreso");

            builder.HasOne(d => d.IdventaNavigation)
                .WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.Idventa)
                .HasConstraintName("FK_detalle_venta_venta");
        }
    }
}
