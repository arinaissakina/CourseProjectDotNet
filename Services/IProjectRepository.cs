using System.Collections.Generic;
using System.Threading.Tasks;
using CourseProject.Models;

namespace CourseProject.Services
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();
        Task<Project> GetOne(long? id);
        void AddProject(Project project);
        void EditProject(Project project);
        Task Save();
        void RemoveProject(Project project);
        bool Exists(long? id);
    }
}