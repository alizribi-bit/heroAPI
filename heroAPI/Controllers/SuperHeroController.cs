using heroAPI.Data;
using heroAPI.Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace heroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public SuperHeroController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHero()
        {
            var heros = _dataContext.SuperHeroes.ToList();

            return Ok(heros);
        }
    }
}
