using System;
using SystemConfigFacade;
using Xunit;

namespace SystemConfigFacade.Test
{
    public class CheckSystemGraphics
    {
        
        SystemGraphics systemGraphics =new SystemGraphics();
        [Theory]
        [InlineData("Pci Express","Graphics Type  ---->  Pci Express")]
        [InlineData("Agp 2.0","Graphics Type  ---->  Agp 2.0")]
        [InlineData("Agp 3.0","Graphics Type  ---->  Agp 3.0")]
        [InlineData("Pci","Graphics Type  ---->  Pci")]
        public void CheckTheSystemRam(string GraphicsType, String Solution)
        {
              systemGraphics.GraphicCardType=GraphicsType;
              Assert.Equal(Solution,systemGraphics.displayGraphics());

        }

        



    }
}
