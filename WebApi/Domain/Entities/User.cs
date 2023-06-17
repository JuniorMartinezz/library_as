using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain
{
    public class User : Entity
    {
        public string Name { get; set; }
        public IList<Book> BooksId  { get; set; }
    }
}