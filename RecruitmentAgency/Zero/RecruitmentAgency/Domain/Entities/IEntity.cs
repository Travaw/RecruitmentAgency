namespace RecruitmentAgency.Domain.Entities
{
    /// <summary>
    /// Сущность
    /// </summary>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public interface IEntity<TPK>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        TPK Id 
        { 
            get; 
            set; 
        }
    }
}
