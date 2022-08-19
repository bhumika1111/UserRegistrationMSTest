using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserPassword;

namespace UserPasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
            public void CheckPassword()
            {
                //Arrange

                UserPasswordRule1 obj = new UserPasswordRule1();
                //Act
                bool result = obj.ValidatePassword("WWqUvvik");
                //Assert
                Assert.AreEqual(true, result);

            }
        }
}
