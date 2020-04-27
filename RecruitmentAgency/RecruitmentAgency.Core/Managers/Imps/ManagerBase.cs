using System;
using System.Collections.Generic;

using RecruitmentAgency.Domain.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Базовый менежер
    /// </summary>
    /// <typeparam name="TRepository">Тип репозитория</typeparam>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public class ManagerBase<TRepository, TEntity, TPK> : IManager<TEntity, TPK>  where TRepository : IRepository<TEntity, TPK>
                                                                                  where TEntity : class, IEntity<TPK>
    {
        protected readonly TRepository repository;

        public ManagerBase(TRepository repository)
        {
            this.repository = repository;
        }

        /// <inheritdoc/>
        public virtual TEntity Create(TEntity user)
        {
            return repository.Save(user);
        }

        /// <inheritdoc/>
        public virtual TEntity Get(TPK id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        /// <inheritdoc/>
        public virtual TEntity Get(Func<TEntity, bool> predicate)
        {
            var entity = repository.Get(predicate);
            return entity;
        }

        /// <inheritdoc/>
        public virtual ICollection<TEntity> GetAll()
        {
            return repository.GetAllList();
        }

        /// <inheritdoc/>
        public virtual TEntity Update(TEntity user)
        {
            return repository.Update(user);
        }

        /// <inheritdoc/>
        public virtual void Delete(TPK id)
        {
            repository.Delete(id);
        }
    }
}
