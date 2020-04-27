using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories.Imps
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public abstract class RepositoryBase<TEntity, TPK> : IRepository<TEntity, TPK> where TEntity : class, IEntity<TPK>
    {
        ///<incheritdoc/>
        public abstract TEntity Save(TEntity entity);

        ///<incheritdoc/>
        public abstract TEntity Update(TEntity entity);

        ///<incheritdoc/>
        public abstract TEntity Get(TPK id);

        ///<incheritdoc/>
        public virtual TEntity Get(Func<TEntity,bool> predicate)
        {
            return GetAll().Where(predicate).FirstOrDefault();
        }

        ///<incheritdoc/>
        public abstract IQueryable<TEntity> GetAll();

        ///<incheritdoc/>
        public IList<TEntity> GetAllList()
        {
            return GetAll().ToList();
        }

        ///<incheritdoc/>
        public ICollection<TEntity> Search(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }

        ///<incheritdoc/>
        public abstract void Delete(TPK id);
    }
}
