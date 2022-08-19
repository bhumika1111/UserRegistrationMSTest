using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;

namespace UserRegistrationMSTestProb
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
            public void CheckLastName()
            {
                //Arrange

                UserLastName obj = new UserLastName();
                //Act
                bool result = obj.ValidateLastName("Jadhav");
                //Assert
                Assert.AreEqual(true, result);

            }
        }
}
