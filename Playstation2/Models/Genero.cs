using System.ComponentModel.DataAnnotations;

namespace Pokedex.Models;

[Table("Genero")]
public class Genero
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 20 caracteres")]
    public string Nome { get; set; }
}
