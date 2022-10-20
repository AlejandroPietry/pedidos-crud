using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Infra.Domain.Services
{
    public class ProdutoDomainService : DomainServiceBase<Produto>, IProdutoDomainService
    {
        public ProdutoDomainService(IRepositoryBase<Produto> repository) : base(repository)
        {
        }
    }
}
