using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proyectoPractico02.Data;
using proyectoPractico02.Models;

namespace proyectoPractico02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly ArticulosRepository_ADO _repository;

        public ArticulosController()
        {
            _repository = new ArticulosRepository_ADO();
        }

        [HttpGet ("/ObtenerTodos")]
        public IActionResult ObtenerTodos()
        {
            var lst = _repository.TraerTodos();
            if (lst == null || lst.Count == 0)
            {
                return BadRequest("No hay articulos en la lista");
            }
            return Ok(lst);
        }

        [HttpGet("/Obtener por ID")]

        public IActionResult ObtenerPorId(int id)
        {
            var lista = _repository.TraerPorID(id);
            if (lista == null || lista.Count == 0)
            {
                return BadRequest("No se pudo obtener el elemento por el id");
            }
            return Ok(lista);
        }

        [HttpPost("/Crear")]
        public IActionResult CrearArticulos([FromBody] Articulos articulo)
        {
            if (articulo == null)
            {
                return BadRequest();
            }
            else
            {
                _repository.Guardar(articulo);
            }

            return Ok($"Articulo añadido exitosamente!!! \n {articulo}");


        }

        [HttpPut("/Actualizar")]
        public IActionResult Actualizar([FromBody] Articulos articulo)
        {
            if (articulo == null)
            {
                return BadRequest();
            }
            else
            {
                _repository.Actualizar(articulo);
            }
            return Ok($"Actualizado el articulo!!! \n {articulo}");
        }

        [HttpDelete("/Borrar")]
        public IActionResult BorrarArticulos(int id)
        {
            if (id > 0)
            {
                _repository.Borrar(id);
            }

            return Ok("Articulo eliminado exitosamente!!!");
        }
    }
}
