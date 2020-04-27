using System;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для обновления сущности <see cref="Vacancy"/>
    /// </summary>
    public class UpdateVacancyDTO
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Должность
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Требования
        /// </summary>
        public string Requierements
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public int Experience
        {
            get;
            set;
        }

        /// <summary>
        /// Срок действия
        /// </summary>
        public DateTime Period
        {
            get;
            set;
        }

        /// <summary>
        /// Минимальная з/п
        /// </summary>
        public int SalaryFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Максимальная з/п
        /// </summary>
        public int SalaryTo
        {
            get;
            set;
        }

        /// <summary>
        /// Статус (открыта/закрыта)
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор работодателя
        /// </summary>
        public int? EmployeeId
        {
            get;
            set;
        }
    }
}
