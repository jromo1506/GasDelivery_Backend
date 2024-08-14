using Microsoft.EntityFrameworkCore;
using GasDelivery.Models;

namespace GasDelivery.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios {  get; set; }
        public DbSet<InfoCliente> InfoClientes { get; set; }
        public DbSet<Repartidor> Repartidor { get; set;}
        public DbSet<Pedido> Pedidos { get; set;}

        public DbSet<Suscripcion> Suscripciones { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              modelBuilder.Entity<Repartidor>()
                .HasMany(r => r.Pedidos)
                .WithOne(p => p.Repartidor)
                .HasForeignKey(p => p.Id_Repartidor);

            modelBuilder.Entity<Pedido>()
                .HasOne(pe => pe.InfoCliente)
                .WithOne(ic => ic.Pedido)
                .HasForeignKey<Pedido>(pe => pe.Id_InfoCliente);

            modelBuilder.Entity<Suscripcion>()
                .HasOne(sus => sus.InfoCliente)
                .WithOne(ic => ic.Suscripcion)
                .HasForeignKey<Suscripcion>(sus => sus.Id_InfoCliente);

            modelBuilder.Entity<Usuario>()
                .HasOne(usu => usu.InfoCliente)
                .WithOne(ic => ic.Usuarios)
                .HasForeignKey<Usuario>(usu => usu.Id_InfoCliente);

            modelBuilder.Entity<Usuario>()
                .HasMany(usu => usu.Tarjetas)
                .WithOne(tar => tar.Usuario)
                .HasForeignKey(tar => tar.Id_Usuario);
           

            

            base.OnModelCreating(modelBuilder);
        }

    }
}
