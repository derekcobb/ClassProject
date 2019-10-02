using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingOutfitLibrary.Models;
//@FirstName text,
//@LastName text,
//	@ContactNumber text,
//    @Email text,
//	@Age int,
//	@Gender char (10),
//	@CustomerID int=0 output
namespace WeddingOutfitLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateCustomer AccountForm method actually save to the database

        /// <summary>
        /// Save a customer's information to the database
        /// </summary>
        /// <param name="model">The customer's information.</param>
        /// <returns>The customer's information, including the unique identifer.</returns>
        public CustomerAccountProfileModel CreateAccount(CustomerAccountProfileModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WeddingHelp")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@ContactNumber", model.ContactNumber);
                p.Add("@Email", model.Email);
                p.Add("@Age", model.Age);
                p.Add("@Gender", model.Gender);
                p.Add("CustomerID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCustomerAccountProfile_Insert", p, commandType: CommandType.StoredProcedure);

                model.CustomerID = p.Get<int>("@CustomerID");
                return model;
            }


            //Sample code below
            //model.CustomerID = 1;

            //return model;
        }

        
    }
}
