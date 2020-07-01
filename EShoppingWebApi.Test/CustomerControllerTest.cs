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
    public class CustomerControllerTest
    {
        private readonly Mock<ICustomerService> _mockCustomer;
        private  CustomerController _controller;
 
    public CustomerControllerTest()
    {
        _mockCustomer = new Mock<ICustomerService>();
       
    }
    [Fact]
   public void Index_ActionExecutes_ReturnsOkObjectForGetMethod()
   {
    var result = _controller.Get();
    Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Get_WhenCalled_ReturnsAllItems()
    {
        
        _mockCustomer.Setup(service  => service.GetCustomer())
        .Returns(new List<Customer>() { new Customer(), new Customer() });
        _controller = new CustomerController(_mockCustomer.Object);
        var result = _controller.Get();
         
        Assert.IsType<OkResult>((result));
         //var Customers = Assert.IsType<List<Customer>>(typeof(result.Result));
         //Assert.Equal(2, Customers.Count);
    }


    }
}