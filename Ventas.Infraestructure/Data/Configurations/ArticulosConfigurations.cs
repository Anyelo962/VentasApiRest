using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.Infraestructure.Data.Configurations
{
    public class ArticuloSConfigurations : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.HasKey(e => e.Idarticulo);

            builder.ToTable("articulo");

            builder.Property(e => e.Idarticulo).HasColumnName("idarticulo");

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasColumnName("codigo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(1024)
                .IsUnicode(false);

            builder.Property(e => e.Estado)
                .HasColumnName("estado")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Idcategoria).HasColumnName("idcategoria");

            builder.Property(e => e.Idpresentacion).HasColumnName("idpresentacion");

            builder.Property(e => e.Imagen)
                .HasColumnName("imagen")
                .HasColumnType("image");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Stockminimo).HasColumnName("stockminimo");

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnName("tipo")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.IdcategoriaNavigation)
                .WithMany(p => p.Articulo)
                .HasForeignKey(d => d.Idcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_articulo_categoria");

            builder.HasOne(d => d.IdpresentacionNavigation)
                .WithMany(p => p.Articulo)
                .HasForeignKey(d => d.Idpresentacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_articulo_presentacion");
        }
    }
}
