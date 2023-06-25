using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain;
using WebApi.Domain.Interfaces;

namespace WebApi.Data.Repositories
{
    public class BorrowingRepository : IBorrowingRepository
    {
        private readonly DataContext _context;
        public BorrowingRepository()
        {
            _context = new DataContext();
        }
        public IList<Borrowing> GetAll()
        {
            return _context.Borrowings.ToList();
        }
        public Borrowing GetById(int entityId)
        {
            return _context.Borrowings
                .FirstOrDefault(x => x.Id == entityId);
        }
        public void Save(Borrowing entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Borrowing entity)
        {
            _context.Borrowings.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int entityId)
        {
            var b = GetById(entityId);
            _context.Borrowings.Remove(b);
            _context.SaveChanges();
        }
    }
}