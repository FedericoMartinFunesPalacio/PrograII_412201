using Microsoft.AspNetCore.Mvc;
using Problema2_7_412201_IngIndirecta.Models;
using Problema2_7_412201_IngIndirecta.Models.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Problema2_7_412201_IngIndirecta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private IRepository _repository;

        public ServicioController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<ServicioController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _repository.GetAll();
            return Ok(list);
        }

        // GET api/<ServicioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _repository.GetById(id);
            return Ok(value);
        }

        // POST api/<ServicioController>
        [HttpPost]
        public IActionResult Post([FromBody] Servicios servicio)
        {
            if (servicio == null)
            {
                return BadRequest("ERROR");
            }
            else
            {
                if (servicio.IdServicio == 0)
                {
                    _repository.Create(servicio);
                }
                else 
                {
                    _repository.Update(servicio);
                }
                
                return Ok("Guardado");
            }
        }

        //// PUT api/<ServicioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ServicioController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok("Borrado");
        }
    }
}
