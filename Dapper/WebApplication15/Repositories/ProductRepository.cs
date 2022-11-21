using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication15.Model;
using Dapper;
using System.Linq;

namespace WebApplication15.Repositories
{
    public class ProductRepository
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public ProductRepository(IConfiguration configuration)
        {
            //Configuration = configuration;
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public IEnumerable<Product> Get()
        {
            string sql = "select * from Products";
            using (var connetion = new SqlConnection(_connectionString))
            {
                connetion.Open();
                var result = connetion.Query<Product>(sql);
                return result.ToList();
            }
        }

        public IEnumerable<Product> GetTwo()
        {
            string sql = "select DAPPERDB.dbo.Products.ProductID,DAPPERDB.dbo.Products.Name from DAPPERDB.dbo.Products INNER join DAPPERDB.dbo.ProductPrice on DAPPERDB.dbo.ProductPrice.Name=DAPPERDB.dbo.Products.Name";
            using (var connetion = new SqlConnection(_connectionString))
            {
                connetion.Open();
                var result = connetion.Query<Product>(sql);
                return result.ToList();
            }
        }

        public int Create(Product product)
        {
            var sql = "Insert into Products (Name,Quantity) VALUES (@Name,@Quantity)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql, product);
                return result;
            }
        }

        public int Update(Product product)
        {
            var sql = "UPDATE Products SET Name = @Name, Quantity = @Quantity WHERE ProductId = @id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql, product);
                return result;
            }
        }

        public int Delete(int id)
        {
            var sql = "DELETE FROM Products WHERE ProductId = @id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql, new { id = id });
                return result;
            }
        }
    }
}
