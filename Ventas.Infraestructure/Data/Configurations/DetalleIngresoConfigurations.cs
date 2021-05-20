using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class DetalleIngresoConfigurations : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.HasKey(e => e.IddetalleIngreso);

            builder.ToTable("detalle_ingreso");

            builder.Property(e => e.IddetalleIngreso).HasColumnName("iddetalle_ingreso");

            builder.Property(e => e.FechaProduccion)
                .HasColumnName("fecha_produccion")
                .HasColumnType("datetime");

            builder.Property(e => e.FechaVencimiento)
                .HasColumnName("fecha_vencimiento")
                .HasColumnType("datetime");

            builder.Property(e => e.Idarticulo).HasColumnName("idarticulo");

            builder.Property(e => e.Idingreso).HasColumnName("idingreso");

            builder.Property(e => e.PrecioCompra)
                .HasColumnName("precio_compra")
                .HasColumnType("money");

            builder.Property(e => e.PrecioVenta)
                .HasColumnName("precio_venta")
                .HasColumnType("money");

            builder.Property(e => e.StockActual).HasColumnName("stock_actual");

            builder.Property(e => e.StockInicial).HasColumnName("stock_inicial");

            builder.HasOne(d => d.IdarticuloNavigation)
                .WithMany(p => p.DetalleIngreso)
                .HasForeignKey(d => d.Idarticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_ingreso_articulo");

            builder.HasOne(d => d.IdingresoNavigation)
                .WithMany(p => p.DetalleIngreso)
                .HasForeignKey(d => d.Idingreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_ingreso_ingreso");
        }
    }
}
