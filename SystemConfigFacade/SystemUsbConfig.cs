using System;

namespace SystemConfigFacade
{
    public class SystemUsbConfig
    {
        public string UsbType{get;set;}


        public String displayUsbCofig(){


          return "USB COnfiguration ----> " + UsbType ;
      }
    
    }

      
}
