using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playstation2.Models
{
    public class Jogo
    {
        [Key]
        public int JogoID { get; set; }

        [Required]
        [StringLength(255)]
        public string Titulo { get; set; }

        public int AnoLancamento { get; set; }

        [StringLength(50)]
        public string Plataforma { get; set; } = "PlayStation 2";

        [Required]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [StringLength(200)]
         public string Imagem { get; set; }

        public ICollection<JogoGenero> JogoGeneros { get; set; } 
        public ICollection<JogoDesenvolvedor> JogoDesenvolvedores { get; set; } 

    }
}