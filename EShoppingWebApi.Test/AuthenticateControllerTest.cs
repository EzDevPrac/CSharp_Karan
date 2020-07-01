using System;
using Xunit;
using EShoppingWebApi.Service;
using Moq;
using EShoppingWebApi.Controllers;
using EShoppingWebApi.Service.CustomerServices;
using Microsoft.AspNetCore.Mvc;
using EShoppingWebApi.Models;


namespace EShoppingWebApi.Test
{
    public class AuthenticateControllerTest
    {

        private readonly Mock<ICustomerService> _mockCustomer;
        private readonly AuthenticateController _controller;
 
    public AuthenticateControllerTest()
    {
        _mockCustomer = new Mock<ICustomerService>();
       
        _controller = new AuthenticateController(_mockCustomer.Object);
    }


    [Fact]
     public void Passing_InvalidNameAndPassword_ReturnsBadRequest()
     {
        // Arrange
        string Name = "Karan";
        string password = "1234";
        // Act
        var createdResponse = _controller.Post(Name,password);
        // Assert
        Assert.IsType<BadRequestObjectResult>(createdResponse);   
      }

        [Theory]
        [InlineData("Karan","12345")]
        public void CheckAuthemticatedCustomer(string Username,string Password)
         {
             
          
             var createResopnse = _controller.Post(Username,Password);

             Assert.IsType<OkObjectResult>(createResopnse);


         }
    }
}