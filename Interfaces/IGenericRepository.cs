
using System.Linq.Expressions;
using ProyectoBackendCine.Entities;

namespace ProyectoBackendCine.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync( int id);
        Task<IEnumerable<T>> GetAllAsync();
        //Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        void Add(T entity); 
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        
    }
    
}