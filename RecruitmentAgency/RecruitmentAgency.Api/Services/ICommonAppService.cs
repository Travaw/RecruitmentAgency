using System.Collections.Generic;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Базовый сервис
    /// </summary>
    /// <typeparam name="DTO"></typeparam>
    /// <typeparam name="CreateDTO"></typeparam>
    /// <typeparam name="UpdateDTO"></typeparam>
    public interface ICommonAppService<DTO, CreateDTO, UpdateDTO>
    {
        /// <summary>
        /// Создание
        /// </summary>
        /// <param name="createUserDTO">Создаваемая сущность</param>
        /// <returns></returns>
        DTO Create(CreateDTO createUserDTO);

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="updateUserDTO">Обновляемая сущность</param>
        /// <returns></returns>
        DTO Update(UpdateDTO updateUserDTO);

        /// <summary>
        /// Получение
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        DTO Get(int id);

        /// <summary>
        /// Получение всех записей
        /// </summary>
        /// <returns></returns>
        ICollection<DTO> GetAll();

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="id">Идентификтор</param>
        void Delete(int id);
    }
}
