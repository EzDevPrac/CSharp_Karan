using System;
using Xunit;
using NoThreadSafeSDP;

namespace NoThreadSafetySDP.Test
{
    public class CheckMessage
    {
        
        
        Singleton MessageFromKaran = Singleton.GetInstance;
        [Fact]
        public void CheckMessageFromKaran()
        {
            
          String message =  MessageFromKaran.PrintMessage("Karan says Hii");
          
           Assert.Equal("Karan says Hii",message);
        }

         [Fact]
        public void CheckMessageFromSerena()
        {
            
          String message =  MessageFromKaran.PrintMessage("Serena says Bye!!");
          
           Assert.Equal("Serena says Bye!!",message);
        }   
    }
}
