using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class AlmacenConfigurations : IEntityTypeConfiguration<Almacen>
    {
        public void Configure(EntityTypeBuilder<Almacen> builder)
        {
            builder.HasKey(e => e.Idalmacen);

            builder.Property(e => e.Idalmacen).HasColumnName("IDALMACEN");

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasColumnName("DESCRIPCION")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .IsRequired()
                .HasColumnName("DIRECCION")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Infoadicional)
                .HasColumnName("INFOADICIONAL")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("NOMBRE")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
