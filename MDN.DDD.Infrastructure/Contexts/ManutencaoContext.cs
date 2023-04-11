using MDN.DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MDN.DDD.Infrastructure.Contexts
{
    public class ManutencaoContext : DbContext
    {
        //public ManutencaoContext(DbContextOptions<ManutencaoContext> options) : base(options)

        public ManutencaoContext(DbContextOptions<ManutencaoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

       public DbSet<Usuario> Usuarios { get; set; }
       //public DbSet<Endereco> Enderecos { get; set; }
       public DbSet<Perfil> Perfis { get; set; }

    }
}
