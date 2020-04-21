using System;
using SystemConfigFacade;
using Xunit;

namespace SystemConfigFacade.Test
{
    public class CheckSystemUsb
    {
        

        SystemUsbConfig sytemUsbConfig = new SystemUsbConfig();
        [Theory]
        [InlineData("2.0","USB COnfiguration ----> 2.0")]
        [InlineData("3.0","USB COnfiguration ----> 3.0")]
        public void CheckTheSystemRam(string usbtype, String Solution)
        {
              sytemUsbConfig.UsbType=usbtype;
              Assert.Equal(Solution,sytemUsbConfig.displayUsbCofig());

        }

        



    }
}
