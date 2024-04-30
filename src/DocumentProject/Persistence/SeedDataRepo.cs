using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Document;
using Domain.Institute;
using Domain.Project;
using Domain.User;
using Newtonsoft.Json;

namespace Persistence
{
    public class SeedDataRepo
    {
        private readonly string jsonFilePath = @"/App_Data/test.json";
        private readonly List<User> _users;
        private readonly List<Role> _roles;
        private readonly List<UserRole> _userRoles;
        private readonly List<Institute> _institutes;
        private readonly List<Project> _projects;
        private readonly List<DocumentType> _documentTypes;
        private readonly List<DocumentTypeHierarchy> _documentTypeHierarchies;
        private readonly List<Document> _documents;

        public SeedDataRepo(string jsonFilePath)
        {
            // get current directory path from where the program is running

            var jsonData = File.ReadAllText(jsonFilePath);
            var data = JsonConvert.DeserializeObject(jsonData);
            //_users = data["Users"];
            //_roles = data.Roles;
            //_userRoles = data.UserRoles;
            //_institutes = data.Institutes;
            //_projects = data.Projects;
            //_documentTypes = data.DocumentTypes;
            //_documentTypeHierarchies = data.DocumentTypeHierarchies;
            //_documents = data.Documents;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _roles;
        }

        public IEnumerable<UserRole> GetAllUserRoles()
        {
            return _userRoles;
        }

        public IEnumerable<Institute> GetAllInstitutes()
        {
            return _institutes;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projects;
        }

        public IEnumerable<DocumentType> GetAllDocumentTypes()
        {
            return _documentTypes;
        }

        public IEnumerable<DocumentTypeHierarchy> GetAllDocumentTypeHierarchies()
        {
            return _documentTypeHierarchies;
        }

        public IEnumerable<Document> GetAllDocuments()
        {
            return _documents;
        }
    }
}