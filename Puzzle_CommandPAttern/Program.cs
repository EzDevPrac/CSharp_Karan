using System;

namespace Puzzle_CommandPAttern
{
    //'ICommand' interface
    public interface ICommand
    {
        void Execute();
    }
    //'Invoker' class
    public class Invoker
    {
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
    //'Receiver' class
    public class solvePuzzle
    {
        private int _total, _sum;
        private int[] _array = new int[100];

        public solvePuzzle(int total, int sum, int[] array)
        {
            _total = total;
            _sum = sum;
            _array=array;
        }
        public void method1()
        {
            int count=0;
           
            
            for(int i=0;i<_total-1;i++)
           {
            if(_array[i]<_sum)
             { for(int j= i+1;j<_total;j++)
              {
                  if(_array[i] + _array[j]==_sum)
                  {
                      Console.WriteLine("Pair Found At Index " + i +" and "+ j + "(" + _array[i] +"+"+ _array[j]+")");
                      count++;
                  }

              }
             }
             else
             { 
                 continue;
             } 
           }
           if(count==0)
           {
               Console.WriteLine("No pIars Found in the given array");
           }


        }

    }
    //'ConcreteCommand1' class
    public class method1Command : ICommand
    {
        private solvePuzzle _solvePuzzle;

        public method1Command(solvePuzzle solvePuzzle)
        {
            _solvePuzzle = solvePuzzle;
        }

        public void  Execute()
        {
         _solvePuzzle.method1();
        }
    }
    //'ConcreteCommand2' class
    /*public class SubtractCommand : ICommand
    {
        private Calculator _calculator;

        public SubtractCommand(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Substract();
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {   
            int[] Array =new int[100];
            Console.WriteLine("Enter the no of elements in the array");
            int total = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            for(int i=0;i<total;i++)
            {
               Array[i]= Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the sum of the number to be found");
            int Sum =Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Commands for Calculator: Type 1 for Method 1 and 2 for substraction");
            string command = Console.ReadLine();

            Invoker invoker = new Invoker();
            solvePuzzle solve = new solvePuzzle(total,Sum,Array);
            //method1Command M1Command = new method1Command(solve);
            //SubtractCommand substractCommand = new SubtractCommand(calculator);

            if (command == "1")
            {
                //Console.WriteLine(invoker.ExecuteCommand(solve));
            }
            else if (command == "2")
            {
                Console.WriteLine("Uner progress");
            }
            else
            {
                Console.WriteLine("Under Progress");
            }

            Console.ReadLine();
        }
    }

}
