using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}