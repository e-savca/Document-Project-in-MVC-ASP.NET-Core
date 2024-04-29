using Domain.Common;

namespace Domain.Document;
/// <summary>
/// Represents the basic management object of the system.
/// </summary>
public class Document : Entity<int>
{
    /// <summary>
    /// Gets or sets the institution to which the document is attached.
    /// </summary>
    public Institute.Institute Institute { get; set; }
    public int InstituteId { get; set; }

    /// <summary>
    /// Gets or sets the user who uploaded the document.
    /// </summary>
    public User.User Operator { get; set; }
    public int OperatorId { get; set; }

    /// <summary>
    /// Gets or sets the project to which the document is attached (valid only for macrotype = DESIGN).
    /// </summary>
    public Project.Project Project { get; set; }
    public int ProjectId { get; set; }

    /// <summary>
    /// Gets or sets the name of the file, document. Alphanumeric. Maximum 260 characters.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the date when the document was uploaded into the system.
    /// </summary>
    public DateTime DateUpload { get; set; }

    /// <summary>
    /// Gets or sets the document type.
    /// </summary>
    public DocumentType DocumentType { get; set; }
    public int DocumentTypeId { get; set; }

    /// <summary>
    /// Gets or sets the full path where the document is saved.
    /// An algorithm must be worked out to save the document (a root/BANK/YEAR/MONTH/DocumentName + Type + something.... folder).
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Gets or sets some additional information.
    /// </summary>
    public string AdditionalInformation { get; set; }

    /// <summary>
    /// Gets or sets the date on the basis of which the document will be grouped in the user's graphical interface.
    /// </summary>
    public DateTime DateForGrouping { get; set; }
}
