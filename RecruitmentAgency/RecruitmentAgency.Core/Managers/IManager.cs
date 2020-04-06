using RecruitmentAgency.Domain.Entities;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Managers
{
    public interface IManager<TEntity, TPK> where TEntity: class, IEntity<TPK>    
    {
        TEntity Create(TEntity entity);

        TEntity Get(TPK id);

        TEntity Get(Func<TEntity, bool> predicate);

        ICollection<TEntity> GetAll();

        TEntity Update(TEntity entity);

        void Delete(TPK id);
    }
}
