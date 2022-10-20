using AutoMapper;
using PedidosCrud.Application.Dto;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application.AutoMapper
{
    internal class ClienteCreateDtoToCliente : Profile
    {
        public ClienteCreateDtoToCliente()
        {
            CreateMap<ClienteCreateDto, Cliente>();
        }
    }
}
