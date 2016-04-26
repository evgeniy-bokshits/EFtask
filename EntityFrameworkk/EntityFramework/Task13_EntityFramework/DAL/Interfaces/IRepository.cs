using System.Collections.Generic;

namespace Task13_EntityFramework.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity: IEntity
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();
    }
}
