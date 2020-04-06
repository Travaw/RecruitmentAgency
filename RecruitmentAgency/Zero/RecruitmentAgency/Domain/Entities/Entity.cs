namespace RecruitmentAgency.Domain.Entities
{
    public class Entity:IEntity<int>
    {
        public virtual int Id
        {
            get;
            set;
        }
    }
}
