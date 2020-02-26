using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new CalculatorOk(); // new CalculatorNok();
            try
            {
                Console.WriteLine(calculator.Add(2, 2, 3));
                Console.WriteLine(calculator.Divide(5, 2));
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Termine d'écrire ton programme. " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Tu t'y connais un peu en maths ? " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ecris ton programme correctement! " + ex.Message);
            }
        }
    }
}
