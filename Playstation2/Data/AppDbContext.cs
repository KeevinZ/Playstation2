using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Playstation2.Models;

namespace JogosPS2.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedor { get; set; }
        public DbSet<JogoGenero> JogoGenero { get; set; }
        public DbSet<JogoDesenvolvedor> JogoDesenvolvedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JogoGenero>()
                .HasKey(jg => new { jg.JogoID, jg.GeneroID });
               modelBuilder.Entity<JogoDesenvolvedor>()
                .HasKey(jd => new { jd.JogoID, jd.DesenvolvedorID });

        }
    }
}
