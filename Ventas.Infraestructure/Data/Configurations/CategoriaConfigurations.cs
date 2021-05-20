using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class CategoriaConfigurations : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(e => e.Idcategoria);

            builder.ToTable("categoria");

            builder.Property(e => e.Idcategoria).HasColumnName("idcategoria");

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
