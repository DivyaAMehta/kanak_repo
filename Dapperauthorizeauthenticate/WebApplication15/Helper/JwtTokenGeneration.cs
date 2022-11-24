using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;


namespace WebApplication15.Helper
{
    public class JwtTokenGeneration
    {
        private const string SECRET_KEY = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWV9.TJVA95OrM7E2cBab30RMHrHDcEfxjoYZgeFONFh7HgQ";
        public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public static string GenrateJwtTocken()
        {

           
                var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256);

                var header = new JwtHeader(credentials);

                DateTime Expiry = DateTime.UtcNow.AddMinutes(5);
                int ts = (int)(Expiry - new DateTime(1970, 1, 1)).TotalSeconds;

                var payload = new JwtPayload
            {
              {"sub","testSubject" },
                {"Name","Kanak" },
                {"email","Kanak@gmail.com" },
                {"exp",ts },
                {"iss","https://localhost:44357" },
                {"aud","https://localhost:44357" }
            };

                var secTocken = new JwtSecurityToken(header, payload);
                var handler = new JwtSecurityTokenHandler();
                var tockenString = handler.WriteToken(secTocken);

                Console.WriteLine(tockenString);
                Console.WriteLine("Consume Tocken");

                return tockenString;


            
        }
    }
}
