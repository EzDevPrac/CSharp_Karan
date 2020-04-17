using System;

namespace CommandPattern {

//'Invoker' class
    public class Invoker
    {
        public int ExecuteCommand(Command command)
        {
            return command.Execute();
        }
    }

}