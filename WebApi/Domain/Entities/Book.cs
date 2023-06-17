using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public int Isbn { get; set; }
        public string ReleaseDate { get; set; }
        public IList<Author> Authors { get; set; }

    }
}