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
        static void Main(string[] args)
        {
            // esercizio 1
            Console.WriteLine("Esercizio 1");
            Console.WriteLine("---------------");
            int[,] m = { {5, 3}, {2 , 4}, {7 , 4} };
            int somma = 0;
            Console.WriteLine(Somma(m, somma));
            Console.WriteLine();

            // esercizio 2
            Console.WriteLine("Esercizio 2");
            Console.WriteLine("---------------");
            float media = 0;
            Console.WriteLine(Media(m, media));
            Console.WriteLine();

            // esercizio 3
            Console.WriteLine("Esercizio 3");
            Console.WriteLine("---------------");
            int min = 1000;
            Console.WriteLine(Minimo(m));
            Console.WriteLine();

            // esercizio 4
            Console.WriteLine("Esercizio 4");
            Console.WriteLine("---------------");
            int max = 0;
            Console.WriteLine(Massimo(m));
            Console.WriteLine();




        }
    }
}
