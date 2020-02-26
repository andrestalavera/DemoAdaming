namespace Calculator
{
    class CalculatorNok : ICalculator
    {
        public int Add(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b - c;
        }

        public int Multiply(int a, int b)
        {
            return a + b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a + b;
        }
    }
}
