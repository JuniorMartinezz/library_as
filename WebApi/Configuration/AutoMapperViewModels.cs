using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApi.Domain;
using WebApi.Domain.ViewModels;

namespace WebApi.Configuration
{
    public class AutoMapperViewModels : Profile
    {
        public AutoMapperViewModels()
        {
            CreateMap<AuthorViewModel, Author>();
        }
    }
}