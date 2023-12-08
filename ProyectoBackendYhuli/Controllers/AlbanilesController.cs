using Microsoft.AspNetCore.Mvc;
using ProyectoBackendYhuli.Context;
using ProyectoBackendYhuli;
using ProyectoBackendYhuli.Models;


namespace ProyectoBackendYhuli.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbanilesController : ControllerBase
    {

        private readonly ILogger<AlbanilesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AlbanilesController(
            ILogger<AlbanilesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Albaniles albaniles)
        {
            _aplicacionContexto.Albaniles.Add(albaniles);
            _aplicacionContexto.SaveChanges();
            return Ok(albaniles);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Albaniles.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Albaniles albaniles)
        {
            _aplicacionContexto.Albaniles.Update(albaniles);
            _aplicacionContexto.SaveChanges();
            return Ok(albaniles);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int albanilesId)
        {
            _aplicacionContexto.Albaniles.Remove(
                _aplicacionContexto.Albaniles.ToList()
                .Where(x => x.numero_seguridad_social == albanilesId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(albanilesId);
        }
    }
}
