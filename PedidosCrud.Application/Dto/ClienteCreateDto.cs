using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PedidosCrud.Application.Dto
{
    public class ClienteCreateDto
    {
        [Required(ErrorMessage = "Digite o nome do usuario!!!")]
        [DisplayName("Nome do cliente")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Digite um nome valido!")]
        public string Nome { get; set; }

    }
}
