using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class PresentacionConfigurations : IEntityTypeConfiguration<Presentacion>
    {
        public void Configure(EntityTypeBuilder<Presentacion> builder)
        {
            builder.HasKey(e => e.Idpresentacion);

            builder.ToTable("presentacion");

            builder.Property(e => e.Idpresentacion).HasColumnName("idpresentacion");

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(256)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
