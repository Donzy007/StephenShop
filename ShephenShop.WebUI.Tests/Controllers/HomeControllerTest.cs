using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShephenShop.Core.Contracts;
using ShephenShop.WebUI;
using ShephenShop.WebUI.Controllers;
using StephenShop.Core.Models;
using StephenShop.Core.ViewModels;

namespace ShephenShop.WebUI.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexPageDoesReturenProducts()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();

            productContext.Insert(new Product());

            HomeController controller = new HomeController(productContext, productCategoryContext);

            var result = controller.Index() as ViewResult;
            var viewResult = (ProductListViewModel)result.ViewData.Model;

            Assert.AreEqual(1, viewResult.Products.Count());
        }
     

       
    }
}
