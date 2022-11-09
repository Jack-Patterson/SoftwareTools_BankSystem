using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleBankApp
{
    internal class DBConnector
    {

        public static List<Account> GetAllUsers()
        {
            var client = new RestClient("https://swtapi.azurewebsites.net/banksys/account/GetAllUsers");
            var request = new RestRequest();

            var response = client.Get(request);

            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(response.Content);

            return accounts;

        }

        public static Account GetUserById(int accountId)
        {
            var client = new RestClient("https://swtapi.azurewebsites.net/banksys/account/GetUserById/" + accountId);
            var request = new RestRequest();

            var response = client.Get(request);

            Account requestAccount;

            try
            {
                requestAccount = JsonConvert.DeserializeObject<Account>(response.Content);

                return requestAccount;
            }
            catch(Exception ex)
            {
                requestAccount = null;
            }
            return requestAccount;
        }

        public static List<Transaction> GetTransactionsForID(int accountId)
        {
            var client = new RestClient("https://swtapi.azurewebsites.net/banksys/transaction/GetAllTransactionsForID/" + accountId);

            var request = new RestRequest();

            var response = client.Get(request);

            List<Transaction> requestTransactions;

            try
            {
                requestTransactions = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

                return requestTransactions;
            }
            catch(Exception ex)
            {
                requestTransactions = null;
            }

            return requestTransactions;
        }

    }
}
