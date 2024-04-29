using Domain.Common;

namespace Domain.Project;
/// <summary>
/// Represents a project entity to which documents with the MACRO Type = Design are attached.
/// </summary>
public class Project : Entity<int>
{
    /// <summary>
    /// The name of the project. Alphanumeric. Maximum 255 characters.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Reference to the bank with which the project is associated.
    /// </summary>
    public Institute.Institute Institute { get; set; }
    /// <summary>
    /// Reference to the user who created the project.
    /// </summary>
    public User.User User { get; set; }
    /// <summary>
    /// The date from which the project was started.
    /// </summary>
    public DateTime DateFrom { get; set; }
    /// <summary>
    /// Date until which the project was started.
    /// </summary>
    public DateTime DateTo { get; set; }
    /// <summary>
    /// A brif description of the project. Alphanumeric. Maximum 1000 characters.
    /// </summary>
    public string AdditionalInformation { get; set; }
    /// <summary>
    /// Flag indicating whether the project is active.
    /// </summary>
    public bool Active { get; set; }
}
