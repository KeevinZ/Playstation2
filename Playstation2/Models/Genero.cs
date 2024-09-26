using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playstation2.Models
{
    public class Genero
    {
        [Key]
        public int GeneroID { get; set; }

    [Required(ErrorMessage = "Informe a gênero")]
    [StringLength(25, ErrorMessage = "O gênero deve possuir no máximo 25 caracteres")]
    public string NomeGenero { get; set; }

    [Required(ErrorMessage = "Informe a cor")]
    [StringLength(25, ErrorMessage = "A Cor deve possuir no máximo 25 caracteres")]
    public string Cor { get; set; }

        public ICollection<JogoGenero> JogoGeneros { get; set; } = new List<JogoGenero>();
    }
}
