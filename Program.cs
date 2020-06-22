using System;

namespace Aula22MetodosEatributosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Conversor.CotacaoDolar = 5.23f;
            Console.WriteLine("O valor em Dólar convertido em Real: " + Conversor.ConverterDolarParaReal(200));
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O valor em Real convertido em Dólar: " +Conversor.ConverterRealParaDolar(200));
            Console.ResetColor();
            
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Conversor.CotacaoDolar = 5.90f;
            Console.WriteLine("O valor em Euro convertido em Real: " + Conversor.ConverterEuroParaReal(200));
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O valor em Real convertido em Euro: " +Conversor.ConverterRealParaEuro(200));
            Console.ResetColor();
        }
    }
}
