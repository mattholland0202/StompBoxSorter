using System;

namespace SBS.Data.Exceptions
{
    public class DeploymentOverlapException : Exception
    {
        public DeploymentOverlapException() : base()
        {
        }

        public DeploymentOverlapException(string message) : base(message)
        {
        }
    }
}
