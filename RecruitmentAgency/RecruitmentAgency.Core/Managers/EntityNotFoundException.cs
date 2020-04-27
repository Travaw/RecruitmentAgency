using System;

namespace RecruitmentAgency.Core
{
    /// <summary>
    /// Исключение, 
    /// </summary>
    class EntityNotFoundException:Exception
    {
        private const string errorMessage = "Не найдено походящих экземпляров сущности ";
        public EntityNotFoundException(string entityName):base(errorMessage+entityName)
        {

        }
    }
}
