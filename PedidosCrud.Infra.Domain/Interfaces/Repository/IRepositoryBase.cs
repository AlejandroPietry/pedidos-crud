using PedidosCrud.Infra.Domain.Models;
using System.Linq.Expressions;

namespace PedidosCrud.Infra.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : EntityModelBase
    {
        public T GetById(int id);
        public IEnumerable<T> Get(Expression<Func<T, bool>> where);
        public IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where);
        public void Add(T entity);
        public void Remove(int id);
        public void Remove(T entity);
        public void Update(T entity);
    }
}
