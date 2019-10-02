using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingOutfitLibrary.Models;

namespace WeddingOutfitLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public CustomerAccountProfileModel CreateAccount(CustomerAccountProfileModel model)
        {
            model.CustomerID = 1;

            return model;
        }
    }
}
