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
        public DbSet<TipoModel> Tipos { get; set; }
    }
}
