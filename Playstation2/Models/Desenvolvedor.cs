using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Playstation2.Models
{
    public class Desenvolvedor
    {
        [Key]
        public int DesenvolvedorID { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeDesenvolvedor { get; set; }

        public ICollection<JogoDesenvolvedor> JogoDesenvolvedor { get; set; } = new List<JogoDesenvolvedor>();
    }
}
