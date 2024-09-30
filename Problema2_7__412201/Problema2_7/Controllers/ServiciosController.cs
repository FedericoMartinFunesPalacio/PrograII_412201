using Microsoft.AspNetCore.Mvc;
using Problema2_7.Models;
using Problema2_7.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Problema2_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private IRepository _repository;
        public ServiciosController(IRepository repository) 
        {
            _repository = repository;
        }

        // GET: api/<ServiciosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAllServicios());
        }

        // GET api/<ServiciosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetServicioByID(id));
        }

        // POST api/<ServiciosController>
        [HttpPost]
        public IActionResult Post([FromBody] Servicios servicios)
        {
            try
            {
                if (_repository.Save(servicios)) 
                {
                    return Ok("AGREGADO");
                }
                else
                {
                    return BadRequest("ERROR");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "ERROR");
            }
        }

        //// PUT api/<ServiciosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ServiciosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (_repository.Delete(id))
                {
                    return Ok("AGREGADO");
                }
                else 
                {
                    return BadRequest("ERROR");
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, "ERROR");
            }
        }
    }
}
