using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Infra.Domain.Services
{
    public class ClienteDomainService : DomainServiceBase<Cliente>, IClienteDomainService
    {
        public ClienteDomainService(IRepositoryBase<Cliente> repository) : base(repository)
        {
        }
    }
}
