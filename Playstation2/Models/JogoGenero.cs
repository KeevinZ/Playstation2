using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playstation2.Models;

[Table("JogoGenero")]
public class JogoGenero
{
    [Key, Column(Order = 1)]
    public int JogoNumero { get; set; }
    [ForeignKey("JogoNumero")]
    public Jogo Jogo { get; set; }

    [Key, Column(Order = 2)]
    public int DesevolvedorID { get; set; }
    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; }
}