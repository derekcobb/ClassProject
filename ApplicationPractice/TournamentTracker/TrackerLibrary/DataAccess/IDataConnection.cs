﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess

{
    public interface IDataConnection
    {
        Prize2Model CreatePrize(Prize2Model model);

    }
}
