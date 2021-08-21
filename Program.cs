using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.Clear();
            Console.Beep();

            Console.Write("Digite o texto : ");
            texto = Console.ReadLine().Replace("r", "l").Replace("R","L");

            Console.Beep();
            Console.Write("\nComo diz o cebolinha : ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(texto);

            Console.ResetColor();
            
        
        }
    }
}
