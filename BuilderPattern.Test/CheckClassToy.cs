using System;
using Xunit;
using BuilderPattern;


namespace BuilderPattern.Test
{  


    
   public class CheckClassToy
   {
          Toy toy = new Toy();
         
       [Fact]
             public void CheckForToyTypeAsPlastic()
       {
              
              toy.Body="Plastic";

              Assert.Equal("Plastic",toy.Body);

       }
       
       [Fact]
       public void checkforToyWithTwoHeads()
       {
                 toy.Head="2";
                 Assert.Equal("2",toy.Head);


       }   
       
        [Fact]
        public void CheckForToyWithTwoLimbs(){
               toy.Limbs="2";
               Assert.Equal("2",toy.Limbs);


        }

        [Fact]

        public void CheckForToyWithFourLegs(){
              
              toy.Legs="4";
              Assert.Equal("4",toy.Legs);

        }
       [Fact]

       public void CheckForToyOfModelA()
       {
             toy.Model="Toy A";

             Assert.Equal("Toy A",toy.Model);


       }
       
       
    }
}
