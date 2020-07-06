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
    public class CustomerControllerTest
    {
        private readonly Mock<ICustomerService> _mockCustomer;
        private  CustomerController _controller;
        private ICustomerInformationValidation customerDataValidation;
 
    public CustomerControllerTest()
    {
        _mockCustomer = new Mock<ICustomerService>();
        _controller = new CustomerController(_mockCustomer.Object,new CustomerInformationValidation());
       
    }
    [Fact]
    public void When_Get_Method_Is_Empty_Than_It_Returns_Customer_List_Is_Empty()
    {
      _mockCustomer.Setup(customer => customer.GetCustomer()).Returns<Customer>(null);
      var result = _controller.Get();
      var BadResult = result as BadRequestObjectResult;
      var value = Convert.ToString(BadResult.Value);
      //Assert
      Assert.Equal("{ message =  Customer List is Empty  }",value);

    }
    [Fact]
    public void When_Get_Method_Is_Executed_Returns_OkObjectResult()
    {
    _mockCustomer.Setup(customer => customer.GetCustomer()).Returns(new List<Customer>());
     //act
    var result = _controller.Get();
    //asert
    Assert.IsType<OkObjectResult>(result);
    }
    [Fact]
    public void When_Get_Method_Is_Called_And_The_CustomerList_Is_Not_Empty_Than_It_Returns_StatusCode200(){
    _mockCustomer.Setup(customer => customer.GetCustomer()).Returns(new List<Customer>());
        //Act
          var result = _controller.Get();
          var okResult = result as OkObjectResult;
          var value = Convert.ToInt16(okResult.StatusCode);
          //Assert
          Assert.Equal(200,value);
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
    [Fact]
    public void When_AddCustomer_IsCalled_With_All_The_ValidData_It_Returns_Customer_Added_Successfully()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"});
      var SuccessResult = AddingRespose as OkObjectResult;
      var Result = Convert.ToString(SuccessResult.Value);
        // Assert
      Assert.Equal("{ message = Customer Added Sucessfully }",Result);

    }
    
    [Fact]
    public void When_AddCustomer_IsCalled_With_CustomerName_As_Null_Than_It_Returns_Customer_Name_Cannot_Be_Empty()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = null , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"});
      var BadResult = AddingRespose as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message =  Customer name cannot be Empty }",Result);        
    }
    [Fact]
    public void When_AddCustomer_IsCalled_With_CustomerEmailID_As_Null_Than_It_Returns_Customer_EmailID_Cannot_Be_Empty()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan", CustomerMobileNumber="8867802650",CustomerEmailId =" ",CustomerAddress="Tamil nadu",Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"});
      var BadResult = AddingRespose as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message =  Customer Email ID Cannot be Empty  }",Result);        
    }
    [Fact]
    public void When_AddCustomer_IsCalled_With_CustomerAddress_As_Null_Than_It_Returns_Customer_Address_Cannot_Be_Empty()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress=null,Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"});
      var BadResult = AddingRespose as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message =  Customer Address cannot be Empty  }",Result);        
    }
    [Fact]
    public void When_AddCustomer_IsCalled_With_CustomerPassword_As_Null_Than_It_Returns_Customer_Password_Cannot_Be_Empty()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil Nadu",Password=null, CustomerAccountNumber="1234-1234-1234-1234"});
      var BadResult = AddingRespose as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message =  Customer Password cannot be Empty  }",Result);        
    }
    [Fact]
    public void When_AddCustomer_IsCalled_With_Customer_AccountNumber_As_Null_Than_It_Returns_Customer_AccountNumber_Cannot_Be_Empty()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil Nadu",Password="XYZ", CustomerAccountNumber=null});
      var BadResult = AddingRespose as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message =  Customer Account Number(Eg: XXXX-XXXX-XXXX-XXXX) cannot be empty  }",Result);        
    }
    [Fact] 
    public void When_AddCustomer_IsCalled_With_Invalid_Input_For_Custmer_Name_Than_It_Returns_Entered_Customer_Name_Is_Not_Proper()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "123",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802650",Password="XYZ",CustomerAccountNumber="1234-1234-1234-1234"});
      var Result = AddingRespose as BadRequestObjectResult;
      var BadResult = Convert.ToString(Result.Value);
      //Assert
      Assert.Equal("{ message = Entered Customer name is not Proper  }",BadResult);

    }
    [Fact] 
    public void When_AddCustomer_IsCalled_With_Wrong_Input_For_Custmer_Email_Than_It_Returns_Entered_Customer_Mail_Id_Is_Not_Proper()
    {
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan",CustomerEmailId ="karangcom",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802650",Password="XYZ",CustomerAccountNumber="1234-1234-1234-1234"});
      var Result = AddingRespose as BadRequestObjectResult;
      var BadResult = Convert.ToString(Result.Value);
      //Assert
      Assert.Equal("{ message = Entered Customer Email id is not Proper  }",BadResult);

      
    }
    [Fact] 
    public void When_AddCustomer_IsCalled_With_Wrong_Input_For_Custmer_MobileNUmber_Than_It_Returns_Entered_Mobile_Number_Is_Not_Proper()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan",CustomerEmailId ="karan@gmail.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="88678026A1",Password="XYZ",CustomerAccountNumber="1234-1234-1234-1234"});
      var Result = AddingRespose as BadRequestObjectResult;
      var BadResult = Convert.ToString(Result.Value);
      //Assert
      Assert.Equal("{ message = Entered Customer Mobile Number is not Proper  }",BadResult);


    }
    [Fact] 
    public void When_AddCustomer_IsCalled_With_Wrong_Input_For_Custmer_AccountNUmber_Than_It_Returns_Entered_Account_Number_Is_Not_Proper()
    {
      //Act     
      var AddingRespose = _controller.AddCustomers(new Customer(){CustomerName = "Karan",CustomerEmailId ="karan@gmail.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802621",Password="XYZ",CustomerAccountNumber="1234-1234-1234-AB"});
      var Result = AddingRespose as BadRequestObjectResult;
      var BadResult = Convert.ToString(Result.Value);
      //Assert
      Assert.Equal("{ message = Entered Customer Account Number not Proper(Eg:XXXX-XXXX-XXXX-XXXX) }",BadResult);


    }
    [Fact]
    public void When_An_Existing_Customer_Is_Tried_To_Add_Again_AddCustomer_Method_Returns_Customer_Already_Exists(){
     //Act
      _mockCustomer.Setup(customer => customer.AddCustomer(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"}));     
      var AddingResponse =_controller.AddCustomers(new Customer(){CustomerName = "Karan" , CustomerMobileNumber="8867802650",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",Password="xyz", CustomerAccountNumber="1234-1234-1234-1234"});
       
      var BadResult = AddingResponse as BadRequestObjectResult;
      var Result = Convert.ToString(BadResult.Value);
        // Assert
      Assert.Equal("{ message = Customer Already exists }",Result);

    }   
    [Fact]
    public void When_Remove_Customer_Method_Is_Called_And_The_User_DoesNot_Exist_Than_It_Resturn_Customer_Does_Not_Exist(){
     var result =  _controller.RemoveCustomer(new CustomerAuthenticationData(){UserName = "Karan",Password = "123"});
     var bad = result as BadRequestObjectResult;
     var BadResult = Convert.ToString(bad.Value);
     Assert.Equal("{ message = Customer Does not Exist }",BadResult);
    }
    [Fact]
    public void When_Remove_Customer_Method_Is_Called_And_The_User_Exist_Than_It_Returns_StausCode_200(){
     
     //Act
     _mockCustomer.Setup(delete => delete.Delete(new CustomerAuthenticationData(){UserName ="Karan",Password = "XYZ"})).Returns(1);
    // var result =_controller.AddCustomers(new Customer(){CustomerName = "Karan",CustomerEmailId ="karan@gmail.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802621",Password="XYZ",CustomerAccountNumber="1234-1234-1234-1111"});
     var Okresult =  _controller.RemoveCustomer(new CustomerAuthenticationData(){UserName = "Karan",Password = "XYZ"});
     var okResult = Okresult as OkObjectResult;
     var code = Convert.ToInt16(okResult.StatusCode);
     //Assert
     Assert.Equal(200,code);
    }

     
    }
}