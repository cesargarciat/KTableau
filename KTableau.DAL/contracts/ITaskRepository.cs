using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KTableau.DAL.contracts
{
    interface ITaskRepository
    {
        // Create a System Task -> Inumerable<TaskProject>
        public Task<IEnumerable<TaskProject>> GetAllAsync();
        public Task<TaskProject> GetByIdAsync(int taskId);

        public Task<TaskProject> CreateAsync(TaskProject taskProject);
        public void Delete(TaskProject taskProject);

        // This section provides methods to retrieve data from relationships.

        public Task<IEnumerable<TaskProject>> GetAllByProjectAsync(int projectId);

        public Task<IEnumerable<TaskProject>> GetAllByProjectASync(Project project);


    }
}
