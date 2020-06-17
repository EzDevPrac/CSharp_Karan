using System;

namespace ComplexNumbers
{
    public class ComplexNumbers
    {
        private int Real;

        private int Imaginary;
       
       public ComplexNumbers(){}
       public ComplexNumbers(int RealNumber,int ImaginaryNumber)
       {

           Real = RealNumber;
           Imaginary = ImaginaryNumber;
       } 
       public int _Real{
           get{
               return Real;
           }

           set{
               Real = value;
           }
       }

       public int _Imaginary{
           get{
               return Imaginary;
           }

           set{
               Imaginary = value;
           }
       }

       public new string ToString(){

           return "(" + Real.ToString() + "," + Imaginary.ToString() + ")";
       }
       public double GetMagnitude()
       {
           double answer = (Real*Real) + (Imaginary*Imaginary);
           return Math.Sqrt(answer);
       }
        

        public static ComplexNumbers operator +(ComplexNumbers c1, ComplexNumbers c2)  
        {  
          ComplexNumbers temp = new ComplexNumbers();  
          temp.Real = c1.Real + c2.Real;  
          temp.Imaginary = c1.Imaginary + c2.Imaginary;  
          return temp;  
        }

        public static ComplexNumbers operator -(ComplexNumbers c1, ComplexNumbers c2)  
        {  
          ComplexNumbers temp = new ComplexNumbers();  
          temp.Real = c1.Real - c2.Real;  
          temp.Imaginary = c1.Imaginary - c2.Imaginary;  
          return temp;  
        }  
       /*public void AddComplexNumbers(ComplexNumbers CN1,ComplexNumbers CN2){
        
       ComplexNumbers Add = new ComplexNumbers(); 
        Add.Real = CN1._Real + CN2._Real;
        Add.Imaginary = CN1._Imaginary + CN2._Imaginary;

        Console.WriteLine("(" + Add.Real.ToString() + "," + Add.Imaginary.ToString() + ")");
      }

      public void SubtractComplexNumbers(ComplexNumbers number1, ComplexNumbers number2){
        ComplexNumbers Subtract = new ComplexNumbers(); 
        Subtract.Real = number1._Real - number2._Real;
        Subtract.Imaginary = number1._Imaginary - number2._Imaginary;

        Console.WriteLine("(" + Subtract.Real.ToString() + "," + Subtract.Imaginary.ToString() + ")");
        

      }*/
     }
}