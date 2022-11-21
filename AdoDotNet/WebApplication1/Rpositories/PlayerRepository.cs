using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using WebApplication1.Model;
using System.Data.SqlClient;

namespace WebApplication1.Rpositories
{
    public class PlayerRepository
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public  PlayerRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
        public IEnumerable<Player> Get()
        {
            var player = new List<Player>();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Player";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var playerObj = new Player()
                {
                    Id = Convert.ToInt32(dataTable.Rows[i]["Id"]),
                    Name = dataTable.Rows[i]["Name"].ToString(),
                    PlayerNo = Convert.ToInt32(dataTable.Rows[i]["PlayerNo"]),
                    AddedOn = Convert.ToDateTime(dataTable.Rows[i]["AddedOn"]),
                };
                player.Add(playerObj);
            }
            return player;
        }

        public bool Create(Player player)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Insert into Player (Name, PlayerNo, AddedOn) Values ('{player.Name}', " +
                             $"'{player.PlayerNo}', '{player.AddedOn}')";
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

        public bool Update(Player Player, int Id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Update Player SET Name='{Player.Name}', PlayerNo='{Player.PlayerNo}', AddedOn='{Player.AddedOn}' Where Id='{Id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }

        public bool Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Delete From Player Where Id='{Id}'";
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
