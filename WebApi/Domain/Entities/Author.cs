using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public IList<Book> Books { get; set; }
    }
}