using System.Collections.Generic;
using System;
using Xunit;
using EShoppingWebApi.Service;
using Moq;
using EShoppingWebApi.Controllers;
using EShoppingWebApi.Service.CustomerServices;
using Microsoft.AspNetCore.Mvc;
using EShoppingWebApi.Models;
using EShoppingWebApi.Validation.CustomerDataValidation;


namespace EShoppingWebApi.Test
{
    public class AuthenticateControllerTest
    {
        private readonly Mock<ICustomerService> _mockCustomer;
        private  AuthenticateController _controller;
        private ICustomerInformationValidation customerDataValidation;
 
    public AuthenticateControllerTest()
    {
        _mockCustomer = new Mock<ICustomerService>();
        _controller = new AuthenticateController(_mockCustomer.Object);
       
    }

    [Theory]
    [InlineData("Karan","1234",200)]
    [InlineData("Raju","1432",200)]
    [InlineData("Shashank","12345",200)]
    [InlineData("Harshitha","12343",200)]
    [InlineData("Riya","12333",200)]
    public void When_AuthenticateCustomer_Method_Is_Passed_With_Valid_Name_And_Password_It_Returns_StatusCode_200(string username,string password,int result)
     {
        _mockCustomer.Setup(customer=> customer.Authenticate(username,password)).Returns(new Customer(){CustomerName = username ,CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802650",Password =password, CustomerAccountNumber="1234-1234-1234-1234"});
        // Act
        var createdResponse = _controller.AuthenticateCustomer(new CustomerAuthenticationData(){UserName = username,Password = password});
        var okResult = createdResponse as OkObjectResult;
        result = Convert.ToInt16(okResult.StatusCode);
        // Assert
      
        Assert.Equal(200, result);  
      }
    [Fact]
    public void When_AuthenticateCustomer_Method_Is_Passed_With_InValid_Name_And_Password_Returns_UserName_Or_Password_Is_Incorrect()
     {
        //Act
        _mockCustomer.Setup(s=> s.Authenticate("Karan","8867802650")).Returns(new Customer(){CustomerName = "Karan",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802650"});
        var createdResponse = _controller.AuthenticateCustomer(new CustomerAuthenticationData(){UserName = "Karan",Password = "8867802899"});
        var BadResult = createdResponse as BadRequestObjectResult;
        var result = Convert.ToString(BadResult.Value);
        // Assert
    
        Assert.Equal("{ message =  Username or password is incorrect  }",result);  
      }
    [Fact]  
    public void When_AuthenticateCustomer_Method_Is_Passed_With_Name_Being_Empty_And_A_Valid_Password_Returns_Null()
     {
        //Act
        _mockCustomer.Setup(s=> s.Authenticate(" ","8867802650")).Returns<Customer>(null);
        var createdResponse = _controller.AuthenticateCustomer(new CustomerAuthenticationData());
        var okResult = createdResponse as OkObjectResult;
        // Assert
    
        Assert.Null(okResult);  
      }
    [Fact]  
    public void When_AuthenticateCustomer_Method_Is_Passed_With_A_Valid_UserName_And_A_Empty_Password_Returns_Username_Or_Password_Is_Incorrect()
     {
        //Act
        var createdResponse = _controller.AuthenticateCustomer(new CustomerAuthenticationData(){UserName = "Karan",Password = " "});
        var BadResult = createdResponse as BadRequestObjectResult;
        var Result = Convert.ToString(BadResult.Value);
        // Assert
        Assert.Equal("{ message =  Username or password is incorrect  }",Result);  
      }
    
        
    }
}