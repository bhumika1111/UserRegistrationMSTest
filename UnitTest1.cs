using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserMobileFormate;

namespace UserMobileFormateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        
            public void CheckMobileNumber()
            {
                //Arrange

                UserMobile obj = new UserMobile();
                //Act
                bool result = obj.ValidateMobileNumber("91 9638524563");
                //Assert
                Assert.AreEqual(true, result);

            }
    }
}
