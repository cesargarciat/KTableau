using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KTableau.DAL.contracts
{
    interface ITeamRepository
    {
        public Task<IEnumerable<Team>> GetAllAsync();

        /**
         * We cannot implement this method, because there is no 'TeamId' property to search for
         */
        //public Task<Team> GetByIdAsync(int teamId);

        public void Delete(Team team);

        public Task<Team> CreateAsync(Team team);

        // This section provides methods to retrieve data from relationships.

        public Task<IEnumerable<Team>> GetAllByUserAsync(int userId);

        public Task<IEnumerable<Team>> GetAllByUserAsync(User user);




    }
}
