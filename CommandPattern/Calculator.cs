using System;

namespace CommandPattern {

    //'Receiver' class
    public class Calculator
    {
        private int _number1, _number2;

        public Calculator(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Add()
        {
            return _number1 + _number2;
        }

        public int Substract()
        {
            return _number1 - _number2;
        }
    }



}