using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Repositories;
using WebApi.Domain;
using WebApi.Domain.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BooksController(IMapper mapper)
        {
            this._repository = new BookRepository();
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _mapper.Map<IList<Book>>(_repository.GetAll());
            return HttpMessageOk(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var book = _mapper.Map<Book>(_repository.GetById(id));
            return HttpMessageOk(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var book = _mapper.Map<Book>(item);
            _repository.Save(book);

            return HttpMessageOk(_mapper.Map<Book>(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book =  _repository.GetById(id);

            if (book == null) 
                return NotFound();
            else 
                _repository.Delete(id);
                return HttpMessageOk("Livro excluído com sucesso!");
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var book = _mapper.Map<Book>(item);
            _repository.Update(book);

            return HttpMessageOk(_mapper.Map<Book>(item));
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