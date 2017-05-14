using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SBS.BLL.Tests.TestBase
{
    public sealed class ExpectedExceptionContainsMessage : ExpectedExceptionBaseAttribute
    {
        private Type expectedExceptionType;
        private string expectedExceptionMessage;

        public ExpectedExceptionContainsMessage(Type expectedExceptionType)
        {
            this.expectedExceptionType = expectedExceptionType;
            this.expectedExceptionMessage = string.Empty;
        }

        public ExpectedExceptionContainsMessage(Type expectedExceptionType, string expectedExceptionMessage)
        {
            this.expectedExceptionType = expectedExceptionType;
            this.expectedExceptionMessage = expectedExceptionMessage;
        }

        protected override void Verify(Exception exception)
        {
            Assert.IsNotNull(exception);

            Assert.IsInstanceOfType(exception, expectedExceptionType, "Wrong type of exception was thrown.");

            if (!expectedExceptionMessage.Length.Equals(0))
            {
                if (exception is ArgumentNullException)
                {
                    Assert.IsTrue(exception.Message.Contains($"Parameter name: {expectedExceptionMessage}"),
                        $"Exception message '{exception.Message}' does not contain expected value 'Parameter name: {expectedExceptionMessage}'");
                }
                else
                {
                    Assert.IsTrue(exception.Message.Contains(expectedExceptionMessage),
                        $"Exception message '{exception.Message}' does not contain expected value '{expectedExceptionMessage}'");
                }
            }
        }
    }
}
