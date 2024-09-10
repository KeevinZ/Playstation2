using Microsoft.EntityFrameworkCore;
using Playstation2.Models;

namespace Playstation2.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<JogoTipo> JogoTipos { get; set; }
    public DbSet<Tipo> Tipos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Configuração do Muitos para Muitos - JogoTipo
        // Definindo Chave Primária
        modelBuilder.Entity<JogoGenero>()
            .HasKey(jg => new { jg.JogoNumero, jg.JogoTipos });

        #endregion

    }

}
