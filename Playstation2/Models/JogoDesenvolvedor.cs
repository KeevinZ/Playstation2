using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playstation2.Models;

[Table("JogoDesenvolvedor")]
public class JogoDesenvolvedor
{
    [Key, Column(Order = 1)]
    public int JogoNumero { get; set; }
    [ForeignKey("JogoNumero")]
    public Jogo Jogo { get; set; }

    [Key, Column(Order = 2)]
    public int DesevolvedorID { get; set; }
    [ForeignKey("DesenvolvedorId")]
    public Desenvolvedor Desenvolvedor { get; set; }
}