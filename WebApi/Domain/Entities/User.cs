using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain
{
    public class User : Person
    {
        public IList<Book> BorrowedBooks  { get; set; }
    }
}