using AutoMapper;
using PedidosCrud.Application.Dto;
using PedidosCrud.Application.Interfaces;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteDomainService _clienteDomainService;
        private readonly IMapper _mapper;
        public ClienteAppService(IClienteDomainService domainServiceBase,
            IMapper mapper) : base(domainServiceBase)
        {
            _clienteDomainService = domainServiceBase;
            _mapper = mapper;
        }

        public void AddCliente(ClienteCreateDto  modelDto)
        {            
            _clienteDomainService.Add(_mapper.Map<Cliente>(modelDto));
        }
    }
}
