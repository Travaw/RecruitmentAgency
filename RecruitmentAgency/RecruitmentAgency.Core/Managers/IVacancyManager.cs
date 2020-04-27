using System;
using System.Collections.Generic;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="Vacancy"/>
    /// </summary>
    public interface IVacancyManager : IManager<Vacancy, int>
    {
        /// <summary>
        /// Получение всех вакансий работодтеля
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICollection<Vacancy> GetAllForEmployee(int id);

        /// <summary>
        /// Получение всех открытых вакнсий
        /// </summary>
        /// <returns></returns>
        ICollection<Vacancy> GetAllActive();

        /// <summary>
        /// Поиск вакансий
        /// </summary>
        /// <param name="search">Функция поиска</param>
        /// <returns></returns>
        ICollection<Vacancy> Search(Func<Vacancy, bool> search);

        /// <summary>
        /// Поиск вакансий
        /// </summary>
        /// <param name="search">Параметры поиска</param>
        /// <returns></returns>
        ICollection<Vacancy> Search(string name, int? experience, string professionalField, string description, string requirements, int? salary, bool isActive, int? employeeId);

        /// <summary>
        /// Установика статуса вакансии (открыта/закрыта)
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="status">Статус</param>
        void SetStatus(int id, bool status);
    }
}
