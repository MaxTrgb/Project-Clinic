using Polyclinic.Entity;
using Polyclinic.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Polyclinic.Service
{
    public class AccountService
    {
        string connectionString = System.Configuration.ConfigurationManager.
                                  ConnectionStrings["Polyclinic.Properties.Settings." +
                                  "my_databaseConnectionString"].ConnectionString;


        private AccountRepository accountRepository = new AccountRepository();

        public List<Account> getAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    accounts = accountRepository.getAllAccounts(connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }

                if (accounts != null)
                {
                    return accounts;
                }
                else
                {
                    throw new Exception("Password or login incorrect");
                }

            }
        }

        public Account logIn(string email, string password)
        {
            Account account = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    account = accountRepository.getByEmail(connection, email);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }

                if (account != null && account.Password == password)
                {
                    return account;
                }
                else
                {
                    throw new Exception("Password or login incorrect");
                }
            }
        }
        public Account getAccountById(int id)
        {
            Account account = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    account = accountRepository.getAccountById(connection, id);

                }
                catch (Exception)
                {
                    throw new Exception("Internal server error\n");
                }
            }
            if (account == null)
            {
                throw new Exception("Account " + id + " not found!");
            }
            return account;
        }

        public Account createNewAccount(string name, string email, string password)
        {
            Account account = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    account = accountRepository.getByEmail(connection, email);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new Exception("Internal server error");
                }
                if (account != null)
                {
                    throw new Exception("Account already exists!");
                }

                try
                {
                    return accountRepository.createNewAccount(connection, name, email, password);
                }
                catch
                {
                    Console.WriteLine("Internal server error");
                }

            }
            return null;
        }
        public Account changeName(string newName, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return accountRepository.changeName(connection, newName, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }
        public Account changeEmail(string newEmail, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return accountRepository.changeEmail(connection, newEmail, id);                   
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }
        public Account changePass(string newPass, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return accountRepository.changePass(connection, newPass, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }
        public Account deleteAccount(int id)
        {
            Account account = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    account = accountRepository.deleteAccount(connection, id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (account == null)
            {
                return account;
            }
            else
            {
                throw new Exception("Internal server error");
            }
        }
        public Account setAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return accountRepository.setAdmin(connection, id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }
        public Account removeAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return accountRepository.removeAdmin(connection, id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }
    }
}