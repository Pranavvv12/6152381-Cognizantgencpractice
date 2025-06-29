
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender;
        private CustomerComm _customerComm;

        [OneTimeSetUp]
        public void Init()
        {
          
            _mockMailSender = new Mock<IMailSender>();

           
            _mockMailSender
                .Setup(ms => ms.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerComm(_mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
         
            bool result = _customerComm.SendMailToCustomer();

            Assert.That(result, Is.True);

            _mockMailSender.Verify(ms => ms.SendMail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}
