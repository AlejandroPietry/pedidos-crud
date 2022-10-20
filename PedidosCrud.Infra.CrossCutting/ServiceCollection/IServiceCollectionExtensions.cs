using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PedidosCrud.Application;
using PedidosCrud.Application.Dto;
using PedidosCrud.Application.Interfaces;
using PedidosCrud.Infra.Data.Context;
using PedidosCrud.Infra.Data.Repository;
using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Services;

namespace PedidosCrud.Infra.CrossCutting.ServiceCollection
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient<IProdutoAppService, ProdutoAppService>();

            services.AddAutoMapper(typeof(ClienteCreateDto));

            services.AddTransient(typeof(AppServiceBase<>), typeof(AppServiceBase<>));

            return services;
        }
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddTransient<IClienteDomainService, ClienteDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient(typeof(IDomainServiceBase<>), typeof(DomainServiceBase<>));

            return services;
        }
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IClienteRespository, ClienteRepository>();
            services.AddTransient<IProdutosRepository, ProdutoRepository>();
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("TESTE"));
            return services;
        }
    }
}
