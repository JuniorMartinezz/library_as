using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Repositories;
using WebApi.Domain;
using WebApi.Domain.DTOs;
using WebApi.Domain.Interfaces;
using WebApi.Domain.ViewModels;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public AuthorsController(IMapper mapper)
        {
            this._repository = new AuthorRepository();
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var authors = _mapper.Map<IList<AuthorDTO>>(_repository.GetAll());
            return HttpMessageOk(authors);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var author = _mapper.Map<AuthorDTO>(_repository.GetById(id));
            return HttpMessageOk(author);
        }

        [HttpPost]
        public IActionResult Post(AuthorViewModel model)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var author = _mapper.Map<Author>(model);
            _repository.Save(author);

            return HttpMessageOk(_mapper.Map<AuthorDTO>(author));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author =  _repository.GetById(id);

            if (author == null) 
                return NotFound();
            else 
                _repository.Delete(id);
                return HttpMessageOk("Autor excluído com sucesso!");
        }

        [HttpPut]
        public IActionResult Put(AuthorViewModel model)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var author = _mapper.Map<Author>(model);
            _repository.Update(author);

            return HttpMessageOk(_mapper.Map<AuthorDTO>(author));
        }

        private IActionResult HttpMessageOk(dynamic data = null)
        {
            if(data == null)
                return NoContent();
            else
                return Ok(new
                {
                    data
                });
        }

        private IActionResult HttpMessageError(string message = "")
        {
            return BadRequest(new
            {
                message
            });
        }
    }
}