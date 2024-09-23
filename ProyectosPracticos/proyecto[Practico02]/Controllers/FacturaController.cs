using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using proyectoPractico01.Dominio;
using proyectoPractico01.Servicio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace proyecto_Practico02_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaServicio instancia;

        public FacturaController()
        {
            instancia = new FacturasServicio();
        }
        // GET: api/<FacturaController>
        [HttpGet("/ObtenerTodos")]
        public IActionResult GetAll()
        {
            var lts = instancia.GetAll();
            return Ok(lts);
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public IActionResult ObtenerFactura(int id)
        {
            var lts= instancia.ConsultarFactura(id);

            if (lts == null || lts.Count == 0 )
            {
                return BadRequest("Lista vacia");
            }
            else
            {
                return Ok(lts);
            }
        }

        // POST api/<FacturaController>
        [HttpPost]
        public IActionResult Registrar_Editar([FromBody] Facturas value)
        {
            if(value == null)
            {
                return BadRequest();
            }
            else
            {
                instancia.Registrar_Editar(value);
                return Ok("Operacion realizada con exito");
            }
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) 
            {
                return BadRequest("Ingrese un numero valido");
            }
            else
            {
                instancia.Delete(id);
                return Ok("Operacion realizada con exito");
            }
            
        }
    }
}
