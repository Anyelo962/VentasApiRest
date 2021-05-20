using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class TrabajadorConfigurations : IEntityTypeConfiguration<Trabajador>
    {
        public void Configure(EntityTypeBuilder<Trabajador> builder)
        {
            builder.HasKey(e => e.Idtrabajador);

            builder.ToTable("trabajador");

            builder.Property(e => e.Idtrabajador).HasColumnName("idtrabajador");

            builder.Property(e => e.Acceso)
                .IsRequired()
                .HasColumnName("acceso")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Apellidos)
                .IsRequired()
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
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("password")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Sexo)
                .IsRequired()
                .HasColumnName("sexo")
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.TipoDocumento)
                .HasColumnName("tipo_documento")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Usuario)
                .IsRequired()
                .HasColumnName("usuario")
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
