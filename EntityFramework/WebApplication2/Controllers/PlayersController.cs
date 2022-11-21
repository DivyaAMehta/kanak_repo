using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication2.Repositories;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly PlayersRepository _playersRepository;

        public PlayersController(IConfiguration configuration)
        {
            _playersRepository = new PlayersRepository(configuration);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playersRepository.Get());
        }

        [HttpPost]
        public IActionResult Post(Players players)
        {
            return Ok(_playersRepository.Create(players));
        }

        [HttpPost]
        [Route("Players")]
        public IActionResult PostUsingSP(Players players)
        {
            return Ok(_playersRepository.CreateUsingStoredProcedure(players));
        }

        [HttpPut]
        public IActionResult Put( Players players, int id)
        {
            //var inventory = new Inventory() { Name = "Flower", Price = 34.45M, Quantity = 1 };
            return Ok(_playersRepository.Update(players, id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_playersRepository.Delete(id));
        }
    }
}
