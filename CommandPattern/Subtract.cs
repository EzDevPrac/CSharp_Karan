using System;

namespace CommandPattern {


 //'Concrete Command for Subtract class'
    public class Subtract: Command
    {
        private Calculator _calculator;

        public Subtract(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Substract();
        }
    }

}