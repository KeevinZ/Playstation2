using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playstation2.Models
{
    public class Genero
    {
        [Key]
        public int GeneroID { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeGenero { get; set; }

        public ICollection<JogoGenero> JogoGenero { get; set; } = new List<JogoGenero>();
    }
}
