namespace Domain.Common;

/// <summary>
/// Interface of base class for all entities
/// </summary>
/// <typeparam name="TId"></typeparam>
public interface IEntity<TId>
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    TId Id { get; set; }
}
