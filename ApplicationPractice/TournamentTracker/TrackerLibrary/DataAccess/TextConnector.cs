using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public Prize2Model CreatePrize(Prize2Model model)
        {
            model.Id = 1;

            return model;
        }
    }
}
