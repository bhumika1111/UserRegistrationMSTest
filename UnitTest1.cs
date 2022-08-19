using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidEmailNine;

namespace UserEmailTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      
            public void CheckValidEmail()
            {
                //Arrange

                UserEmail obj = new UserEmail();
                //Act
                bool result = obj.ValidateEmailAdd("abc@ghimb.avg");
                //Assert
                Assert.AreEqual(true, result);


            }
    }
}
