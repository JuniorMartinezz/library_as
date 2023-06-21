using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain;
using WebApi.Domain.Interfaces;

namespace WebApi.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _context;
        public AuthorRepository()
        {
            _context = new DataContext();
        }

        public IList<Author> GetAll()
        {
            return _context.Authors.ToList();
        }
        public Author GetById(int entityId)
        {
            return _context.Authors
                .FirstOrDefault(x => x.Id == entityId);
        }
        public void Save(Author entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Author entity)
        {
            _context.Authors.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int entityId)
        {
            var a = GetById(entityId);
            _context.Authors.Remove(a);
            _context.SaveChanges();
        }
    }
}