namespace RecruitmentAgency.Domain.Entities
{
    /// <summary>
    /// Сущность
    /// </summary>
    /// <typeparam name="TPK">Тип первичного ключа</typeparam>
    public class Entity:IEntity<int>
    {
        /// <inheritdoc/>
        public virtual int Id
        {
            get;
            set;
        }
    }
}
