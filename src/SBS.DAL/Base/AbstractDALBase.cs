using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.DAL.Base
{
    public abstract class AbstractDALBase
    {
        internal SbsContext dbc;

        public AbstractDALBase(SbsContext dbc)
        {
            this.dbc = dbc;
        }
    }
}
