namespace Calculator
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Add(int a, int b, int c);
        int Multiply(int a, int b);
        decimal Divide(decimal a, decimal b);
        int Substract(int a, int b);
    }
}
