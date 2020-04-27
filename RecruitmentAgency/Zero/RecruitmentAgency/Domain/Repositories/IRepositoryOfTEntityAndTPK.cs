using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPK">Тип первичного ключ</typeparam>
    public interface IRepository<TEntity, TPK>: IRepository where TEntity: class, IEntity<TPK> 
    {
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="entity">Сохраняемя сущность</param>
        /// <returns></returns>
        TEntity Save(TEntity entity);

        /// <summary>
        /// Оновить сущность
        /// </summary>
        /// <param name="entity">Обновляемая сущность</param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Получить сущность
        /// </summary>
        /// <param name="id">Получаемая сущность</param>
        /// <returns></returns>
        TEntity Get(TPK id);

        /// <summary>
        /// Получить сущность
        /// </summary>
        /// <param name="predicate">Получаемая сущность</param>
        /// <returns></returns>
        TEntity Get(Func<TEntity, bool> predicate);

        /// <summary>
        /// Найти сущность
        /// </summary>
        /// <param name="predicate">Функция поиска</param>
        /// <returns></returns>
        ICollection<TEntity> Search(Func<TEntity, bool> predicate);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns></returns>
        IList<TEntity> GetAllList();

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="id">Идентификатор удаляемой сущности</param>
        void Delete(TPK id);
    }
}
