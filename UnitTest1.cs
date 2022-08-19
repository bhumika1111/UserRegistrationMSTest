using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidEmail;
namespace UserValidEmailTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
       
            public void CheckEmail()
            {
                //Arrange

                UserEmail obj = new UserEmail();
                //Act
                bool result = obj.ValidateEmail("bhumika123@gmail.com");
                //Assert
                Assert.AreEqual(true, result);

            }
    }
}

