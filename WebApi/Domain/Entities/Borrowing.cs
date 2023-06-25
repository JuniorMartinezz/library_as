using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Domain
{
    public class Borrowing
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string DateOfBorrowing { get; set; }
        public string Status { get; set; }
    }
}