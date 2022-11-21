using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Model;
using WebApplication1.Rpositories;

namespace WebApplication1.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class PlayerController : ControllerBase
        {
            private readonly PlayerRepository _playerRepository;
            public PlayerController(IConfiguration configuration)
            {
                _playerRepository = new PlayerRepository(configuration);
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_playerRepository.Get());
            }

            [HttpPost]
            public IActionResult Post(Player player)
            {
                return Ok(_playerRepository.Create(player));
            }

            [HttpPut]
            public IActionResult Put(Player player, int Id)
            {
                return Ok(_playerRepository.Update(player, Id));
            }

            [HttpDelete]
            public IActionResult Delete(int Id)
            {
                return Ok(_playerRepository.Delete(Id));
            }
        }
    
}
