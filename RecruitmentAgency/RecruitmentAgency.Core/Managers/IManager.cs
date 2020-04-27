using System;
using System.Collections.Generic;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public interface IManager<TEntity, TPK> where TEntity: class, IEntity<TPK>    
    {
        /// <summary>
        /// Создание сущности
        /// </summary>
        /// <param name="entity">Создваемая сущность</param>
        /// <returns></returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Получение сущности
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        TEntity Get(TPK id);

        /// <summary>
        /// Получение сущности
        /// </summary>
        /// <param name="id">Функция поиска</param>
        /// <returns></returns>
        TEntity Get(Func<TEntity, bool> predicate);

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns></returns>
        ICollection<TEntity> GetAll();

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="entity">Обновляемая сущность</param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Удаление сущности
        /// </summary>
        /// <param name="id">Идентификатор</param>
        void Delete(TPK id);
    }
}
