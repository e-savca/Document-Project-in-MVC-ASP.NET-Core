using Application.Interfaces;
using Domain.Document;
using Domain.Institute;
using Domain.Project;
using Domain.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<UserRole> UserRoles { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public DbSet<Institute> Institutes { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;

        public DatabaseService(DbContextOptions<DatabaseService> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public void Save()
        {
            this.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return this.SaveChangesAsync();
        }

        public Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return this.SaveChangesAsync(cancellationToken);
        }
    }
}
