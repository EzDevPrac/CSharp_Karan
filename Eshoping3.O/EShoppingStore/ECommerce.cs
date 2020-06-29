using System;
using System.Collections.Generic;

namespace EShoppingStore
{
    public class ECommerce
    {
       private Customer _Customer ;
       private MarketingPerson _MarketingPerson ;    
       private IAuthenticationHandler _AuthenticationHandler ;
       private ICartHandler _CartHandler;
       private ICourierServiceHandler _CourierServiceHandler ;
       private ICustomerHandler _CustomerHandler;
       private IMarketingPersonHandler _MarketingPersonHandler; 
       private IProductHandler _ProductHandler; 
       private ISalesPersonHandler _SalesPersonHandler ;
       
       public ECommerce(){
             _Customer = new Customer();
             _MarketingPerson = new MarketingPerson();
             _CartHandler = new CartHandler();
             _AuthenticationHandler = new AuthenticationHandler();
             _CourierServiceHandler = new CourierServiceHandler();
             _CustomerHandler = new CustomerHandler();
             _MarketingPersonHandler = new MarketingPersonHandler();
             _ProductHandler = new ProductHandler();
             _SalesPersonHandler = new SalesPersonHandler();

       }
       public void MainMenu(){
            _ProductHandler.ShowExisting();
            int Choice =0,CustomerChoice=0;
            while(Choice<=2){
            Console.WriteLine("Welcome to the Shop");
            Console.WriteLine("1:Staff");
            Console.WriteLine("2:Customer");
            Console.WriteLine("3:Exit");
            Choice = Convert.ToInt32(Console.ReadLine());
            
            switch(Choice){

            case 1: 
                    Console.WriteLine("Enter the Name"); 
                    string StaffName = Console.ReadLine();
                    int value = _AuthenticationHandler.EmployeeLogin(_MarketingPerson);
                    if(value == 1)
                    {  Console.WriteLine("1:Add Product");
                       Console.WriteLine("2:Logout");
                       int StaffChoice = Convert.ToInt32(Console.ReadLine());
                        
                       switch(StaffChoice){ 
                        case 1: _MarketingPersonHandler.AddItemToProductCatalog(_ProductHandler);
                                break;
                        case 2 :break;
                        default :Console.WriteLine("Give a valid option");
                                  break;
                        
                        }
                    }   
                     break;    
                            
            case 2 : {
                  
                         Console.WriteLine("---Welcome to E-Shopping---");
                         Console.WriteLine("1.Login");
                         Console.WriteLine("2.Create Account");
                         Console.WriteLine("3.Exit");
                         CustomerChoice = Convert.ToInt32(Console.ReadLine());
        
                          switch(CustomerChoice){
                          case 1: int loginValue = _AuthenticationHandler.CustomerLogin(_CustomerHandler);
                                  if(loginValue ==1){
                                  CustomerOptions();
                                  }
                                  else{
                                         Console.WriteLine("Account Does not exist , PLease Create a Accounr");
                                  }
                                  break;
                          case 2: _CustomerHandler.CreateAccount();
                                                                 
                                   break;
                          default: Console.WriteLine("Thank You");
                                   break;
                          }
                     }
                     break;
            default : break;            
              }
         }
        
        }
       private void CustomerOptions(){
                      
            int choice=0;
            
            while(choice<=5){
            
            Console.WriteLine("----------------------");
            Console.WriteLine("1.Shop");
            Console.WriteLine("2.View Cart");
            Console.WriteLine("3.Check Order status");
            Console.WriteLine("4.Change account Information");
            Console.WriteLine("5.Return Product");
            Console.WriteLine("6.Logout");
            Console.WriteLine("-----------------------");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
               
             case 1:
                    
                    _ProductHandler.DisplayProduct();
                    _CartHandler.AddToCart(_ProductHandler);
                     
                    break;
             case 2:
                    int cartVAlue = _CartHandler.ShowCart();
                    if(cartVAlue == 1){
                    _CustomerHandler.CustomerCheckout(_SalesPersonHandler,_CourierServiceHandler);
                    }  
                    break;
             case 3:int orderValue = _SalesPersonHandler.ShowOrderStatus();
                    if(orderValue == 1){
                    _CourierServiceHandler.Deliver(_Customer._Address);
                    }
                    break;
             case 4: 
                    _CustomerHandler.UpdateCustomerInformation(_Customer);  
                    break;
             case 5: 
                    _SalesPersonHandler.ReturnItem(_CourierServiceHandler);                   
                    break;      
             default:break;


            }
            }
         }   
   
   }
}