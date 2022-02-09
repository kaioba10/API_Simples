using System;
using System.ComponentModel.DataAnnotations;

namespace API_Simples.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} deve ter {1} caracteres.", MinimumLength = 11)]
        public string Cpf { get; set; }

        [StringLength(10, ErrorMessage = "O campo {0} deve ter {1} caracteres.", MinimumLength = 10)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} deve ter {1} caracteres.", MinimumLength = 11)]
        public string Celular { get; set; }
        public bool Ativo { get; set; }
    }
}
