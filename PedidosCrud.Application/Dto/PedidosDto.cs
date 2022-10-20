using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application.Dto
{
    public class PedidosDto
    {
        public Cliente Cliente { get; set; }
        public ICollection<Produto> Produtos { get; set; }

    }
}
