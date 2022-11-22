using EntityFrameworkCore.Context;
using EntityFrameworkCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        private IApplicationDbContext _context;
        public PlayerController(IApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Players players)
        {
            _context.Players.Add(players);
            await _context.SaveChanges();
            return Ok(1);
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var players = await _context.Players.ToListAsync();
            if (players == null)
                return NotFound();
            return Ok(players);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var players = await _context.Players.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (players == null)
                return NotFound();
            return Ok(players);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var players = await _context.Players.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (players == null)
                return NotFound();
            _context.Players.Remove(players);
            await _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Players playersToUpdate)
        {
            var players = await _context.Players.Where(n => n.Id == id).FirstOrDefaultAsync();
            if (players == null)
                return NotFound();

            players.Name = playersToUpdate.Name;
            players.PlayerNo = playersToUpdate.PlayerNo;
            players.AddedOn = playersToUpdate.AddedOn;
            await _context.SaveChanges();
            return Ok();
        }
    }
}
