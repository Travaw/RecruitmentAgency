using System;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для сущности <see cref="Vacancy"/>
    /// </summary>
    public class VacancyDTO
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
        /// Сфера деятельности
        /// </summary>
        public string ProfessionalField
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
        /// Дта создания
        /// </summary>
        public DateTime CreationDate
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
        /// Работодатель
        /// </summary>
        public EmployeeDTO Employee
        {
            get;
            set;
        }
    }
}
