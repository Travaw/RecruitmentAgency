using RecruitmentAgency.Domain.Entities;
using RecruitmentAgency.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Managers.Imps
{
    public class ManagerBase<TRepository, TEntity, TPK> : IManager<TEntity, TPK>  where TRepository : IRepository<TEntity, TPK>
                                                                                  where TEntity : class, IEntity<TPK>
    {
        protected readonly TRepository repository;

        public ManagerBase(TRepository repository)
        {
            this.repository = repository;
        }

        public virtual TEntity Create(TEntity user)
        {
            return repository.Save(user);
        }

        public virtual TEntity Get(TPK id)
        {
            return repository.Get(id);
        }

        public virtual TEntity Get(Func<TEntity, bool> predicate)
        {
            return repository.Get(predicate);
        }

        public virtual ICollection<TEntity> GetAll()
        {
            return repository.GetAllList();
        }

        public virtual TEntity Update(TEntity user)
        {
            return repository.Update(user);
        }

        public virtual void Delete(TPK id)
        {
            repository.Delete(id);
        }
    }
}
