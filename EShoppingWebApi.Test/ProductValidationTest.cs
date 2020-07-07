using System.Collections.Generic;
using System;
using Xunit;
using EShoppingWebApi.Service;
using Moq;
using EShoppingWebApi.Controllers;
using EShoppingWebApi.Service.ProductHandler;
using Microsoft.AspNetCore.Mvc;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.ProductValidation;


namespace EShoppingWebApi.Test
{


    public class ProductValidationTest
    {
        private IProductValidation _productValidation;

        public ProductValidationTest()
        {
            _productValidation = new ProductValidation();
        }

        [Fact]
        public void When_Valid_Product_Id_Entered_Than_ValidateProductId_Method_returns_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductId(123);
          //Assert
          Assert.Equal(1,value);

        }
        [Fact]
        public void When_InValid_Product_Id_Entered_Than_ValidateProductId_Method_returns_Zero(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductId(133444);
          //Assert
          Assert.Equal(0,value);

        }
        [Fact]
        public void When_Product_Id_Is_Entered_As_Zero_Than_ValidateProductId_Method_returns_Minus_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductId(0);
          //Assert
          Assert.Equal(-1,value);

        }
        [Fact]
        public void When_Product_Name_Is_Valid_Than_ValidateProductName_Method_returns_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductName("Watch");
          //Assert
          Assert.Equal(1,value);

        }
        [Fact]
        public void When_Product_Name_InValid_Than_ValidateProductName_Method_returns_Zero(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductName("@@@Watch");
          //Assert
          Assert.Equal(0,value);

        }
        [Fact]
        public void When_Product_Name_Is_Empty_Than_ValidateProductName_Method_returns_Minus_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductName(" ");
          //Assert
          Assert.Equal(-1,value);

        }
        [Fact]
        public void When_Product_Name_Is_Null_Than_ValidateProductName_Method_returns_Minus_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductName(null);
          //Assert
          Assert.Equal(-1,value);

        }
        [Fact]
        public void When_Product_Cost_Is_Valid_Than_ValidateCost_Method_returns_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductCost(50000);
          //Assert
          Assert.Equal(1,value);

        }
        [Fact]
        public void When_Product_Cost_Is_InValid_Than_ValidateCost_Method_returns_Zero(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductCost(50003939.2323);
          //Assert
          Assert.Equal(0,value);

        }
        [Fact]
        public void When_Product_Cost_Is_Zero_Than_ValidateCost_Method_returns_Minus_One(){
          //Arrange
          int value;
          //Act
          value =  _productValidation.ValidateProductCost(0);
          //Assert
          Assert.Equal(-1,value);

        }

    }
}