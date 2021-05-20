using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class DtIngresoNcfConfigurations : IEntityTypeConfiguration<DtIngresoNcf>
    {
        public void Configure(EntityTypeBuilder<DtIngresoNcf> builder)
        {
            builder.HasKey(e => e.Iddtingresoncf)
                    .HasName("PK_DETALLEINGRESONCF");

            builder.ToTable("DT_INGRESO_NCF");

            builder.Property(e => e.Iddtingresoncf).HasColumnName("IDDTINGRESONCF");

            builder.Property(e => e.Idingresoncf).HasColumnName("IDINGRESONCF");

            builder.Property(e => e.Idncf).HasColumnName("IDNCF");

            builder.Property(e => e.Secactual)
                .IsRequired()
                .HasColumnName("SECACTUAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Secfinal).HasColumnName("SECFINAL");

            builder.Property(e => e.Secinicial).HasColumnName("SECINICIAL");

            builder.Property(e => e.Secvariable).HasColumnName("SECVARIABLE");

            builder.Property(e => e.Totaldisponible).HasColumnName("TOTALDISPONIBLE");

            builder.Property(e => e.Totalingreso).HasColumnName("TOTALINGRESO");

            builder.HasOne(d => d.IdingresoncfNavigation)
                .WithMany(p => p.DtIngresoNcf)
                .HasForeignKey(d => d.Idingresoncf)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DT_INGRESO_NCF_INGRESO_NCF");

            builder.HasOne(d => d.IdncfNavigation)
                .WithMany(p => p.DtIngresoNcf)
                .HasForeignKey(d => d.Idncf)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DT_INGRESO_NCF_NCF");
        }
    }
}
