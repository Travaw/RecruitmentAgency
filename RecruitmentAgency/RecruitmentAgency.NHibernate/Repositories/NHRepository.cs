using NHibernate;
using System;
using System.Linq;

using RecruitmentAgency.Domain.Entities;
using RecruitmentAgency.Domain.Repositories.Imps;


namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Базовый репозиторий NHibernate
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public class NHRepository<TEntity, TPK>:RepositoryBase<TEntity, TPK> where TEntity : class, IEntity<TPK>
    {
        protected readonly ISession session;

        public NHRepository(ISession session)
        {
            this.session = session;
            
        }

        /// <inheritdoc/>
        public override TEntity Save(TEntity entity)
        {
            using(var transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
            return entity;
        }

        /// <inheritdoc/>
        public override TEntity Update(TEntity entity)
        {
            using (var transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
            }
            return entity;
        }

        /// <inheritdoc/>
        public override TEntity Get(TPK id)
        {
            return session.Get<TEntity>(id);
        }

        /// <inheritdoc/>
        public override TEntity Get(Func<TEntity, bool> predicate)
        {
            return session.Query<TEntity>().Where(predicate).FirstOrDefault();
        }

        /// <inheritdoc/>
        public override IQueryable<TEntity> GetAll()
        {
            return session.Query<TEntity>();
        }
        
        /// <inheritdoc/>
        public override void Delete(TPK id)
        {
            using (var transaction = session.BeginTransaction())
            {
                var entity = session.Load<TEntity>(id);
                session.Delete(entity);
                transaction.Commit();
            }
        }
    }
}
