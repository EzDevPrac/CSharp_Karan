using System;
using SystemConfigFacade;
using Xunit;

namespace SystemConfigFacade.Test
{
    public class CheckSystemRam
    {
        
        SystemRam SysRam = new SystemRam();
        [Theory]
        [InlineData(2,"Ram     ----> 2 GB")]
        [InlineData(4,"Ram     ----> 4 GB")]
        [InlineData(8,"Ram     ----> 8 GB")]
        [InlineData(16,"Ram     ----> 16 GB")]
        public void CheckTheSystemRam(int RamValue, String Solution)
        {
              SysRam.RamSize=RamValue;
              Assert.Equal(Solution,SysRam.displayRamSize());

        }

        



    }
}
