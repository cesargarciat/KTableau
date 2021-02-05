using KTableau.DAL.contracts;
using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KTableau.DAL.repositories
{
    public class TeamRepository : RepositoryBase, ITeamRepository
    {
        public TeamRepository(KTableauDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<Team> CreateAsync(Team team)
        {
            await _dbContext.Teams.AddAsync(team);
            return team;
        }

        public void Delete(Team team)
        {
            _dbContext.Teams.Remove(team);
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _dbContext.Teams.ToListAsync();
        }

        public async Task<IEnumerable<Team>> GetAllByUserAsync(int userId)
        {
            return await _dbContext.Teams.Where(p => p.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Team>> GetAllByUserAsync(User user)
        {
            return await this.GetAllByUserAsync(user.UserId);
        }

       
    }
}
