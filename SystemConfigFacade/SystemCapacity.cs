using System;

namespace SystemConfigFacade
{
   public class SystemCapacity
    {
        public int SytemHardDiskSize{get;set;}

        public String displayCapacity(){


          return "Hard Disk Size  ---->  " + SytemHardDiskSize + " TB" ;
      }
    

        
    }
}
