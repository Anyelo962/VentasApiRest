using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class IngresoConfiguration : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.HasKey(e => e.Idingreso);

            builder.ToTable("ingreso");

            builder.Property(e => e.Idingreso).HasColumnName("idingreso");

            builder.Property(e => e.Correlativo)
                .IsRequired()
                .HasColumnName("correlativo")
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(e => e.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("datetime");

            builder.Property(e => e.Idalmacen).HasColumnName("idalmacen");

            builder.Property(e => e.Idproveedor).HasColumnName("idproveedor");

            builder.Property(e => e.Idtrabajador).HasColumnName("idtrabajador");

            builder.Property(e => e.Igv)
                .HasColumnName("igv")
                .HasColumnType("decimal(4, 2)");

            builder.Property(e => e.Serie)
                .IsRequired()
                .HasColumnName("serie")
                .HasMaxLength(4)
                .IsUnicode(false);

            builder.Property(e => e.TipoComprobante)
                .IsRequired()
                .HasColumnName("tipo_comprobante")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.IdproveedorNavigation)
                .WithMany(p => p.Ingreso)
                .HasForeignKey(d => d.Idproveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingreso_proveedor");

            builder.HasOne(d => d.IdtrabajadorNavigation)
                .WithMany(p => p.Ingreso)
                .HasForeignKey(d => d.Idtrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingreso_trabajador");
        }
    }
}
