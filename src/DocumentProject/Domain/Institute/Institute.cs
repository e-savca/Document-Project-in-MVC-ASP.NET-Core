using Domain.Common;

namespace Domain.Institute;

/// <summary>
/// Represents the bank to which the bank operator and documents in the system will be attached. 
/// </summary>
public class Institute : Entity<int>
{
    /// <summary>
    /// Unique aphanumeric code of the bank, maximum 5 characters.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// Name of the bank. Aphanumeric.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Additional information.
    /// </summary>
    public string AdditionalInfo { get; set; }
}
