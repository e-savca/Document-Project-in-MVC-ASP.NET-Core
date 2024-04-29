using Domain.Common;

namespace Domain.User;
/// <summary>
/// Represents a role entity with an integer identifier.
/// </summary>
public class Role : Entity<int>
{
    /// <summary>
    /// The name of the role.
    /// </summary>
    public string Name { get; set; }
}
