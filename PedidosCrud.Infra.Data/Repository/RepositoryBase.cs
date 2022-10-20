using Microsoft.EntityFrameworkCore;
using PedidosCrud.Infra.Data.Context;
using PedidosCrud.Infra.Domain.Interfaces.Repository;
using PedidosCrud.Infra.Domain.Models;
using System.Linq.Expressions;

namespace PedidosCrud.Infra.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityModelBase
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> where) 
            => _context.Set<T>().Where(where);
        

        public IEnumerable<T> GetAsNoTracking(Expression<Func<T, bool>> where) 
            => _context.Set<T>().AsNoTracking().Where(where);
        

        public T GetById(int id) => _context.Set<T>().Find(id);

        public void Remove(int id)
        {
            var entity = GetById(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
