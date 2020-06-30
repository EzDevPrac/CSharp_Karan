using System.Collections.Generic;
using EShopping.Model;
namespace EShopping.Service
{
    public class CustomerDetails
    {
     public static List<Customer>  _Customer = new List<Customer>();
     public  void Customerloginvalues()

        {

        _Customer.Add(new Customer{ _Name="Karan",_PhoneNumber="1234555",_Address="Tamil Nadu",_Email="Karan@gmail.com",_CreditCard = new CreditCard(1234,"Karan")});

        }
    }
}