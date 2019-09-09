using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingOutfitLibrary.Models;

namespace WeddingOutfitLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateCustomer AccountForm method actually save to the database

        /// <summary>
        /// Save a customer's information to the database
        /// </summary>
        public CustomerAccountProfileModel CreateAccount(CustomerAccountProfileModel model)
        {
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WeddingHelp")))
            //{
            //    var p = new DynamicParameters();
            //    p.
            //}
            model.CustomerID = 1;

            return model;
        }

        
    }
}
