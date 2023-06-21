using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Domain;
using WebApi.Domain.Interfaces;

namespace WebApi.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        public BookRepository()
        {
            _context = new DataContext();
        }
        public IList<Book> GetAll()
        {
            return _context.Books.ToList();
        }
        public Book GetById(int entityId)
        {
            return _context.Books
                .FirstOrDefault(x => x.Id == entityId);
        }
        public void Save(Book entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int entityId)
        {
            var b = GetById(entityId);
            _context.Books.Remove(b);
            _context.SaveChanges();
        }
    }
}