using Microsoft.EntityFrameworkCore;
using PokeApi.Models;

namespace PokeApi.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<PokemonModel> Pokemons { get; set; }
        public DbSet<RegiaoModel> Regioes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<PokemonModel>()
                .HasOne(p => p.Regiao) 
                .WithMany(r => r.Pokemon) 
                .HasForeignKey(p => p.RegiaoId); 
        }
    }
}
