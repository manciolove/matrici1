using System;

namespace matrici1
{
    internal class Program
    {
        // funzione esercizio 1
        static int Somma(int[,] m, int somma = 0)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    somma = somma + m[i, j];
                }
            }
            return somma;
        }

        // funzione esercizio 2
        static float Media (int[,] m, float media = 0)
        {
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0;j < m.GetLength(1); j++)
                {
                    somma = somma + m[i,j];
                }
            }
            media = (float) somma / (m.GetLength(0) * m.GetLength(1));
            return media;
        }

        // funzione esercizio 3
        static int Minimo(int[,] m)
        {
            int min = m[0, 0];
            for (int i = 0;i < m.GetLength(0); i++)
            {
                for ( int j=0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] < min)
                    {
                        min = m[i, j];
                    }
                }
            }
            return min;
        }

        // funzione esercizio 4
        static int Massimo (int[,] m)
        {
            int max = m[0,0];
            for ( int i = 0; i < m.GetLength(0); i++)
            {
                for ( int j=0; j< m.GetLength(1) ; j++)
                {
                    if (m[i, j] > max)
                    {
                        max = m[i, j];
                    }
                }
            }
            return max;
        }

        // funzione esercizio 5
        static bool ControlloUguale(int[,] m)
        {
            int x = 7;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i,j] == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // funzione esercizio 6 
        static int[,] Copia(int[,] m)
        {
            int[,] copia = new int[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < copia.GetLength(0); i++)
            {
                for (int j = 0; j < copia.GetLength(1); j++)
                {
                            copia[i, j] = m[i, j];
                }
            }
            return copia;
        }

        static void Main(string[] args)
        {
            // esercizio 1
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 1");
            int[,] m = { { 5, 3 }, { 2, 4 }, { 7, 4 } };
            int somma = 0;
            Console.WriteLine("risultato: " + Somma(m, somma));
            Console.WriteLine("---------------");
            Console.WriteLine();

            // esercizio 2
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 2");
            float media = 0;
            Console.WriteLine("risultato: " + Media(m, media));
            Console.WriteLine("---------------");
            Console.WriteLine();

            // esercizio 3
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 3");
            Console.WriteLine("risultato: " + Minimo(m));
            Console.WriteLine("---------------");
            Console.WriteLine();

            // esercizio 4
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 4");
            Console.WriteLine("risultato: " + Massimo(m));
            Console.WriteLine("---------------");
            Console.WriteLine();

            // esercizio 5
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 5");
            Console.WriteLine("risultato: " + ControlloUguale(m));
            Console.WriteLine("---------------");
            Console.WriteLine();

            // esericizio 6
            Console.WriteLine("---------------");
            Console.WriteLine("Esercizio 6");

            int[,] m2 = Copia(m);
            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    Console.Write("[" + m2[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
            Console.WriteLine();

        }

    }
}
