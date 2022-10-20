namespace PedidosCrud.Infra.Domain.Models
{
    public class Produto : EntityModelBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
