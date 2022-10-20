namespace PedidosCrud.Infra.Domain.Models
{
    public class Cliente : EntityModelBase
    {
        public string Nome { get; set; }
        public ICollection<Produto> ProdutosCliente { get; set; }
    }
}
