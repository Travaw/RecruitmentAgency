namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Внешние ключи
    /// </summary>
    public static class FKColumnNames
    {
        /// <summary>
        /// Внешний ключ для таблицы Пользователи
        /// </summary>
        public const string UserFK = "UserId";

        /// <summary>
        /// Внешний ключ для таблицы Работодатели
        /// </summary>
        public const string EmployeeFK = "EmployeeId";

        /// <summary>
        /// Внешний ключ для таблицы Роли
        /// </summary>
        public const string RoleFK = "RoleId";
    }
}
