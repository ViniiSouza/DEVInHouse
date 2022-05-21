using Ex1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex1
{
    public class Modulo3Semana1Context : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        public Modulo3Semana1Context(DbContextOptions<Modulo3Semana1Context> options) : base(options)
        {
        }
    }
}
