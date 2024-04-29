namespace Domain.Common
{
    public class Entity<TId> : IEntity<TId>
    {
        public TId? Id { get; set; } = default!;
    }
}
