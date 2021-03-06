using System;
using Xunit;
using mlp.Models;

namespace mlp.Tests
{
    public class ProductModelTests
    {
        Product model;

        public ProductModelTests()
        {
            model = new Product();
        }

        [Fact]
        public void Can_Assign_An_Id()
        {
            //Arrange

            //Act
            model.ProductId = 1;

            //Assert
            Assert.Equal(1, model.ProductId);
        }

        [Fact]
        public void Can_Assign_A_Name()
        {
            //Arrange

            //Act
            model.Name = "Rainbow Dash";

            //Assert
            Assert.Equal("Rainbow Dash", model.Name);
        }

        [Fact]
        public void Can_Assign_An_Image()
        {
            //Arrange

            //Act
            model.Image = "image";

            //Assert
            Assert.Equal("image", model.Image);
        }

        [Fact]
        public void Can_Assign_A_Category()
        {
            //Arrange

            //Act
            model.Category = "category info";

            //Assert
            Assert.Equal("category info", model.Category);
        }


        [Fact]
        public void Can_Assign_A_DateTimeGroup()
        {
            //Arrange

            //Act
            model.DateTimeGroup = DateTime.Today;

            //Assert
            Assert.Equal(DateTime.Today, model.DateTimeGroup);
        }

        [Fact]
        public void Can_Assign_A_Description()
        {
            //Arrange

            //Act
            model.Description = "Description info";

            //Assert
            Assert.Equal("Description info", model.Description);

        }
    }

}
