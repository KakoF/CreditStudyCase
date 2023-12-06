namespace Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity(long id)
        {
            Id = id;
        }
        public BaseEntity()
        {
        }
        public long Id { get; }
    }
}
