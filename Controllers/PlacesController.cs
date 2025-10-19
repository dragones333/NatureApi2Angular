using Microsoft.AspNetCore.Mvc;
using NatureApi2.Services;

namespace NatureApi2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlacesController : ControllerBase
    {
        private readonly PlaceService _service;

        public PlacesController()
        {
            _service = new PlaceService();
        }
        
        [HttpGet]
        public IActionResult GetPlaces()
        {
            var lugares = _service.GetAll();
            return Ok(lugares);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetPlaceById(int id)
        {
            var lugar = _service.GetById(id);
            if (lugar == null) return NotFound(new { message = "Lugar no encontrado" });
            return Ok(lugar);
        }
    }
}