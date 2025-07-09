using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteca;

namespace ExamenFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseJC an = new ClaseJC();
            an.generarArti();
            an.GenerarPrecioL();
            Console.Clear();
            an.GenerarPrecioM();
            Console.Clear();
            an.GenerarPrecioMi();
            Console.Clear();
            an.GenerarPrecioJ();
            Console.Clear();
            an.GenerarPrecioV();
            Console.Clear();
            an.GenerarPrecioS();
            Console.Clear();
            an.GenerarPrecioD();
            Console.Clear();
            an.Tablageneral();
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ESPERE UN MOMENTO, EL SIGUIENTE ES SOBRE CANTIDADES MÁXIMAS Y MÍNIMAS VENDIDAS");
            Console.ResetColor();
            Thread.Sleep(2500);
            an.minymax();
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ESPERE UN MOMENTO, EL SIGUIENTE ES EL PROMEDIO");
            Console.ResetColor();
            Thread.Sleep(2500);
            an.Promedio();
        }
    }
}
