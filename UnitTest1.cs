using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUsingMSTest;

namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void CheckFirstName()
            {
            //Arrange
            
            UserFirstName obj = new UserFirstName();

            //Act
           bool result = obj.ValidateFirstName("Bhumika");

            //Assert
            Assert.AreEqual(true, result);

                     
            }
        
    }
}
