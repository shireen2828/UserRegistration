using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        Validators validate = new Validators();

        [TestMethod]
        public void Test_FirstName()
        {
            bool expectedResult = true;
            bool result = validate.ValidateFirstName("Shireen");
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void Test_LastName()
        {
            bool expectedResult = true;
            bool result = validate.ValidateLastName("Mariyam");
            Assert.AreEqual(expectedResult, result);
        }
    }
}
