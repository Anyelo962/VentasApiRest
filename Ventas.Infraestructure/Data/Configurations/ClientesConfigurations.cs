using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class ClientesConfigurations : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Idcliente);

            builder.ToTable("cliente");

            builder.Property(e => e.Idcliente).HasColumnName("idcliente");

            builder.Property(e => e.Apellidos)
                .HasColumnName("apellidos")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FechaNacimiento)
                .HasColumnName("fecha_nacimiento")
                .HasColumnType("datetime");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NumDocumento)
                .HasColumnName("num_documento")
                .HasMaxLength(11)
                .IsUnicode(false);

            builder.Property(e => e.Rnc)
                .HasColumnName("RNC")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Sexo)
                .HasColumnName("sexo")
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.TipoDocumento)
                .HasColumnName("tipo_documento")
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
