using System;

namespace SystemConfigFacade
{
    class SystemCreationFacade
    {
        SystemRam Ram;
        SystemProcessor Processor;
        SystemCapacity HardDiskSize;
        SystemGraphics graphicCardType;
        SystemUsbConfig UsbType;
         

        public void  SystemCreation(){

        Ram = new SystemRam();
        Processor =new SystemProcessor();
        HardDiskSize = new SystemCapacity();
        graphicCardType = new SystemGraphics();
        UsbType = new SystemUsbConfig();
        
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

       Console.WriteLine("System Configuration of System are");
       Console.WriteLine("Ram Size          :: " + Ram.RamSize + " GB");
       Console.WriteLine("Processor Type    :: " + Processor.Processor);
       Console.WriteLine("HardDisk Capacity :: " + HardDiskSize.SytemHardDiskSize + " TB");
       Console.WriteLine("Graphic Card Type :: " + graphicCardType.GraphicCardType);
       Console.WriteLine("USB Port Type     :: " + UsbType.UsbType);



        } 
        
    }
}


