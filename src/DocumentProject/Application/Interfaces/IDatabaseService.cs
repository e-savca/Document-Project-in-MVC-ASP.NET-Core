using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        public DbSet<Domain.User.User> Users { get; set; }
        public DbSet<Domain.User.Role> Roles { get; set; }
        public DbSet<Domain.User.UserRole> UserRoles { get; set; }

        public DbSet<Domain.Document.Document> Documents { get; set; }
        public DbSet<Domain.Document.DocumentType> DocumentTypes { get; set; }


        public DbSet<Domain.Institute.Institute> Institutes { get; set; }
        public DbSet<Domain.Project.Project> Projects { get; set; }

        public void Save();
        public Task<int> SaveAsync();
        public Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
