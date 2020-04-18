using System;
using Xunit;
using BuilderPattern;


namespace BuilderPattern.Test
{  


    
   public class CheckClassToyClass
   {


       [Fact]
       public void CheckForToyTypeAsPlastic()
       {
              Toy toy = new Toy();
              toy.Model="Plastic";

              Assert.Equal("Plastic",toy.Model);

       }   

       
       
    }
}
