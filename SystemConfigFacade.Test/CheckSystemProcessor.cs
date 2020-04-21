using System;
using SystemConfigFacade;
using Xunit;

namespace SystemConfigFacade.Test
{
    public class CheckSystemProcessor
    {
        
        SystemProcessor SystemProcessor = new SystemProcessor();
        [Theory]
        [InlineData("Intel i3","Processor     ----> Intel i3")]
        [InlineData("Intel i5","Processor     ----> Intel i5")]
        [InlineData("Intel i7","Processor     ----> Intel i7")]
        [InlineData("Intel i9","Processor     ----> Intel i9")]
        public void CheckTheSystemRam(string ProcessorType, String Solution)
        {
              SystemProcessor.Processor=ProcessorType;
              Assert.Equal(Solution,SystemProcessor.displayProcessor());

        }

        



    }
}
