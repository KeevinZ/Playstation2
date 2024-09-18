using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playstation2.Models
{
    public class JogoGenero
    {
        [Key, Column(Order = 1)]
        public int JogoID { get; set; }
        public Jogo Jogo { get; set; }

        [Key, Column(Order = 2)]
        public int GeneroID { get; set; }
        public Genero Genero { get; set; }
    }
}
