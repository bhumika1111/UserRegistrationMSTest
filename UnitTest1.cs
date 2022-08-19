using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserPasswordRule4;

namespace UserPasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
            public void CheckPassword()
            {
                //Arrange

                UserPassword obj = new UserPassword();
                //Act
                bool result = obj.ValidatePasswordFour("S1@HfTYUml");
                //Assert
                Assert.AreEqual(true, result);

            }
    }
}
