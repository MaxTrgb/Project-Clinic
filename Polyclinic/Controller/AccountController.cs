using Polyclinic.Entity;
using Polyclinic.Service;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Polyclinic.Controller
{
    public class AccountController
    {
        private AccountService accountService = new AccountService();

        public Response<List<Account>> getAllAccounts()
        {
            Response<List<Account>> responseAccounts = new Response<List<Account>>();
            try
            {
                responseAccounts.Obj = accountService.getAllAccounts();
            }
            catch (Exception ex)
            {
                responseAccounts.errorMessage = ex.Message;
            }
            return responseAccounts;
        }
        public Response<Account> logIn(string email, string password)
        {
            Response<Account> reponseAccount = new Response<Account>();
            try
            {
                reponseAccount.Obj = accountService.logIn(email, password);
            }
            catch (Exception ex)
            {
                reponseAccount.errorMessage = ex.Message;
            }
            return reponseAccount;
        }

        public Response<Account> getAccountById(int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.getAccountById(id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }
            return responseAccount;
        }

        public Response<Account> createNewAccount(string name, string email, string password)
        {
            Response<Account> response = new Response<Account>();

            try
            {
                response.Obj = accountService.createNewAccount(name, email, password);

            }
            catch (Exception ex)
            {
                response.errorMessage = ex.Message;
            }
            return response;
        }

        public Response<Account> changeName(string newName, int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.changeName(newName, id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }
            return responseAccount;
        }
        public Response<Account> changeEmail(string newEmail, int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.changeEmail(newEmail, id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }
            return responseAccount;
        }
        public Response<Account> changePass(string newPass, int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.changePass(newPass, id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }
            return responseAccount;
        }

        public Response<Account> deleteAccount(int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.deleteAccount(id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }

            return responseAccount;
        }
        public Response<Account> setAdmin(int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.setAdmin(id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }

            return responseAccount;
        }
        public Response<Account> removeAdmin(int id)
        {
            Response<Account> responseAccount = new Response<Account>();

            try
            {
                responseAccount.Obj = accountService.removeAdmin(id);
            }
            catch (Exception ex)
            {
                responseAccount.errorMessage = ex.Message;
            }
            return responseAccount;
        }       
    }
}