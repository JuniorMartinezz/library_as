/* using System;
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
        private readonly DataContext context;
        public BookRepository(DataContext context)
        {
            this.context = context;
        }
        public bool Delete(int entityId)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == entityId);

            if (book == null)
                return false;
            else
            {
                context.Books.Remove(book);
                return true;
            }
        }
        public async Task<IList<Book>> GetAllAsync()
        {
            return await context.Books.ToListAsync();
        }
        public async Task<Book> GetByIdAsync(int entityId)
        {
            return await context.Books
                .FirstOrDefaultAsync(x => x.Id == entityId);
        }
        public void Save(Book entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public void Update(Book entity)
        {
            context.Books.Update(entity);
            context.SaveChanges();
        }
    }
} */