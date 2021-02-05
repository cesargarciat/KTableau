using KTableau.DAL.contracts;
using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KTableau.DAL.repositories
{
    public class ProjectRepository : RepositoryBase, IProjectRepository

    {
        public ProjectRepository(KTableauDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<Project> CreateAsync(Project project)
        {
            project.DateCreation = DateTime.Now;
            await _dbContext.Projects.AddAsync(project);
            return project;
        }

        public void Delete(Project project)
        {
            _dbContext.Projects.Remove(project);
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int projectId)
        {
            return await _dbContext.Projects.Where(p => p.ProjectId == projectId).SingleOrDefaultAsync();
        }
    }
}
