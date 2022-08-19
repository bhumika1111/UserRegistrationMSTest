using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserPasswordRule3;

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
                bool result = obj.ValidatePasswordThree("D7GHikbhj");
                //Assert
                Assert.AreEqual(true, result);

            }
        }
}
