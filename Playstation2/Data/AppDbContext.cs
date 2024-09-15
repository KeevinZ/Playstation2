using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Playstation2.Models;

namespace Playstation2.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<JogoGenero> JogoGeneros { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações de relacionamento muitos-para-muitos
            modelBuilder.Entity<JogoGenero>()
                .HasKey(jg => new { jg.JogoID, jg.GeneroID });

            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Jogo)
                .WithMany(j => j.JogoGeneros)
                .HasForeignKey(jg => jg.JogoID);

            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Genero)
                .WithMany(g => g.JogoGeneros)
                .HasForeignKey(jg => jg.GeneroID);

            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasKey(jd => new { jd.JogoID, jd.DesenvolvedorID });

            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasOne(jd => jd.Jogo)
                .WithMany(j => j.JogoDesenvolvedores)
                .HasForeignKey(jd => jd.JogoID);

            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasOne(jd => jd.Desenvolvedor)
                .WithMany(d => d.JogoDesenvolvedores)
                .HasForeignKey(jd => jd.DesenvolvedorID);
        }
    }
}
