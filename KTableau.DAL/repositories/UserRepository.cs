using KTableau.DAL.contracts;
using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KTableau.DAL.repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {

        public UserRepository(KTableauDBContext dbContext) : base(dbContext)
        {

        }


        public async Task<User> CreateAsync(User user)
        {
            user.DateCreation = DateTime.Now;
            await _dbContext.Users.AddAsync(user);
            return user;
        }

        public void Delete(User user)
        {
            _dbContext.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            return await _dbContext.Users.Where(p => p.UserId == userId).SingleOrDefaultAsync();
        }
    }
}
