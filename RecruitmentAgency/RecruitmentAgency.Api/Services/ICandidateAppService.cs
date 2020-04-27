using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Сервис для работы с кандидатами
    /// </summary>
    public interface ICandidateAppService : ICommonAppService<CandidateDTO, CreateCandidateDTO, UpdateCandidateDTO>
    {
        /// <summary>
        /// Получение кандидата по id учётной записи
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        CandidateDTO GetByUser(int id);

        /// <summary>
        /// Получение кандидата по логину учётной записи
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        CandidateDTO GetByUser(string login);

        /// <summary>
        /// Поиск кандидатов
        /// </summary>
        /// <param name="search">Функция поиска</param>
        /// <returns></returns>
        ICollection<CandidateDTO> Search(SearchCandidateDTO search);
    }
}
