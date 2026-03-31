using System.Globalization;

namespace Grafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo<string> mappa = new Grafo<string>(10);
            
            while (true) {
                int scelta =0;
                Console.WriteLine("cosa vui fare 0(aggiungi)/1(connetti)");
                scelta = int.Parse(Console.ReadLine());

                if (scelta == 0)
                {
                    Console.WriteLine("Inserisci il nome della tua città");
                    string name = Console.ReadLine().ToLower();
                    mappa.Add(name);
                }
                else
                {

                    Console.WriteLine("Inserisci le due città da collegare");
                    Console.Write("Città di partenza >");
                    string firscity = Console.ReadLine().ToLower();

                    Console.Write("Città di arrivo >");
                    string secondcity = Console.ReadLine().ToLower();

                    mappa.AddMonoDirectionArch(firscity, secondcity);

                }

                Stampamatrice(mappa);

            }
            
        
        }

        public static void Stampamatrice(Grafo<string> grafo)
        {
            
            foreach(var x in grafo.Nodi) 
            { 
                Console.Write($"{x}-");
            }
            Console.WriteLine();

            int[,] matrix = grafo.matrice;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                Console.WriteLine();
            }
            
        }
    }
}