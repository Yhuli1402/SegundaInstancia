using Microsoft.AspNetCore.Mvc;
using ProyectoBackendYhuli.Context;
using ProyectoBackendYhuli;
using ProyectoBackendYhuli.Models;

namespace ProyectoBackendYhuli.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuadrillasController : ControllerBase
    {

        private readonly ILogger<CuadrillasController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public CuadrillasController(
            ILogger<CuadrillasController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Cuadrillas cuadrillas)
        {
            _aplicacionContexto.Cuadrillas.Add(cuadrillas);
            _aplicacionContexto.SaveChanges();
            return Ok(cuadrillas);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Cuadrillas.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Cuadrillas cuadrillas)
        {
            _aplicacionContexto.Cuadrillas.Update(cuadrillas);
            _aplicacionContexto.SaveChanges();
            return Ok(cuadrillas);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int cuadrillasId)
        {
            _aplicacionContexto.Cuadrillas.Remove(
                _aplicacionContexto.Cuadrillas.ToList()
                .Where(x => x.codigo_cuadrilla == cuadrillasId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(cuadrillasId);
        }
    }
}
