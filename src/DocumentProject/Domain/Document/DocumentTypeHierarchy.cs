using Domain.Common;

namespace Domain.Document
{
    public class DocumentTypeHierarchy : Entity<int>
    {
        public int MacroId { get; set; }
        public DocumentType Macro { get; set; }
        public int MicroId { get; set; }
        public DocumentType Micro { get; set; }
    }
}
