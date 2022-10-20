using PedidosCrud.Infra.Data.Context;
using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRespository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
