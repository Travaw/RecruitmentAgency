namespace RecruitmentAgency.Domain.Entities
{
    public interface IEntity<IPK>
    {
        IPK Id 
        { 
            get; 
            set; 
        }
    }
}
