using System;
using System.Collections;
using SBS.BLL.Interfaces.Base;
using SBS.DAL.Interfaces.Base;

namespace SBS.BLL.Base
{
    public abstract class AbstractBLLBase
    {
        internal IBLL BLL;
        internal IUnitOfWork UnitOfWork;

        public AbstractBLLBase(IBLL bll)
        {
            BLL = bll;
            UnitOfWork = bll.UnitOfWork;
        }

        protected void CheckParameterForNull(object parameter, string parameterName)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(parameterName);
            }
            else
            {
                if (parameter is string &&
                    string.IsNullOrWhiteSpace((string)parameter))
                {
                    throw new ArgumentNullException(parameterName);
                }
                else if (parameter is IList &&
                         ((IList)parameter).Count == 0)
                {
                    throw new ArgumentException($"At least one {parameter.GetType()} must be supplied", parameterName);
                }
            }
        }
    }
}
