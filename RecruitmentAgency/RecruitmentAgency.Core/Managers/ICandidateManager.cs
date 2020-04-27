using System;
using System.Collections.Generic;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="Candidate"/>
    /// </summary>
    public interface ICandidateManager :IManager<Candidate, int>
    {
        /// <summary>
        /// Получение кандидата по id учётной записи
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        Candidate GetByUser(int id);

        /// <summary>
        /// Получение кандидата по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        Candidate GetByUser(string login);

        /// <summary>
        /// Поиск кандидатов
        /// </summary>
        /// <param name="search">Функция поиска</param>
        /// <returns></returns>
        ICollection<Candidate> Search(Func<Candidate, bool> search);

        /// <summary>
        /// Поиск кандидатов
        /// </summary>
        /// <param name="search">Функция поиска</param>
        /// <returns></returns>
        ICollection<Candidate> Search(int? experience, string professionalField, string skills);
    }
}
