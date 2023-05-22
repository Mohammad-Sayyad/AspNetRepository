using AspNetRepository.Models;

namespace AspNetRepository.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
            where TEntity : class, IEntity<TKey>
    {
        public DBMohammadpour db;
        public Repository(DBMohammadpour _db) => db = _db;

        public bool Delete(TKey Id)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(TKey Id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TKey Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
