using System;

namespace FactoryPattern
{
    public class UnknownCalculatorTypeException : Exception
    {
        public UnknownCalculatorTypeException(CalculatorType type)
        {
            //bla bla bla
        }
    }
}