using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using mlp.Controllers;
using mlp.Models;

namespace mlp.Tests
{
    public class ProductControllerTests
    {
        ProductController controller;
        public ProductControllerTests()
        {
            controller = new ProductController();
        }

        [Fact]
        public void Index_Returns_View()
        {
            //act
            var result = controller.Index();

            //assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_ProductModels_To_View()
        {
            //act
            var result = controller.Index();

            //assert
            Assert.IsAssignableFrom<IEnumerable<Product>>(result.Model);
        }

        [Fact]

        public void Detail_Returns_View()
        {
            //act
            var result = controller.Detail(1);

            //assert
            Assert.IsType<ViewResult>(result);

        }

    }
}
