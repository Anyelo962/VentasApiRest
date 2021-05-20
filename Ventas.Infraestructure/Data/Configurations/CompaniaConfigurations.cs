using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class CompaniaConfigurations : IEntityTypeConfiguration<Compania>
    {
        public void Configure(EntityTypeBuilder<Compania> builder)
        {
            builder.HasKey(e => e.Idcompania);

            builder.ToTable("compania");

            builder.Property(e => e.Idcompania).HasColumnName("idcompania");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Otrainfo)
                .HasColumnName("otrainfo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Razonsocial)
                .IsRequired()
                .HasColumnName("razonsocial")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Rnc)
                .IsRequired()
                .HasColumnName("rnc")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
