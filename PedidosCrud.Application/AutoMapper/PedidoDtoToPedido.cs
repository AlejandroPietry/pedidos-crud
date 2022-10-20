using AutoMapper;
using PedidosCrud.Domain.Models;

namespace PedidosCrud.Application.AutoMapper
{
    public class PedidoDtoToPedido : Profile
    {
        public PedidoDtoToPedido()
        {
            CreateMap<PedidoDtoToPedido, Pedido>();
        }
    }
}
