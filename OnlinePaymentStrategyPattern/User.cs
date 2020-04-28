using System;

namespace OnlinePaymentStrategyPattern
{
public class User
{
    public static double totalAmmount = 0;
    public static String customerName;
    public static int Choice,TotalTicket;
    public static void GetDetails(){
    
    Console.WriteLine("Enter the name of the customer");
    customerName = Console.ReadLine();
    Console.WriteLine("Enter the Type of seats you want in Theatre");
    Console.WriteLine("1:First Class      Cost : 200\n2:Second Class     Cost : 140\n3:Third Class      Cost : 80");
    Choice = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the number of ticket you want to book?");
    TotalTicket = Convert.ToInt16(Console.ReadLine());
    if(Choice == 1){
        totalAmmount = 200 * TotalTicket;
    }
    else if( Choice == 2){
        totalAmmount = 150 * TotalTicket;
    } 
    else{
        totalAmmount = 80 * TotalTicket;
    }
}
 public static void Main(string[] args)
{   PaymentMethod paymentmethod = new PaymentMethod();
    GetDetails(); 
    paymentmethod.SetCustomerName(customerName);
    paymentmethod.SetAmount(totalAmmount); 
    Console.WriteLine("Which mode of payment you want?\n");
    Console.WriteLine("-------Select Mode-------------");
    Console.WriteLine("1:PhonePe  -->(2% payment Charge)");
    Console.WriteLine("2:PayTm    -->(4% Payment Charge)");
    Console.WriteLine("3:GooglePay-->(5% Payment Charge)\n");
    
    int input = Convert.ToInt16(Console.ReadLine());
    switch(input)
    {
        case 1:
            paymentmethod.SetOnlinePayment(new PhonePe());            
            paymentmethod.Pay();
            break;

        case 2:
             
            paymentmethod.SetOnlinePayment(new GooglePay());            
            paymentmethod.Pay();

              break;
        case 3:
            paymentmethod.SetOnlinePayment(new PayTm());            
            paymentmethod.Pay();
            break;
        default:
            Console.WriteLine("Invalid Selection!");
            break;
    }
    Console.ReadKey();
}
}
}
