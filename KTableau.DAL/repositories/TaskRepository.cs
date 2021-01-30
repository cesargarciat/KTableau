using KTableau.DAL.contracts;
using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KTableau.DAL.repositories
{
    public class TaskRepository : RepositoryBase , ITaskRepository
    {
        public TaskRepository(KTableauDBContext dbContext) : base(dbContext)
        {
           
        }

        public async Task<TaskProject> CreateAsync(TaskProject taskProject)
        {
            // WARNING: TaskId must not be set, otherwise EF will ignore it.
            taskProject.Date = DateTime.Now;

            // taskProject is a *reference* to the final object
            await _dbContext.Tasks.AddAsync(taskProject);           
            return taskProject;
        }

        public void Delete(TaskProject taskProject)
        {
            _dbContext.Remove(taskProject);
          
        }

        public async Task<IEnumerable<TaskProject>> GetAllAsync()
        {
            return await _dbContext.Tasks.ToListAsync();
        }

        public async Task<TaskProject> GetByIdAsync(int taskId)
        {
            // .Where(a Linq expression to perform)
            // Note: ensure to add Microsoft.EntityFrameworkCore at the 'using' section
            return await _dbContext.Tasks.Where(p => p.TaskId == taskId).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TaskProject>> GetAllByProject(int projectId)
        {
            return await _dbContext.Tasks.Where(p => p.ProjectId == projectId).ToListAsync();
        }

        public async Task<IEnumerable<TaskProject>> GetAllByProject(Project project)
        {
            return await this.GetAllByProject(project.ProjectId);
        }
    }
}
