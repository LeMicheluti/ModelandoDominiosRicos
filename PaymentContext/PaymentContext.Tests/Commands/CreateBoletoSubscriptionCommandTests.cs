using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErroWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand
            {
                FisrtName = ""
            };
            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}
