using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Document;
using Domain.Institute;
using Domain.Project;
using Domain.User;

namespace Persistence
{
    public class SeedDataRepo
    {
        public static List<Role> GetRoles()
        {
            return new List<Role>{
                new Role { Id = 1, Name = "Administrator" },
                new Role { Id = 2, Name = "Cedacri Operator" },
                new Role { Id = 3, Name = "Bank Operator" }
            };
        }

        public static List<User> GetUsers()
        {
            return new List<User> {
                new User
                {
                    Id = 1,
                    Username = "CR001",
                    FirstName = "John",
                    LastName = "Doe",
                    MiddleName = "",
                    Password = "password1",
                    Email = "user1@example.com",
                    IsEnabled = true
                },
                new User
                {
                    Id = 2,
                    Username = "CR002",
                    FirstName = "Jane",
                    LastName = "Smith",
                    MiddleName = "Anne",
                    Password = "password2",
                    Email = "user2@example.com",
                    IsEnabled = true
                },
                new User
                {
                    Id = 3,
                    Username = "CR003",
                    FirstName = "Michael",
                    LastName = "Johnson",
                    MiddleName = "David",
                    Password = "password3",
                    Email = "user3@example.com",
                    InstituteId = 3,
                    IsEnabled = true
                }
            };
        }

        public static List<UserRole> GetUserRoles()
        {
            return new List<UserRole>{
                new UserRole { Id = 1, UserId = 1, RoleId = 1 },
                new UserRole { Id = 2, UserId = 1, RoleId = 2 },
                new UserRole { Id = 3, UserId = 1, RoleId = 3 },
                new UserRole { Id = 4, UserId = 2, RoleId = 2 },
                new UserRole { Id = 5, UserId = 3, RoleId = 3 }
            };
        }

        public static List<Institute> GetInstitutes()
        {
            return new List<Institute>
            {
                new Institute { Id = 1, Code = "B001", Name = "Bank of America", AdditionalInfo = "Some additional info about Bank of America" },
                new Institute { Id = 2, Code = "B002", Name = "Chase Bank", AdditionalInfo = "Some additional info about Chase Bank" },
                new Institute { Id = 3, Code = "B003", Name = "Wells Fargo", AdditionalInfo = "Some additional info about Wells Fargo" }

            };
        }

        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Name = "Project A", InstituteId = 1, UserId = 3, DateFrom = new DateTime(2022, 01, 01), DateTo = new DateTime(2022, 12, 31), AdditionalInformation = "Sample project A description", Active = true },
                new Project { Name = "Project B", InstituteId = 2, UserId = 3, DateFrom = new DateTime(2022, 02, 01), DateTo = new DateTime(2022, 11, 30), AdditionalInformation = "Sample project B description", Active = true }

            };
        }

        public static List<DocumentType> GetDocumentTypes()
        {
            return new List<DocumentType>
            {
                new DocumentType { Id = 1, Code = "SRV_RPT", Name = "Service Report", TypeDescription = "Description for Service Report", IsMacro = true, IsDateGrouped = true },
                new DocumentType { Id = 2, Code = "NTWRK", Name = "Network", TypeDescription = "Description for Network", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 3, Code = "SEC", Name = "Security", TypeDescription = "Description for Security", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 4, Code = "CHNG", Name = "Change", TypeDescription = "Description for Change", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 5, Code = "BKUP", Name = "Backup", TypeDescription = "Description for Backup", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 6, Code = "SLA_RPT", Name = "SLA Report", TypeDescription = "Description for SLA Report", IsMacro = true, IsDateGrouped = true },
                new DocumentType { Id = 7, Code = "DSGN", Name = "Design", TypeDescription = "Description for Design", IsMacro = true, IsDateGrouped = false },
                new DocumentType { Id = 8, Code = "ANLYS", Name = "Analysis", TypeDescription = "Description for Analysis", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 9, Code = "TRNS", Name = "Transition", TypeDescription = "Description for Transition", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 10, Code = "PRD", Name = "Production", TypeDescription = "Description for Production", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 11, Code = "TST", Name = "Testing", TypeDescription = "Description for Testing", IsMacro = false, IsDateGrouped = false },
                new DocumentType { Id = 12, Code = "MNT", Name = "Monitoring", TypeDescription = "Description for Monitoring", IsMacro = false, IsDateGrouped = false }
            };
        }

        public static List<DocumentTypeHierarchy> GetDocumentTypeHierarchies()
        {
            return new List<DocumentTypeHierarchy>
            {
                new DocumentTypeHierarchy { MacroId = 1, MicroId = 2 },
                new DocumentTypeHierarchy { MacroId = 1, MicroId = 3 },
                new DocumentTypeHierarchy { MacroId = 1, MicroId = 4 },
                new DocumentTypeHierarchy { MacroId = 1, MicroId = 5 },
                new DocumentTypeHierarchy { MacroId = 7, MicroId = 8 },
                new DocumentTypeHierarchy { MacroId = 7, MicroId = 9 },
                new DocumentTypeHierarchy { MacroId = 7, MicroId = 10 },
                new DocumentTypeHierarchy { MacroId = 7, MicroId = 11 },
                new DocumentTypeHierarchy { MacroId = 7, MicroId = 12 }
            };
        }

        public static List<Document> GetDocuments()
        {
            return new List<Document>
            {
                new Document
                {
                    InstituteId = 1,
                    OperatorId = 3,
                    ProjectId = 2,
                    Name = "Document1.pdf",
                    DateUpload = DateTime.Parse("2022-03-15T10:00:00"),
                    DocumentTypeId = 1,
                    Path = "root/BANK/2022/03/Document1.pdf",
                    AdditionalInformation = "Sample document 1",
                    DateForGrouping = DateTime.Parse("2022-03-15T00:00:00")
                },
                new Document
                {
                    InstituteId = 2,
                    OperatorId = 3,
                    ProjectId = 1,
                    Name = "Document2.docx",
                    DateUpload = DateTime.Parse("2022-03-16T11:30:00"),
                    DocumentTypeId = 7,
                    Path = "root/BANK/2022/03/Document2.docx",
                    AdditionalInformation = "Sample document 2",
                    DateForGrouping = DateTime.Parse("2022-03-16T00:00:00")
                }
            };
        }
    }
}