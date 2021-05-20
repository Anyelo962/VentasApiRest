using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ventas.Core.Models;
using Ventas.Infraestructure.Data.Configurations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ventas.Infraestructure.Data
{
    public partial class dbventasContext : DbContext
    {
        public dbventasContext()
        {
        }

        public dbventasContext(DbContextOptions<dbventasContext> options) : base(options)
        {

        }

        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compania> Compania { get; set; }
        public virtual DbSet<Cotizaciones> Cotizaciones { get; set; }
        public virtual DbSet<DetalleCotizacion> DetalleCotizacion { get; set; }
        public virtual DbSet<DetalleIngreso> DetalleIngreso { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<DtIngresoNcf> DtIngresoNcf { get; set; }
        public virtual DbSet<Ingreso> Ingreso { get; set; }
        public virtual DbSet<IngresoNcf> IngresoNcf { get; set; }
        public virtual DbSet<Ncf> Ncf { get; set; }
        public virtual DbSet<Presentacion> Presentacion { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Trabajador> Trabajador { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=dbventas;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlmacenConfigurations());
            modelBuilder.ApplyConfiguration(new ArticuloSConfigurations());
            modelBuilder.ApplyConfiguration(new CategoriaConfigurations());
            modelBuilder.ApplyConfiguration(new ClientesConfigurations());
            modelBuilder.ApplyConfiguration(new CompaniaConfigurations());
            modelBuilder.ApplyConfiguration(new CotizacionesConfigurations());
            modelBuilder.ApplyConfiguration(new DetalleCotizacionConfigurations());
            modelBuilder.ApplyConfiguration(new DetalleIngresoConfigurations());
            modelBuilder.ApplyConfiguration(new DetalleVentaConfigurations());
            modelBuilder.ApplyConfiguration(new DtIngresoNcfConfigurations());
            modelBuilder.ApplyConfiguration(new IngresoConfiguration());
            modelBuilder.ApplyConfiguration(new IngresoNCFConfigurations());
            modelBuilder.ApplyConfiguration(new IngresoNCFConfigurations());
            modelBuilder.ApplyConfiguration(new NcfConfiguration());
            modelBuilder.ApplyConfiguration(new PresentacionConfigurations());
            modelBuilder.ApplyConfiguration(new ProveedorConfigurations());
            modelBuilder.ApplyConfiguration(new TrabajadorConfigurations());
            modelBuilder.ApplyConfiguration(new VendedoresConfigurations());
            modelBuilder.ApplyConfiguration(new VentaConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
