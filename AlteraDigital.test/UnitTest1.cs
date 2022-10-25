using AlteraDigitalBarberShop.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlteraDigital.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetItemTest()
        {
            var controller = new FacialController();

            var GetItem_result = controller.Facial();
            //Assert    
            Assert.IsNotNull(GetItem_result);
        }
        [TestMethod]
        public void GetTest()
        {
            var controller = new StyleController();

            var Get_result = controller.Styles();
            //Assert    
            Assert.IsNotNull(Get_result);
        }
    }
}

