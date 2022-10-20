using PedidosCrud.Application.Dto;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        public void AddCliente(ClienteCreateDto modelDto);
    }
}
