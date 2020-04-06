using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories.Imps
{
    public abstract class RepositoryBase<TEntity, TPK> : IRepository<TEntity, TPK> where TEntity : class, IEntity<TPK>
    {
        public abstract TEntity Save(TEntity entity);

        public abstract TEntity Update(TEntity entity);

        public abstract TEntity Get(TPK id);

        public virtual TEntity Get(Func<TEntity,bool> predicate)
        {
            return GetAll().Where(predicate).FirstOrDefault();
        }

        public abstract IQueryable<TEntity> GetAll();

        public  IList<TEntity> GetAllList()
        {
            return GetAll().ToList();
        }

        public ICollection<TEntity> Search(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }
        public abstract void Delete(TPK id);


    }
}
