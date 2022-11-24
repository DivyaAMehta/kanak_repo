using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication15.Model;
using WebApplication15.Repositories;

namespace WebApplication15.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class DapperController : Controller
    {
        private readonly ProductRepository _productRepository;

        public DapperController(IConfiguration configuration)
        {
            _productRepository = new ProductRepository(configuration);
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productRepository.Get());
        }


        
        [HttpGet]
        [Route("FixedPrices")]
        [AllowAnonymous]
        public IActionResult Gettwo()
        {
            return Ok(_productRepository.GetTwo());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            //var product = new Product() { Name = "abc", Quantity = 1 };
            return Ok(_productRepository.Create(product));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            //var inventory = new Product() { Name = "abc",  Quantity = 1 };
            return Ok(_productRepository.Update(product));
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            return Ok(_productRepository.Delete(product));
        }
    }
}
