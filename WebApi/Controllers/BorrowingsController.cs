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
    public class BorrowingsController : ControllerBase
    {
        private readonly IBorrowingRepository _repository;
        private readonly IMapper _mapper;

        public BorrowingsController(IMapper mapper)
        {
            this._repository = new BorrowingRepository();
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var borrowings = _mapper.Map<IList<Borrowing>>(_repository.GetAll());
            return HttpMessageOk(borrowings);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var borrowing = _mapper.Map<Borrowing>(_repository.GetById(id));
            return HttpMessageOk(borrowing);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Borrowing item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var borrowing = _mapper.Map<Borrowing>(item);
            _repository.Save(borrowing);

            return HttpMessageOk(_mapper.Map<Borrowing>(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var borrowing =  _repository.GetById(id);

            if (borrowing == null) 
                return NotFound();
            else 
                _repository.Delete(id);
                return HttpMessageOk("Empréstimo excluído com sucesso!");
        }

        [HttpPut]
        public IActionResult Put([FromBody] Borrowing item)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var borrowing = _mapper.Map<Borrowing>(item);
            _repository.Update(borrowing);

            return HttpMessageOk(_mapper.Map<Borrowing>(item));
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