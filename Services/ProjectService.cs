using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Data;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _projectRepository.GetAll();
        }

        public async Task<Project> GetProject(long? id)
        {

            return await _projectRepository.GetOne(id);
        }

        public async Task CreateProject(Project project)
        {
            _projectRepository.AddProject(project);
            await _projectRepository.Save();
        }

        public async Task EditProject(Project project)
        {
            _projectRepository.EditProject(project);
            await _projectRepository.Save();
        }

        public async Task DeleteProject(Project project)
        {
            _projectRepository.RemoveProject(project);
            await _projectRepository.Save();
        }

        public bool ProjectExist(long? id)
        {
            return _projectRepository.Exists(id);
        }
        
    }
}