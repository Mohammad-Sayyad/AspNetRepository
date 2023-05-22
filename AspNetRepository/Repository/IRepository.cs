using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Security.Principal;

namespace AspNetRepository.Repository
{
    public interface IRepository<TEntity, Tkey>
            where TEntity : class, IEntity<Tkey>
    {
        List<TEntity> GetAll();
        TEntity Find(Tkey Id);
        bool Delete(Tkey Id);
        Tkey Insert(TEntity entity);
    }
}
