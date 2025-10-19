using Microsoft.AspNetCore.Mvc;
using NatureApi2.Services;
using System.Linq;

namespace NatureApi2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrailsController : ControllerBase
    {
        private readonly PlaceService _service;

        public TrailsController()
        {
            _service = new PlaceService();
        }
        
        [HttpGet]
        public IActionResult GetAllTrails()
        {
            var trails = _service.GetAll()
                .SelectMany(p => p.Senderos.Select(t => new
                {
                    Lugar = p.Nombre,
                    t.Nombre,
                    t.DistanciaKm,
                    t.Dificultad,
                    t.TiempoEstimado,
                    t.EsLoop
                }));

            return Ok(trails);
        }
    }
}