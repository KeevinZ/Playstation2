using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playstation2.Models
{
    public class JogoDesenvolvedor
    {
        [Key, Column(Order = 1)]
        public int JogoID { get; set; }
        [ForeignKey("JogoID")]
        public Jogo Jogo { get; set; }

        [Key, Column(Order = 2)]
        public int DesenvolvedorID { get; set; }
        [ForeignKey("DesenvolvedorID")]
        public Desenvolvedor Desenvolvedor { get; set; }
    }
}
