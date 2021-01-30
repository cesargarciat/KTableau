using System;
using System.Collections.Generic;
using System.Text;

namespace KTableau.DAL.repositories
{
    public abstract class RepositoryBase
    {
        protected KTableauDBContext _dbContext { get; set; }

        public RepositoryBase(KTableauDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
