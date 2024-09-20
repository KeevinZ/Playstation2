using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playstation2.Models
{
    public class Jogo
    {
        internal object Genero;

        [Key]
        public int JogoID { get; set; }

        [Required]
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public required Genero Genero { get; set; }

        [Required]
        public int DesenvolvedorId { get; set; }
        [ForeignKey("DesenvolvedorId")]
        public Desenvolvedor Desenvolvedor { get; set; }

        [Required]
        [StringLength(255)]
        public string Titulo { get; set; }

        public int AnoLancamento { get; set; }

        [StringLength(50)]
        public string Plataforma { get; set; } = "PlayStation 2";

        [Required]
        [StringLength(1000)]
        public string Descricao { get; set; }

        public ICollection<JogoGenero> JogoGenero { get; set; } = new List<JogoGenero>();
        public ICollection<JogoDesenvolvedor> JogoDesenvolvedor { get; set; } = new List<JogoDesenvolvedor>();
        public object Generos { get; internal set; }
    }
}

// [StringLength(200)]
// public string Imagem { get; set; }

// [StringLength(400)]
// public string Animacao { get; set; }