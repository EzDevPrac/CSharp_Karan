using System;

namespace SystemConfigFacade
{
    public class SystemRam
    {
        //Specify the Ram Size

        public int RamSize{get;set;}

      public String displayRamSize(){


          return "Ram     ----> " + RamSize + " GB" ;
      }
        
    }
}


