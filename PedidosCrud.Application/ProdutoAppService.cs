using PedidosCrud.Application.Interfaces;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        public ProdutoAppService(IDomainServiceBase<Produto> domainServiceBase) : base(domainServiceBase)
        {
        }
    }
}
