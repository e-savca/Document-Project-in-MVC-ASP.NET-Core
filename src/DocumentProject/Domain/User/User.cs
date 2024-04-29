using Domain.Common;

namespace Domain.User;

/// <summary>
/// Represents a user entity.
/// </summary>
public class User : Entity<int>
{
    /// <summary>
    /// The alphanumeric username with a maximum length of 32 characters.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The user's first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The user's last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The user's middle name.
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// The user's login password.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// The groups to which the user belongs.
    /// </summary>
    public ICollection<UserRole> Roles { get; set; }

    /// <summary>
    /// The bank to which the user is attached (valid only for banking operators).
    /// </summary>
    public Institute.Institute Institute { get; set; }
    /// <summary>
    /// The bank id to which the user is attached (valid only for banking operators).
    /// </summary>
    public int InstituteId { get; set; }

    /// <summary>
    /// A flag indicating whether the user is enabled or disabled in the system.
    /// </summary>
    public bool IsEnabled { get; set; }
}

