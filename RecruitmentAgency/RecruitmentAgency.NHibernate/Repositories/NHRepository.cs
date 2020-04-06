using NHibernate;
using RecruitmentAgency.Domain.Entities;
using RecruitmentAgency.Domain.Repositories;
using RecruitmentAgency.Domain.Repositories.Imps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class NHRepository<TEntity, TPK>:RepositoryBase<TEntity, TPK> where TEntity : class, IEntity<TPK>
    {
        protected readonly ISession session;

        public NHRepository(ISession session)
        {
            this.session = session;
            
        }

        public override TEntity Save(TEntity entity)
        {
            using(var transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
            return entity;
        }


        public override TEntity Update(TEntity entity)
        {
            using (var transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
            }
            return entity;
        }

        public override TEntity Get(TPK id)
        {
            return session.Get<TEntity>(id);
        }

        public override TEntity Get(Func<TEntity, bool> predicate)
        {
            return session.Query<TEntity>().Where(predicate).FirstOrDefault();
        }

        public override IQueryable<TEntity> GetAll()
        {
            return session.Query<TEntity>();
        }

        

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
