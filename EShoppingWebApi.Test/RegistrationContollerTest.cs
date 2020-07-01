using System.Collections.Generic;
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

       
    public class RegistrationContollerTest
    {
       private readonly  Mock<ICustomerService> _mockCustomer;
        private readonly RegistrationController _controller;
 
    public RegistrationContollerTest()
    {
        _mockCustomer = new Mock<ICustomerService>();
        _controller = new RegistrationController(_mockCustomer.Object);
    }

    [Fact]
   public void Register_ActionExecutes_ReturnsOkResultForPost()
   {
    var result = _controller.Post(new Customer());
 
    Assert.IsType<OkResult>(result);
   }
    }
}