using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApi.Domain;
using WebApi.Domain.DTOs;

namespace WebApi.Configuration
{
    public class AutoMapperDTOs : Profile
    {
        public AutoMapperDTOs()
        {
            CreateMap<Author, AuthorDTO>().PreserveReferences().MaxDepth(0);
        }
    }
}