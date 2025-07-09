using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClaseJC
    {
        string[] articulos = new string[]
            {
                "Harina","Arroz","Pasta","Azúcar","Café","Avena", "Cereales",
                "Pan","Aceite comestible","Sal","Salsa de tomate","Mayonesa",
                "Mermelada","Vinagre","Atún en lata","Sardinas en lata","Frijoles en lata",
                "Champiñones enlatados","Puré de tomate","Mole o salsa preparada",
                "Leche líquida","Leche condensada","Crema de leche","Yogur",
                "Queso","Mantequilla","Huevo","Leche en polvo","Chocolate en polvo",
                "Café instantáneo","Agua embotellada","Refrescos","Jugos o néctares",
                "Bebidas energéticas","Té preparado","Papas fritas","Botanas saladas",
                "Galletas","Chocolate en barra","Caramelos y paletas","Chicles","Bombones",
                "Jamón","Salchichas","Mortadela","Jabón de tocador","Pasta dental",
                "Papel higiénico","Detergente para ropa","Gel antibacterial"
            };
        //como se debe de enviar ----> solucion: ExamenFinal_(PrimerNombrePrimerApellido)(Ejem.JhocepChuquimango)
        //clase: clases_JJ
        int[,] matriz = new int[7, 7];
        string[] arti = new string[7];
        public void generarArti()
        {
            Random r = new Random();
            for (int i = 0; i < arti.Length; i++)
            {
                int i_articulos = r.Next(0, articulos.Length);
                arti[i] = articulos[i_articulos];
            }
        }
        public void GenerarPrecioL()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 0] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioM()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 1] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioMi()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 2] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioJ()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 3] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioV()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 4] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioS()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 5] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void GenerarPrecioD()
        {
            Random r = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int nota = r.Next(15, 200);
                Console.WriteLine(arti[i] + ": " + nota);
                matriz[i, 6] = nota;
                Thread.Sleep(100); //tiempo
            }
        }
        public void Tablageneral()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write(Espacios("Artículo", 20));
            string[] dias = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
            for (int i = 0; i < dias.Length; i++)
            {
                Console.Write(EspaciosIzq(dias[i], 6));
            }
            Console.Write(EspaciosIzq("    Total por articulo", 8));
            Console.WriteLine();
            Console.ResetColor();

            int[] sumaCols = new int[7];

            for (int i = 0; i < 7; i++)
            {
                int sumaFila = 0;
                Console.Write(Espacios(arti[i], 20));
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(EspaciosIzq(matriz[i, j].ToString(), 6));
                    sumaFila += matriz[i, j];
                    sumaCols[j] += matriz[i, j];
                }
                Console.Write(EspaciosIzq(sumaFila.ToString(), 8));
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Espacios("Total por día:", 20));
            int totalGeneral = 0;
            for (int j = 0; j < 7; j++)
            {
                Console.Write(EspaciosIzq(sumaCols[j].ToString(), 6));
                totalGeneral += sumaCols[j];
            }
            Console.Write(EspaciosIzq(totalGeneral.ToString(), 8));
            Console.WriteLine();
            Console.ResetColor();
        }
        public string Espacios(string texto, int longitud)
        {
            while (texto.Length < longitud)
            {
                texto += " ";
            }
            return texto;
        }

        public string EspaciosIzq(string texto, int longitud)
        {
            while (texto.Length < longitud)
            {
                texto = " " + texto;
            }
            return texto;
        }
        public void minymax()
        {
            int[,] minMax = new int[2, 7];

            for (int i = 0; i < 7; i++)
            {
                minMax[0, i] = int.MaxValue;
                minMax[1, i] = int.MinValue;

                for (int j = 0; j < 7; j++)
                {
                    int v = matriz[i, j];
                    if (v < minMax[0, i]) minMax[0, i] = v;
                    if (v > minMax[1, i]) minMax[1, i] = v;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mínimos y Máximos por artículo:");
            Console.WriteLine(Espacios("Artículo", 20) + EspaciosIzq("Min", 8) + EspaciosIzq("Max", 8));
            Console.ResetColor();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(Espacios(arti[i], 20) + EspaciosIzq(minMax[0, i].ToString(), 8) + EspaciosIzq(minMax[1, i].ToString(), 8));
            }
        }
        public void Promedio(string prom)
        {
            double[,] promedios = new double[7, 1];

            for (int i = 0; i < 7; i++)
            {
                int suma = 0;
                for (int j = 0; j < 7; j++)
                {
                    suma += matriz[i, j];
                }
                promedios[i, 0] = suma / 7;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Promedio semanal por artículo:");
            Console.WriteLine(Espacios("Artículo", 20) + EspaciosIzq("Promedio", 10));
            Console.ResetColor();

            for (int i = 0; i < 7; i++)
            {
                double v = promedios[i, 0];
                Console.WriteLine(Espacios(arti[i], 20) + EspaciosIzq(prom, 10));
            }
        }
    }
}