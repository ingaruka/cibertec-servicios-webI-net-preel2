﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreEL2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Negocios2018Entities : DbContext
    {
        public Negocios2018Entities()
            : base("name=Negocios2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Distritos> Distritos { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<paises> paises { get; set; }
        public virtual DbSet<pedidoscabe> pedidoscabe { get; set; }
        public virtual DbSet<pedidosdeta> pedidosdeta { get; set; }
    }
}
