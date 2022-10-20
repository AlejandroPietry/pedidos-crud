using AutoMapper;
using PedidosCrud.Application.Dto;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Application.AutoMapper
{
    public class ProdutoDtoToProduto : Profile
    {
        public ProdutoDtoToProduto()
        {
            CreateMap<ProdutoDto, Produto>().ReverseMap();
        }
    }
}
