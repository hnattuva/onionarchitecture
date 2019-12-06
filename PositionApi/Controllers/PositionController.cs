using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace PositionApi.Controllers
{
    [Route("api/[controller]")]
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            this._positionService = positionService;
        }
        
        // GET api/values
        [HttpGet]
        public Position Get()
        {
            return _positionService.GetPosition();
        }
    }
}
