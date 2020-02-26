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
            if (a == 2 || b == 2)
            {
                throw new AddByTwoException("car je suis le Schtroumph Grognon.");
            }
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            if (a == 2 || b == 2 || c == 2)
            {
                throw new AddByTwoException("car je m'appelle Garfield");
            }
            return a + b + c;
        }
    }
}
