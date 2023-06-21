using System;
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
        private readonly DataContext _context;
        public UserRepository()
        {
            _context = new DataContext();
        }
        public IList<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User GetById(int entityId)
        {
            return _context.Users
                .FirstOrDefault(x => x.Id == entityId);
        }
        public void Save(User entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int entityId)
        {
            var u = GetById(entityId);
            _context.Users.Remove(u);
            _context.SaveChanges();
        }
    }
}
