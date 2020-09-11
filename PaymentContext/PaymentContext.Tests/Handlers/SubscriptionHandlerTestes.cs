using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTestes
    {
        [TestMethod]
        public void ShouldReturnErroWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FisrtName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@gmail.com";

            command.BarCode = "123456789";
            command.BoletoNumber = "1234456790";

            command.PaymentNumber = "1234";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE CORP";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";
            command.Street = "asd";
            command.Number = "123";
            command.Neighbothood = "asd";
            command.City = "asd";
            command.State = "asd";
            command.Country = "asd";
            command.ZipCode = "12344566";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
