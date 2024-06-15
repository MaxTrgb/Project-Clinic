using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Polyclinic.Repository
{
    public class AccountRepository
    {
        public List<Account> getAllAccounts(SqlConnection connection)
        {
            string query = "SELECT * FROM Accounts";

            List<Account> accounts = new List<Account>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(new Account(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToString(reader["name"]),
                        Convert.ToString(reader["email"]),
                        Convert.ToString(reader["password"]),
                        Convert.ToInt32(reader["role_id"])
                        ));
                    }
                }
            }
            return accounts;
        }

        public Account getByEmail(SqlConnection connection, string email)
        {
            string query = $"SELECT * FROM Accounts " +
                           $"WHERE email = @email ";

            Account account = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        account = new Account(
                             Convert.ToInt32(reader["id"]),
                             Convert.ToString(reader["name"]),
                             Convert.ToString(reader["email"]),
                             Convert.ToString(reader["password"]),
                             Convert.ToInt32(reader["role_id"])
                             );
                    }
                }
            }
            return account;
        }
        public Account getAccountById(SqlConnection connection, int id)
        {
            string query = "SELECT * FROM Accounts WHERE id = @id";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Account(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["email"]),
                            Convert.ToString(reader["password"]),
                            Convert.ToInt32(reader["role_id"])
                        );
                    }
                    else
                    {
                        throw new Exception("Account not found");
                    }
                }
            }
        }
        public Account createNewAccount(SqlConnection connection, string name, string email, string password)
        {
            string query = $"INSERT INTO " +
                           $"Accounts(name, email, password, role_id)" +
                           $"VALUES (@name,@email,@password,1)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
            }
            return getByEmail(connection, email);
        }
        public int createNewAccountWithTransaction(SqlConnection connection, SqlTransaction transaction, string name, string email, string password)
        {
            string query = $"INSERT INTO " +
                           $"Accounts(name, email, password, role_id) output INSERTED.ID " +
                           $"VALUES (@name,@email,@password,1)";

            int id = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
                id = (int)cmd.ExecuteScalar();

            }
            return id;
        }
        public Account changeName(SqlConnection connection, string newName, int id)
        {
            string query = @"UPDATE Accounts 
                            SET name = @newName 
                            WHERE id = @currentId";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@newName", System.Data.SqlDbType.NVarChar).Value = newName;
                cmd.Parameters.Add("@currentId", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }

            return getAccountById(connection, id);
        }
        public Account changeEmail(SqlConnection connection, string newEmail, int id)
        {
            string query = $"UPDATE Accounts " +
                           $"SET email = @newEmail " +
                           $"WHERE id = @currentId";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@newEmail", System.Data.SqlDbType.NVarChar).Value = newEmail;
                cmd.Parameters.Add("@currentId", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }

            return getAccountById(connection, id);
        }
        public Account changePass(SqlConnection connection, string newPass, int id)
        {
            string query = $"UPDATE Accounts " +
                           $"SET password = @newPass " +
                           $"WHERE id = @currentId";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@newPass", System.Data.SqlDbType.NVarChar).Value = newPass;
                cmd.Parameters.Add("@currentId", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            return getAccountById(connection, id);
        }

        public Account deleteAccount(SqlConnection connection, int id)
        {
            string query = $"DELETE FROM Accounts " +
                           $"WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            return getAccountById(connection, id);
        }
        public Account setAdmin(SqlConnection connection, int id)
        {
            string query = $"UPDATE Accounts " +
                           $"SET role_id = 2 " +
                           $"WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            return getAccountById(connection, id);
        }
        public Account removeAdmin(SqlConnection connection, int id)
        {
            string query = $"UPDATE Accounts " +
                           $"SET role_id = 1 " +
                           $"WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            return getAccountById(connection, id);
        }
    }
}