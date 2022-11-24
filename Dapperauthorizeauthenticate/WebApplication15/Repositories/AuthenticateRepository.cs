using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication15.Model;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using WebApplication15.Helper;
using System;

namespace WebApplication15.Repositories
{
    public class AuthenticateRepository
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public AuthenticateRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
        public bool Authenticate(EmailPass emailPass)
        {

            string sql = "select email,password from Authentication where email=@Email and password=@Password";
            using (var connection = new SqlConnection(_connectionString))
            {
                
                connection.Open();
                    var result1 = connection.Query<EmailPass>(sql,emailPass);
                    int count= result1.Count();
                if (count==0)
                {
                    return false; 
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
