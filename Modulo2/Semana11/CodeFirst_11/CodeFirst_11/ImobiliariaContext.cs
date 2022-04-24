using CodeFirst_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst_11
{
    public class ImobiliariaContext : DbContext
    {
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OF89FLJ\SQLEXPRESS;Database=IMOBILIARIA;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imovel>()
                .HasOne(c => c.Cliente)
                .WithOne(e => e.Imovel)
                .HasForeignKey<Imovel>(x => x.idCliente)
                .IsRequired(false);

            modelBuilder.Entity<Veiculo>()
                .HasOne(c => c.Cliente)
                .WithOne(e => e.Veiculo)
                .HasForeignKey<Veiculo>(x => x.idCliente)
                .IsRequired(false);
        }
    }
}
