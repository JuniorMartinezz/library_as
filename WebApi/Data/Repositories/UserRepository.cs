/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain;
using WebApi.Domain.Interfaces;

namespace WebApi.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }

        public bool Delete(int entityId)
        {
            var user = context.Users.FirstOrDefault(x => x.Id == entityId);

            if (user == null)
                return false;
            else
            {
                context.Users.Remove(user);
                return true;
            }
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int entityId)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == entityId);
        }

        public void Save(User entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(User entity)
        {
            context.Users.Update(entity);
            context.SaveChanges();
        }
    }
}
 */