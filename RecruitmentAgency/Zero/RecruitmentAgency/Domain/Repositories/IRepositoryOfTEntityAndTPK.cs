using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories
{
    public interface IRepository<TEntity, TPK>: IRepository where TEntity: class, IEntity<TPK> 
    {
        TEntity Save(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Get(TPK id);

        TEntity Get(Func<TEntity, bool> predicate);
        ICollection<TEntity> Search(Func<TEntity, bool> predicate);

        IQueryable<TEntity> GetAll();

        IList<TEntity> GetAllList();

        void Delete(TPK id);
    }
}
