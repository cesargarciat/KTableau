using KTableau.DAL.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KTableau.DAL.contracts
{
    interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllAsync();

        public Task<User> GetByIdAsync(int userId);

        public Task<User> CreateAsync(User user);

        public void Delete(User user);



    }
}
