using System.ComponentModel.DataAnnotations;

namespace Playstation2.Models;

[Table("Jogo")]
public class Jogo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Numero { get; set; }
    

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    [Required]
    [Column(TypeName = "decimal(4)")]
    public decimal AnoLancamento { get; set; }
    
    [Required]
    public int DesenvolvedorId { get; set; }
    [ForeignKey("DesenvolvedorId")]
    public Desenvolvedor Desenvolvedor { get; set; }

    [Required]
    public int GeneroId { get; set; }
    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; }


    [StringLength(200)]
    public string Imagem { get; set; }
    
    [StringLength(400)]
    public string Animacao { get; set; }

}
