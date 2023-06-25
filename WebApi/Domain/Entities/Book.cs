using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Isbn { get; set; }
        public string ReleaseDate { get; set; }
        public IList<Author> Authors { get; set; }
    }
}