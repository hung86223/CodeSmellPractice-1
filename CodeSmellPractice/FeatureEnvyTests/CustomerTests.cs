using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeSmellPractice.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void GetMailAddress_should_return_correct_format_mail_address()
        {
            var address = new Address
            {
                City = "台北市",
                Street = "園區街",
                PostalCode = "11503",
                Number = 3
            };
            var customer = new Customer(address);

            Assert.AreEqual("11503台北市園區街3號", customer.GetMailAddress());
        }
    }
}