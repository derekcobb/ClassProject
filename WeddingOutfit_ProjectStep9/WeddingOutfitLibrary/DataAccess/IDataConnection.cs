using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingOutfitLibrary.Models;

namespace WeddingOutfitLibrary.DataAccess
{
    public interface IDataConnection
    {
        CustomerAccountProfileModel CreateAccount(CustomerAccountProfileModel model);
    }
}
