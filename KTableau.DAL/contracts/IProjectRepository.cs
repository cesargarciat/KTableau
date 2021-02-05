using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KTableau.DAL.contracts
{
    interface IProjectRepository
    {
        public Task<IEnumerable<Project>> GetAllAsync();

        public Task<Project> GetByIdAsync(int projectId);

        public Task<Project> CreateAsync(Project project);

        public void Delete(Project project);



    }
}
