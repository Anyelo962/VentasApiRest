using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class NcfConfiguration : IEntityTypeConfiguration<Ncf>
    {
        public void Configure(EntityTypeBuilder<Ncf> builder)
        {
            builder.HasKey(e => e.Idncf);

            builder.ToTable("NCF");

            builder.Property(e => e.Idncf).HasColumnName("IDNCF");

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasColumnName("DESCRIPCION")
                .HasMaxLength(256)
                .IsUnicode(false);

            builder.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("ESTADO")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Nota)
                .HasColumnName("NOTA")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Serie)
                .IsRequired()
                .HasColumnName("SERIE")
                .HasMaxLength(3)
                .IsUnicode(false);

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnName("TIPO")
                .HasMaxLength(3)
                .IsUnicode(false);
        }
    }
}
