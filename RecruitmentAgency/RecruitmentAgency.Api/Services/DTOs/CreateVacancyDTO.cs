using System;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для сущности <see cref="Vacancy"/>
    /// </summary>
    public class CreateVacancyDTO
    {
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
        /// Опыт работы
        /// </summary>
        public int Experience
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
        /// Логин работодателя
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
    }
}
