using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Playstation2.Models;

namespace JogosPS2.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets para cada uma das tabelas
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedor { get; set; }
        public DbSet<JogoGenero> JogoGenero { get; set; }
        public DbSet<JogoDesenvolvedor> JogoDesenvolvedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração de chave composta para a tabela de junção JogoGenero
            modelBuilder.Entity<JogoGenero>()
                .HasKey(jg => new { jg.JogoID, jg.GeneroID });

            // Relacionamento Jogo -> JogoGenero
            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Jogo)
                .WithMany(j => j.JogoGenero)
                .HasForeignKey(jg => jg.JogoID);

            // Relacionamento Genero -> JogoGenero
            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Genero)
                .WithMany(g => g.JogoGenero)
                .HasForeignKey(jg => jg.GeneroID);

            // Configuração de chave composta para a tabela de junção JogoDesenvolvedor
            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasKey(jd => new { jd.JogoID, jd.DesenvolvedorID });

            // Relacionamento Jogo -> JogoDesenvolvedor
            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasOne(jd => jd.Jogo)
                .WithMany(j => j.JogoDesenvolvedor)
                .HasForeignKey(jd => jd.JogoID);

            // Relacionamento Desenvolvedor -> JogoDesenvolvedor
            modelBuilder.Entity<JogoDesenvolvedor>()
                .HasOne(jd => jd.Desenvolvedor)
                .WithMany(d => d.JogoDesenvolvedor)
                .HasForeignKey(jd => jd.DesenvolvedorID);
        }
    }
}
