using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication15.Model;
using WebApplication15.Repositories;

namespace WebApplication15.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DapperController : Controller
    {
        private readonly ProductRepository _productRepository;  //we need control over repo methods

        public DapperController(IConfiguration configuration)
        {
            _productRepository = new ProductRepository(configuration);
        }

        public IActionResult Get()
        {
            return Ok(_productRepository.Get());
        }

        [Route("FixedPrices")]
        public IActionResult Gettwo()
        {
            return Ok(_productRepository.GetTwo());
        }


        public IActionResult Create( Product product)
        {
            //var product = new Product() { Name = "abc", Quantity = 1 };
            return Ok(_productRepository.Create(product));
        }


 
        public IActionResult Put( Product product)
        {
            //var inventory = new Product() { Name = "abc",  Quantity = 1 };
            return Ok(_productRepository.Update(product));
        }

        public IActionResult Delete( int id)
        {
            return Ok(_productRepository.Delete(id));
        }
    }
}
