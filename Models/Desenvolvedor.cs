using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;    
    
 namespace Playstation2.Models;

[Table("Desenvolvedor")]
public class Desenvolvedor   
    
    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }