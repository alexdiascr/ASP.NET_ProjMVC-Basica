using System.ComponentModel.DataAnnotations;

namespace AppMVCBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {1} caracteres", MinimumLength = 2)]
        public string Descrico { get; set; }

        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }


        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
