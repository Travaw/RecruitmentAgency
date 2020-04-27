using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Сервис для работы с вакансиями
    /// </summary>
    public interface IVacancyAppService : ICommonAppService<VacancyDTO, CreateVacancyDTO, UpdateVacancyDTO>
    {
        /// <summary>
        /// Поиск вакансий
        /// </summary>
        /// <param name="search">Функция поиска</param>
        /// <returns></returns>
        ICollection<VacancyDTO> Search(SearchVacancyDTO search);

        /// <summary>
        /// Получить вакансии работодателя 
        /// </summary>
        /// <param name="userName">Логин</param>
        /// <returns></returns>
        ICollection<VacancyDTO> GetAllForUser(string userName);

        /// <summary>
        /// Установить статус вакансии (открыта/закрыта)
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="status">Статус</param>
        void SetStatus(int id, bool status);
    }
}
