using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserPasswordRule2;

namespace UserPasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
            public void CheckFirstName()
            {
                //Arrange

                UserPassword obj = new UserPassword();
                //Act
                bool result = obj.ValidatePasswordTwo("BsyhKuHL");
                //Assert
                Assert.AreEqual(true, result);

            }
        }
}
