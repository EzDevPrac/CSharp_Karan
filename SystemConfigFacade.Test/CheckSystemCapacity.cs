using System;
using SystemConfigFacade;
using Xunit;

namespace SystemConfigFacade.Test
{
    public class CheckSystemCapacity
    {
        SystemCapacity systemHddSize =new SystemCapacity();
        [Theory]
        [InlineData(1,"Hard Disk Size  ---->  1 TB")]
        [InlineData(2,"Hard Disk Size  ---->  2 TB")]
        [InlineData(3,"Hard Disk Size  ---->  3 TB")]
        [InlineData(4,"Hard Disk Size  ---->  4 TB")]
        public void CheckTheSystemRam(int HardDiskValue, String Solution)
        {
              systemHddSize.SytemHardDiskSize=HardDiskValue;
              Assert.Equal(Solution,systemHddSize.displayCapacity());

        }

        



    }
}
