using System.ComponentModel.DataAnnotations;

namespace TesteWebApp.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage="O Nome é obrigatório")]
        [MaxLength(80, ErrorMessage = "Nome não pode exceder 80 caracteres")]
        public string Nome { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Email com formato inválido")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }
        public Departamento? Departamento { get; set; }
    }
}
