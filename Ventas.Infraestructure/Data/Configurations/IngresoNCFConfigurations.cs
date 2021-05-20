using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class IngresoNCFConfigurations : IEntityTypeConfiguration<IngresoNcf>
    {
        public void Configure(EntityTypeBuilder<IngresoNcf> builder)
        {
            builder.HasKey(e => e.Idingresoncf)
                    .HasName("PK_INGRESONCF");

            builder.ToTable("INGRESO_NCF");

            builder.Property(e => e.Idingresoncf).HasColumnName("IDINGRESONCF");

            builder.Property(e => e.Documento)
                .HasColumnName("DOCUMENTO")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("ESTADO")
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(e => e.Fecha)
                .HasColumnName("FECHA")
                .HasColumnType("datetime");

            builder.Property(e => e.Idtrabajador).HasColumnName("IDTRABAJADOR");

            builder.HasOne(d => d.IdtrabajadorNavigation)
                .WithMany(p => p.IngresoNcf)
                .HasForeignKey(d => d.Idtrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INGRESO_NCF_trabajador");
        }
    }
}
