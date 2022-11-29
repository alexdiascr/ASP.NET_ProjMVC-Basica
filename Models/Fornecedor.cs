using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMVCBasica.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} nome é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
