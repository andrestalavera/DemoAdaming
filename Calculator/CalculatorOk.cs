namespace Calculator
{
    class CalculatorOk : ICalculator
    {
        public string GetMyName(string name)
        {
            return name;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a / b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
