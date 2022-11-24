
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using WebApplication15.Helper;
using WebApplication15.Model;
using WebApplication15.Repositories;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace WebApplication15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenEntryController : ControllerBase
    {
        private readonly AuthenticateRepository _authenticateRepository;

        public TokenEntryController(IConfiguration configuration)
        {
            _authenticateRepository = new AuthenticateRepository(configuration);
        }

        [HttpPost]
        public IActionResult JwtToken( EmailPass emailPass)
        {
            if (_authenticateRepository.Authenticate(emailPass))
                return Ok(JwtTokenGeneration.GenrateJwtTocken());
            else
               return   Ok(null) ;
                

        }

    }
}
