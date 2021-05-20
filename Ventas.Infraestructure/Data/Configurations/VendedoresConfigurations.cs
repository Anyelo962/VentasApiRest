using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class VendedoresConfigurations : IEntityTypeConfiguration<Vendedores>
    {
        public void Configure(EntityTypeBuilder<Vendedores> builder)
        {
            builder.HasKey(e => e.Idvendedor);

            builder.ToTable("vendedores");

            builder.Property(e => e.Idvendedor).HasColumnName("idvendedor");

            builder.Property(e => e.Apellido)
                .IsRequired()
                .HasColumnName("apellido")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .IsRequired()
                .HasColumnName("direccion")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Imagen)
                .HasColumnName("imagen")
                .HasColumnType("image");

            builder.Property(e => e.Infoadicional)
                .IsRequired()
                .HasColumnName("infoadicional")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Nacionalidad)
                .IsRequired()
                .HasColumnName("nacionalidad")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Numerodocumento)
                .IsRequired()
                .HasColumnName("numerodocumento")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Sexo)
                .IsRequired()
                .HasColumnName("sexo")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .IsRequired()
                .HasColumnName("telefono")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Tipodocumento)
                .IsRequired()
                .HasColumnName("tipodocumento")
                .HasMaxLength(10)
                .IsUnicode(false);
        }
    }
}
