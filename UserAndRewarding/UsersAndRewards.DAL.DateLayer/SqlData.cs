using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using UsersAndRewards.Shared;
using System.Data.SqlClient;


namespace UsersAndRewards.DAL.DataLayer
{
    public class SqlDate : IDate
    {
        private SqlCommand DefautConnect(string procedureName, CommandType commandTypeStorePocedure)
        {
            var command = new SqlCommand();
            command.CommandText = procedureName;
            command.CommandType = commandTypeStorePocedure;
            return command;
        }
        private static string connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
        /*
         В квадратных скобках указываем значение атрибута name элемента add.
         В результате в объекте conString мы получаем
         все значения элементов и атрибутов файла App.Config.
          */

        public void AddReward(Reward reward)
        {
            //передать в объект SqlConnection созданную строку подключения.
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefautConnect("AddReward", CommandType.StoredProcedure);
                command.Connection = connection;

                command.Parameters.AddWithValue("@Title", reward.Title);
                command.Parameters.AddWithValue("@DescriptRwrd", reward.Description);
                // command.Parameters.AddWithValue("@rewardIds", );

                connection.Open();
                var result = command.ExecuteScalar();
                var rewardId = result as int?;
                if (rewardId.HasValue)
                {
                    reward.RewardId = rewardId.Value;
                }

            };
        }
        public void AddUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataTable tvp = new DataTable();
                tvp.Columns.Add("Id", typeof(Int32));
                foreach (var reward in user.Rewards)
                {
                    tvp.Rows.Add(reward.RewardId);
                }
                var command = DefautConnect("AddUsers", CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.BirthDate);
                SqlParameter sqlParameter = command.Parameters.AddWithValue("@rewardIds", tvp);
                sqlParameter.SqlDbType = SqlDbType.Structured;
                command.Connection = connection;
                connection.Open();
                var result = command.ExecuteNonQuery();

            }
        }

        public void DeleteReward(int rewardId)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefautConnect("DeleteReward", CommandType.StoredProcedure);
                command.Connection = connection;

                command.Parameters.AddWithValue("@RewardId", rewardId);

                connection.Open();
                var result = command.ExecuteScalar();

            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                var result = command.ExecuteScalar();

            }
        }

        public Reward GetRewardById(int rewardId)
        {
            var reward = new Reward();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefautConnect("GetRewardById", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@RewardId", rewardId);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    reward.RewardId = reader.GetInt32(0);
                    reward.Title = reader.GetString(1);
                    reward.Description = reader.GetString(2);
                }
            }
            return reward; ;
        }

        public List<Reward> GetRewards()
        {
            var rewards = new List<Reward>();
            var connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                // command.CommandText = "SELECT UserId, FirstName, LastName, Birthdate FROM [User]";
                command.CommandText = "GetRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rewardId = reader.GetInt32(0);
                        var title = (string)reader["Title"];
                        var description = reader.GetString(2);
                        Reward reward = new Reward();
                        reward.RewardId = rewardId;
                        reward.Title = title;
                        reward.Description = description;

                        rewards.Add(reward);
                    }
                }
            }

            return rewards;
        }

        public User GetUserById(int userId)
        {
            var user = new User();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefautConnect("GetUserById", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", userId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                        var firstName = (string)reader["FirstName"];
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.BirthDate = birthdate;
                        user.Rewards = new List<Reward>();
                    }
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            var reward = new Reward();
                            reward.RewardId = reader.GetInt32(1);
                            reward.Title = reader.GetString(2);
                            reward.Description = reader.GetString(3);
                            user.Rewards.Add(reward);
                        }
                    }
                }
                return user;
            }
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            var connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    // command.CommandText = "SELECT UserId, FirstName, LastName, Birthdate FROM [User]";
                    command.CommandText = "GetAllUsers";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User();
                            var userId = reader.GetInt32(0);
                            var firstName = (string)reader["FirstName"];
                            var lastName = reader.GetString(2);
                            var birthdate = reader.GetDateTime(3);
                            user.UserId = userId;
                            user.FirstName = firstName;
                            user.LastName = lastName;
                            user.BirthDate = birthdate;
                            users.Add(user);
                        }
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                var reward = new Reward();
                                var userId = reader.GetInt32(0);
                                var user = users.First(u => u.UserId == userId);
                                reward.RewardId = reader.GetInt32(1);
                                reward.Title = reader.GetString(2);
                                reward.Description = reader.GetString(3);
                                if (user.Rewards == null) user.Rewards = new List<Reward>();
                                user.Rewards.Add(reward);

                            }
                        }

                    }

                }

            }
            return users;
        }

        public void UpdateReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = DefautConnect(@"UpdateReward", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@RewardId", reward.RewardId);
                command.Parameters.AddWithValue("@Title", reward.Title);
                command.Parameters.AddWithValue("@DescriptRwrd", reward.Description);
                connection.Open();
                command.ExecuteScalar();
            }
        }

        public void UpdateUser(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(Int32));
                foreach (var reward in user.Rewards)
                {
                    dataTable.Rows.Add(reward.RewardId);
                }
                var command = DefautConnect("UpdateUser", CommandType.StoredProcedure);
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.BirthDate);
                SqlParameter sqlParameter = command.Parameters.AddWithValue("@rewardIds", dataTable);
                sqlParameter.SqlDbType = SqlDbType.Structured;
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }
    }
}
