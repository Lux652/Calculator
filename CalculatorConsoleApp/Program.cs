using System;
using Calculation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float fFirstNumber;
            float fsecondNumber;
            float fResult = 0;

            Calculator Calculator = new Calculator();

            Console.WriteLine("Unesite prvi broj: ");
            fFirstNumber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            fsecondNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Odaberite jednu od ponuđenih opcija:");
            Console.WriteLine("I Zbrajanje");
            Console.WriteLine("II Oduzimanje");
            Console.WriteLine("III Množenje");
            Console.WriteLine("IV Dijeljenje");

            int nDecision = Convert.ToInt16(Console.ReadLine());
            
            switch(nDecision)
            {
                case 1:
                    fResult = Calculator.Add(fFirstNumber, fsecondNumber);
                    break;
                case 2:
                    fResult = Calculator.Substract(fFirstNumber, fsecondNumber);
                    break;
                case 3:
                    fResult = Calculator.Multiply(fFirstNumber, fsecondNumber);
                    break;
                case 4:
                    fResult = Calculator.Divide(fFirstNumber, fsecondNumber);
                    break;
            }

            Console.WriteLine("Rezultat: " + fResult);
            Console.ReadKey();           
    
        }
    }
}
