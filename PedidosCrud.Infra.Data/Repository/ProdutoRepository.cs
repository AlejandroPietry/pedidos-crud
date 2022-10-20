using PedidosCrud.Infra.Data.Context;
using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutosRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
