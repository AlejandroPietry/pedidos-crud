using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Interfaces.Services;
using PedidosCrud.Infra.Domain.Models;
using System.Linq.Expressions;

namespace PedidosCrud.Infra.Domain.Services
{
    public class DomainServiceBase<T> : IDomainServiceBase<T> where T : EntityModelBase
    {
        private readonly IRepositoryBase<T> _repository;

        public DomainServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> where)
        {
            return _repository.Get(where);
        }

        public IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where)
        {
            return _repository.GetAsNoTracking(where);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
