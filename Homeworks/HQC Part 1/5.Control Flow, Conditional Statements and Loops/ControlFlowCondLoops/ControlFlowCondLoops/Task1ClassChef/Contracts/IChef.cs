﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCondLoops.Contracts
{
    public interface IChef
    {
        IMeal Cook(IOven oven);
    }
}
