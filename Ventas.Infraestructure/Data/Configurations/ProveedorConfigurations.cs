using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class ProveedorConfigurations : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.HasKey(e => e.Idproveedor);

            builder.ToTable("proveedor");

            builder.Property(e => e.Idproveedor).HasColumnName("idproveedor");

            builder.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NumDocumento)
                .HasColumnName("num_documento")
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.Property(e => e.RazonSocial)
                .IsRequired()
                .HasColumnName("razon_social")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.SectorComercial)
                .IsRequired()
                .HasColumnName("sector_comercial")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.TipoDocumento)
                .HasColumnName("tipo_documento")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Url)
                .HasColumnName("url")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
