using PedidosCrud.Application.Interfaces;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;
using System.Linq.Expressions;

namespace PedidosCrud.Application
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : EntityModelBase
    {
        private readonly IDomainServiceBase<T> _domainServiceBase;

        public AppServiceBase(IDomainServiceBase<T> domainServiceBase)
        {
            _domainServiceBase = domainServiceBase;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> where)
        {
            return _domainServiceBase.Get(where);
        }

        public IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where)
        {
            return _domainServiceBase.GetAsNoTracking(where);
        }

        public T GetById(int id)
        {
            return _domainServiceBase.GetById(id);
        }

        public void Remove(int id)
        {
            _domainServiceBase.Remove(id);
        }

        public void Remove(T entity)
        {
            _domainServiceBase.Remove(entity);
        }

        public void Update(T entity)
        {
            _domainServiceBase.Update(entity);
        }
    }
}
