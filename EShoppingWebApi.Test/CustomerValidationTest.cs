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
    public class ValidationTest
    {
        private ICustomerInformationValidation _customerValidation;
        private Mock<ICustomerService> _mockCustomer;
      public ValidationTest()
      {   _mockCustomer = new Mock<ICustomerService>();
          _customerValidation = new CustomerInformationValidation();
      }
      [Fact]
      public void When_Customer_Enters_A_Valid_Name_The_ValidateName_Method_Return_One(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateName("Karan Kumar");
        //Assert
        Assert.Equal(1,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_Name_Field_Empty_The_ValidateName_Method_Return_MinusOne(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateName(" ");
        //Assert
        Assert.Equal(-1,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_Name_Field_null_The_ValidateName_Method_Return_MinusOne(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateName(null);
        //Assert
        Assert.Equal(-1,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_Name_Field_With_Invalid_Name_The_ValidateName_Method_Return_Zero(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateName("Karan1233");
        //Assert
        Assert.Equal(0,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_CustomerMobileNumber_Field_With_Mobile_Number_The_ValidateMobileNumber_Method_Return_One(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateMobileNumber("8073950227");
        //Assert
        Assert.Equal(1,answer); 
      }
      
      [Fact]
      public void When_Customer_Enters_A_CustomerMobileNumber_Field_Empty_The_ValidateMobileNumber_Method_Return_MinusOne(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateMobileNumber(" ");
        //Assert
        Assert.Equal(-1,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_CustomerMobileNumber_Field_Null_The_ValidateMobileNumber_Method_Return_MinusOne(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateMobileNumber(null);
        //Assert
        Assert.Equal(-1,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_CustomerMobileNumber_Field_With_Invalid_Mobile_No_Formate_The_ValidateMobileNumber_Method_Return_Zero(){
        //Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateMobileNumber("123455555");
        //Assert
        Assert.Equal(0,answer); 
      }
      [Fact]
      public void When_Customer_Enters_A_Valid_AccountNumber_The_ValidateAccountNumber_Method_Returns_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateAccountNumber("1234-5555-5535-9876");
        //Assert
        Assert.Equal(1,answer);
           

      }
      [Fact]
      public void When_Customer_Enters_A_InValid_AccountNumber_The_ValidateAccountNumber_Method_Returns_Zero()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateAccountNumber("AAAA-5555-5535-9876");
        //Assert
        Assert.Equal(0,answer);
           

      }
      [Fact]
      public void When_Customer_Enters_A_AccountNumber_Field_Empty_The_ValidateAccountNumber_Method_Returns_MinusOne()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateAccountNumber(" ");
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_AccountNumber_Field_Null_The_ValidateAccountNumber_Method_Returns_MinusOne()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateAccountNumber(null);
        //Assert
        Assert.Equal(-1,answer);
           

      }
      [Fact]
      public void When_Customer_Enters_A_Valid_Email_Id_The_ValidateEmailId_Method_Returns_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateEmailId("karan@gmail.com");
        //Assert
        Assert.Equal(1,answer);
           

      }
      [Fact]
      public void When_Customer_Enters_A_InValid_Email_Id_The_ValidateEmailId_Method_Returns_Zero()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateEmailId("karan.com");
        //Assert
        Assert.Equal(0,answer);
           

      }
      [Fact]
      public void When_Customer_Enters_A_Empty_Email_Id_The_ValidateEmailId_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateEmailId(" ");
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Null_Email_Id_The_ValidateEmailId_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateEmailId(null);
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Valid_Password_ValidatePassword_Method_Returns_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidatePassword("karan123");
        //Assert
        Assert.Equal(1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Empty_Password_ValidatePassword_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidatePassword(" ");
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Null_Password_ValidatePassword_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidatePassword(null);
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Valid_CustomerAddress_ValidateCustomerAddress_Method_Returns_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateCustomerAddress("PG Residency Yelahanka");
        //Assert
        Assert.Equal(1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Empty_CustomerAddress_ValidateCustomerAddress_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateCustomerAddress(" ");
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_Customer_Enters_A_Null_CustomerAddress_ValidateCustomerAddress_Method_Returns_Minus_One()
      {//Arrange
        int answer; 
        //Act
        answer = _customerValidation.ValidateCustomerAddress(null);
        //Assert
        Assert.Equal(-1,answer);
      }
      [Fact]
      public void When_A_New_Customer_Is_Added_And_The_Customer_DoesNot_Exist_Than_CheckExistingCustomer_Method_Returns_One(){
          //Arrange
          _mockCustomer.Object.AddCustomer(new Customer());
          int result;
          //act
          result = _customerValidation.CheckExistingCustomer(new Customer(){CustomerName = "Karan",CustomerEmailId ="karan@g.com",CustomerAddress="Tamil nadu",CustomerMobileNumber="8867802650",Password="XYZ",CustomerAccountNumber="1234-1234-1234-1234"});
          
          //Assert
          Assert.Equal(1,result);     
      }
    
    
    
    }
}