using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {

            builder.HasKey(e => e.Idventa);

            builder.ToTable("venta");

            builder.Property(e => e.Idventa).HasColumnName("idventa");

            builder.Property(e => e.Correlativo)
                .IsRequired()
                .HasColumnName("correlativo")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("datetime");

            builder.Property(e => e.Formacobro)
                .HasColumnName("formacobro")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Idcliente).HasColumnName("idcliente");

            builder.Property(e => e.Idncf).HasColumnName("idncf");

            builder.Property(e => e.Idtrabajador).HasColumnName("idtrabajador");

            builder.Property(e => e.Idvendedor).HasColumnName("idvendedor");

            builder.Property(e => e.Igv)
                .HasColumnName("igv")
                .HasColumnType("decimal(4, 2)");

            builder.Property(e => e.Pagado).HasColumnName("pagado");

            builder.Property(e => e.Serie)
                .IsRequired()
                .HasColumnName("serie")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.TipoComprobante)
                .IsRequired()
                .HasColumnName("tipo_comprobante")
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Total).HasColumnName("total");

            builder.HasOne(d => d.IdclienteNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idcliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_cliente");

            builder.HasOne(d => d.IdtrabajadorNavigation)
                .WithMany(p => p.Venta)
                .HasForeignKey(d => d.Idtrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_venta_trabajador");
        }
    }
}
