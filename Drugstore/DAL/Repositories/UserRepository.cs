using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DrugstoreDBContext _dbContext;

        public UserRepository(DrugstoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IdentityUser FindById(string id)
        {
            return _dbContext.Users.Find(id);
        }

        public void AddRefreshToken(RefreshToken refreshToken)
        {
            _dbContext.Tokens.Add(refreshToken);
            _dbContext.SaveChanges();
        }
    }
}
