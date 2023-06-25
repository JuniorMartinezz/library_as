using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Data.Types;
using WebApi.Domain;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }
        
        public DataContext() {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "library_schema.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Author> Authors  { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
        }
    }
}