using System;

namespace CommandPattern {

//'Concrete Command  to Add ' class
    public class Add : Command
    {
        private Calculator _calculator;

        public Add(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Add();
        }
    }


}