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
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UsersController()
        {
            this.repository = new UserRepository();
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User item)
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
                    message = "Usuário excluído com sucesso" 
                }
            );
        }

        [HttpPut]
        public IActionResult Put([FromBody] User item)
        {
            repository.Update(item);
            return Ok(
                new
                {
                    statusCode = 200,
                    message = item.Name + " atualizado com sucesso",
                    item
                }
            );
        }
    }
} */