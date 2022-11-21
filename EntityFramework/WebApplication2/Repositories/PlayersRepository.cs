using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using Microsoft.Data.SqlClient;
using WebApplication2.Model;

namespace WebApplication2.Repositories
{
    public class PlayersRepository
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public PlayersRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }

        public IEnumerable<Players> Get()
        {
            var players = new List<Players>();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Players";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var player = new Players()
                {
                    Id = Convert.ToInt32(dataTable.Rows[i]["Id"]),
                    Name = dataTable.Rows[i]["Name"].ToString(),
                    PlayerNo = Convert.ToInt32(dataTable.Rows[i]["PlayerNo"]),
                    AddedOn = Convert.ToDateTime(dataTable.Rows[i]["AddedOn"])
                };
                players.Add(player);
            }

            return players;
        }

        public bool Create(Players players)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Insert into Players (Name, PlayerNo, AddedOn) Values ('{players.Name}', " +
                             $"'{players.PlayerNo}', '{players.AddedOn}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }

        public string CreateUsingStoredProcedure(Players players)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "CreatePlayers";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = players.Name,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@PlayerNo",
                        Value = players.PlayerNo,
                        SqlDbType = SqlDbType.Money
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@AddedOn",
                        Value = players.AddedOn,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);

                    ///////////////////////////////////////////////////////////
                    command.Parameters.Add(parameter);

                    connection.Open();
                    command.ExecuteNonQuery();
                    string result = command.Parameters["@Result"].Value.ToString();
                    connection.Close();
                    return result;
                }
            }
        }

        public bool Update(Players players, int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Update Players SET    Name='{players.Name}', PlayerNo='{players.PlayerNo}', AddedOn='{players.AddedOn}' Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Delete From Players Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }
    }
}
