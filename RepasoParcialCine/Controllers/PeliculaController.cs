using Microsoft.AspNetCore.Mvc;
using RepasoParcialCine.Models;
using RepasoParcialCine.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepasoParcialCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private IRepository _repository;

        public PeliculaController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<PeliculaController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lts = _repository.GetAllValidados();
                return Ok(lts);
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR 1");
            }
        }

        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var lts = _repository.Get(id);
                return Ok(lts);
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR 1");
            }
        }

        // POST api/<PeliculaController>
        [HttpPost]
        public IActionResult Post([FromBody] Peliculas value)
        {
            try
            {
                if(value != null)
                {
                    if (_repository.Save(value))
                    {
                        return Ok("GUARDADO");
                    }
                    else 
                    {
                        return BadRequest("ERROR 1"); 
                    }   
                }
                return BadRequest("ERROR 2");
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR 3");
            }
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            try
            {
                if (id != 0)
                {
                    if (_repository.Update(id))
                    {
                        return Ok("ACTUALIZADO");
                    }
                    else
                    {
                        return BadRequest("ERROR 1");
                    }
                }
                return BadRequest("ERROR 2");
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR 3");
            }
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (_repository.Delete(id))
                {
                    return Ok("BORRADO");
                }
                return BadRequest("ERROR 1");
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR 2");
            }
        }
    }
}
