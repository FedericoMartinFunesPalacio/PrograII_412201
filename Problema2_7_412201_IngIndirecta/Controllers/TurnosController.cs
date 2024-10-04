using Microsoft.AspNetCore.Mvc;
using Problema2_7_412201_IngIndirecta.Models;
using Problema2_7_412201_IngIndirecta.Models.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Problema2_7_412201_IngIndirecta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private IRepositoryTurnos _repository;

        public TurnosController(IRepositoryTurnos repository)
        {
            _repository = repository;
        }
        // GET: api/<TurnosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/<TurnosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetById(id));
        }

        // POST api/<TurnosController>
        [HttpPost]
        public IActionResult Post([FromBody] Turnos value)
        {
            if(value != null)
            {
                _repository.Save(value);
                return Ok("Guardado");
            }
            return BadRequest("Se Necesita un turno");
        }

        // PUT api/<TurnosController>/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody] Turnos value)
        {
            if (value != null)
            {
                _repository.Update(value);
                return Ok("Borrado");
            }
            return BadRequest("Se Necesita un turno");
        }

        // DELETE api/<TurnosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
                return Ok("Borrado");
            }
            return BadRequest("Se Necesita un turno");
        }
    }
}
