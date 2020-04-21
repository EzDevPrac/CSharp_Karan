using System;

namespace SystemConfigFacade
{
   public class SystemCreationFacade
    {
        SystemRam Ram = new SystemRam();
        SystemProcessor Processor = new SystemProcessor();
        SystemCapacity HardDiskSize = new SystemCapacity();
        SystemGraphics graphicCardType = new SystemGraphics();
        SystemUsbConfig UsbType = new SystemUsbConfig();
         

        public void  SystemCreation(){
       
       Console.WriteLine("Enter the Sytem Ram Size");
       Ram.RamSize = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter the Sytem Processor Type");
       Processor.Processor = Console.ReadLine();
       Console.WriteLine("Enter the Sytem  Hard Disk Capacity");
       HardDiskSize.SytemHardDiskSize = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter the Sytem  GRaphic type");
       graphicCardType.GraphicCardType =Console.ReadLine();
       Console.WriteLine("Enter the Sytem USB Port type");
       UsbType.UsbType =Console.ReadLine();
       Console.ReadKey();
        }

       public void SystemDisplay(){
       Console.WriteLine("Configuration of System is");
       Console.WriteLine( Ram.displayRamSize());
       Console.WriteLine( Processor.displayProcessor());
       Console.WriteLine( HardDiskSize.displayCapacity());
       Console.WriteLine( graphicCardType.displayGraphics());
       Console.WriteLine( UsbType.displayUsbCofig());
       } 
        
    }
}


