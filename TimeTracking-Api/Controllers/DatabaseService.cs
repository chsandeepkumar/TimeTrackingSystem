﻿
using System.Data.SqlClient;

namespace TimeTracking_Api.Controllers
{
    public class DatabaseService
    {
        private object user;
        public const string DatabaseConnectionString = @"Server=DESKTOP-IICMCKQ\LOCALSQL;Database=TimeTracking;User Id=sa;Password=abc@123;";
        public int SaveUser(User user)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;

                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = $"Insert into Users(id,created_date_time,email,first_name,last_name,role_id,updated_date_time,name) values " +
                    $"('{user.Id}','{user.CreatedDateTime}','{user.Email}','{user.FirstName}','{user.LastName}','{user.Roleid}','{user.UpdatedDateTime}','{user.Name}') ";
                var result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception exception)
            {

                return -1;
            }

        }

        public List<User> GetUser(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"select * from Users where id={id}";

                SqlDataReader result = sqlCommand.ExecuteReader();
                List<User> users = new List<User>();
                while (result.Read())
                {
                    User user = new User();
                    user.Id = result.GetInt32(0);
                    user.CreatedDateTime = result.GetDateTime(1);
                    user.Email = result.GetString(2);
                    user.FirstName = result.GetString(3);
                    user.LastName = result.GetString(4);
                    user.Roleid = result.GetString(5);
                    user.UpdatedDateTime = result.GetDateTime(6);
                    user.Name = result.GetString(7);

                    users.Add(user);
                }
                result.Close();

                return users;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateUser(User user)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandText = $"update users set created_date_time='{user.CreatedDateTime}'," +
                    $"email='{user.Email}'," +
                    $"first_name='{user.FirstName}'," +
                    $"last_name='{user.LastName}'," +
                    $"role_id='{user.Roleid}'," +
                    $"updated_date_time='{user.UpdatedDateTime}'," +
                    $"name='{user.Name}'" +
                    $" where id={user.Id}";
             
                var upddatedRecordCount = sqlCommand.ExecuteNonQuery();
               return upddatedRecordCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteUser(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"Delete from users where id='{id}'";

                var var = sqlCommand.ExecuteNonQuery();
                return var;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
