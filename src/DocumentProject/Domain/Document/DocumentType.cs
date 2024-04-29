using Domain.Common;

namespace Domain.Document;

/// <summary>
/// Represents a document type entity.
/// </summary>
public class DocumentType : Entity<int>
{
    /// <summary>
    /// Gets or sets the code of the document type.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the name of the document type.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the document type.
    /// </summary>
    public string TypeDescription { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the document type is a macro.
    /// </summary>
    public bool IsMacro { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the document type is date grouped.
    /// </summary>
    public bool IsDateGrouped { get; set; }
}
