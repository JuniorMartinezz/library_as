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
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            this._repository = new UserRepository();
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var user = _mapper.Map<IList<User>>(_repository.GetAll());
            return HttpMessageOk(user);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _mapper.Map<User>(_repository.GetById(id));
            return HttpMessageOk(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var user = _mapper.Map<User>(item);
            _repository.Save(user);

            return HttpMessageOk(_mapper.Map<User>(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user =  _repository.GetById(id);

            if (user == null) 
                return NotFound();
            else 
                _repository.Delete(id);
                return HttpMessageOk("Usuário excluído com sucesso!");
        }

        [HttpPut]
        public IActionResult Put([FromBody] User item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var user = _mapper.Map<User>(item);
            _repository.Update(user);

            return HttpMessageOk(_mapper.Map<User>(item));
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