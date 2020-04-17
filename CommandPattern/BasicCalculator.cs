using System;

namespace CommandPattern
{
    class  BasicCalculator

    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Enter First Value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Commands for Calculator: Type 1 for Addition and 2 for substraction");
            string command = Console.ReadLine();

            Invoker invoker = new Invoker();
            Calculator calculator = new Calculator(a, b);
            Add addCommand = new Add(calculator);
            Subtract substractCommand = new Subtract(calculator);

            if (command == "1")
            {
                Console.WriteLine("Add Command is selected and the Result is {0}", invoker.ExecuteCommand(addCommand));
            }
            else if (command == "2")
            {
                Console.WriteLine("Substract Command is selected and the Result is {0}", invoker.ExecuteCommand(substractCommand));
            }
            else
            {
                Console.WriteLine("You have entered wrong command. Please type Command '1' for addition or '2' for substraction");
            }

            Console.ReadLine();
        }
    }


}
