using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Domain.Models
{
    public class Pedido : EntityModelBase
    {
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
