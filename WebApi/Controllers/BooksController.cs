/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IBookRepository repository;

        public BooksController()
        {
            this.repository = new BookRepository();
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book item)
        {
            repository.Save(item);
            return Ok(
                new
                {
                    statusCode = 200,
                    message = "Cadastrado com sucesso",
                    item
                }
            );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(
                new 
                { 
                    statusCode = 200, 
                    message = "Livro excluído com sucesso" 
                }
            );
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book item)
        {
            repository.Update(item);
            return Ok(
                new
                {
                    statusCode = 200,
                    message = item.Title + " atualizado com sucesso",
                    item
                }
            );
        }
    }
} */