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
    public class ProductControllerTest
    {
        private readonly Mock<IProductHandler> _mockProduct;
        private  ProductController _ProductController;
        //private IProductValidation productValidation;

        public ProductControllerTest()
        {
            _mockProduct = new Mock<IProductHandler>();
            _ProductController = new ProductController(_mockProduct.Object);
           
        }

        [Fact]
        public void When_Get_Method_Is_Called_With_No_Product_In_The_List_Than_It_Returns_There_Are_No_Products_Display(){
         _mockProduct.Setup(product => product.GetProduct()).Returns<Product>(null);
          //Act
          var result = _ProductController.Get();
          var BadResult = result as BadRequestObjectResult;
          var value = Convert.ToString(BadResult.Value);
          //Assert
          Assert.Equal("{ message =  There are no product to display }",value);
        }
        [Fact]
        public void When_Get_Method_Is_Called_With_And_The_ProductList_Is_Not_Empty_Than_It_Returns_StatusCode200(){
        _mockProduct.Setup(product => product.GetProduct()).Returns(new List<Product>());
        //Act
          var result = _ProductController.Get();
          var okResult = result as OkObjectResult;
          var value = Convert.ToInt16(okResult.StatusCode);
          //Assert
          Assert.Equal(200,value);
        }
        [Fact]
        public void When_Get_Method_Is_Called_With_And_The_ProductList_Is_Not_Empty_Than_It_Returns_Ok_ObjectResult(){
        _mockProduct.Setup(product => product.GetProduct()).Returns(new List<Product>());
        //Act
          var result = _ProductController.Get();
          //Assert
          Assert.IsType<OkObjectResult>(result);
        } 
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_All_The_Valid_Data_Than_It_Returns_Product_Added_Sucessfully()
        {
        
           var okResult = _ProductController. AddToProductList(new Product(){ProductId = 123,ProductName = "Watch",ProductCost = 12000});
           var SuccessResult = okResult as OkObjectResult;
           var Result = Convert.ToString(SuccessResult.Value);
           //Assert
           Assert.Equal("{ message = Product Added Successfully }",Result);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_All_The_Valid_Data_Than_It_Returns_StatusCode_200()
        {
           var okResult = _ProductController. AddToProductList(new Product(){ProductId = 123,ProductName = "Watch",ProductCost = 12000});
           var SuccessResult = okResult as OkObjectResult;
           var Result = Convert.ToInt16(SuccessResult.StatusCode);
           //Assert
           Assert.Equal(200,Result);
        }
        [Theory]
        [InlineData(121,"Mi Note 7",14000,200)]    
        [InlineData(122,"fridge",24000,200)]
        [InlineData(123,"Washing Machine",44000,200)]
        public void When_Add_Products_Method_Is_Called_With_multiple_The_Valid_Data_Than_It_Returns_StatusCode_200(int productId,string productName,double cost,int result)
        {
           var okResult = _ProductController. AddToProductList(new Product(){ProductId = productId,ProductName = productName,ProductCost = cost});
           var SuccessResult = okResult as OkObjectResult;
           result = Convert.ToInt16(SuccessResult.StatusCode);
           //Assert
           Assert.Equal(200,result);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Null_Value_For_Product_Id_It_Returs_Id_Field_Cannot_be_Null()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 0,ProductName = "Watch",ProductCost = 12000});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ mesage = Id Field cannot be Null }",FinalResult);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Null_Value_For_Product_Name_It_Returs_Name_Field_Cannot_be_Null()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 123,ProductName = null,ProductCost = 12000});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ mesage = Name Field cannot be Null }",FinalResult);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Zero_Value_For_Product_Cost_It_Returs_Cost_Cannot_be_Zero()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 123,ProductName = "Watch",ProductCost = 0});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ message = Cost Cannot be 0 }",FinalResult);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Invalid_Value_For_Product_Id_It_Returns_Invalid_Product_Id()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 23433,ProductName = "Watch",ProductCost = 12000});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ message = Invalid Product Id }",FinalResult);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Invalid_Value_For_Product_Name_It_Returns_Invalid_Product_Name()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 234,ProductName = "@@Watch",ProductCost = 12000});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ message = Invalid Product Name }",FinalResult);
        }
        [Fact]
        public void When_Add_Products_Method_Is_Called_With_The_Invalid_Value_For_Product_Cost_It_Returns_Invalid_Input_For_Cost()
        {
           var Result = _ProductController. AddToProductList(new Product(){ProductId = 234,ProductName = "Watch",ProductCost = 120.7675654});
           var BadResult = Result as BadRequestObjectResult;
           var FinalResult = Convert.ToString(BadResult.Value);
           //Assert
           Assert.Equal("{ message = Invalid Input For Cost }",FinalResult);
        }
        [Fact]
        public void When_DeleteProductFromTheList_Method_Is_Called_And_Product_Exists_Than_It_Returns_Status_Code200(){
            
            _mockProduct.Setup(product => product.DeleteProduct(123)).Returns(1);
            //act
            var result =_ProductController.DeleteProductFromTheList(123);
            var Success = result as OkObjectResult;
            var code = Convert.ToInt16(Success.StatusCode);
            //Assert
            Assert.Equal(200,code);

        }
        [Fact]
        public void When_DeleteProductFromTheList_Method_Is_Called_And_Product_DoesNot_Exists_Than_It_Returns_Status_Code400(){
            
            _mockProduct.Setup(product => product.DeleteProduct(123)).Returns(0);
            //act
            var result =_ProductController.DeleteProductFromTheList(123);
            var Failure = result as BadRequestObjectResult;
            var code = Convert.ToInt16(Failure.StatusCode);
            //Assert
            Assert.Equal(400,code);

        } 
        [Fact]
        public void When_DeleteProductFromTheList_Method_Is_Called_And_Product_DoesNot_Exists_Than_It_Returns_Product_Does_Not_Exist(){
            
            _mockProduct.Setup(product => product.DeleteProduct(123)).Returns(0);
            //act
            var result =_ProductController.DeleteProductFromTheList(123);
            var Failure = result as BadRequestObjectResult;
            var value = Convert.ToString(Failure.Value);
            //Assert
            Assert.Equal("{ message = Product Does not Exist }",value);

        }
    
    
    
    
    }
}